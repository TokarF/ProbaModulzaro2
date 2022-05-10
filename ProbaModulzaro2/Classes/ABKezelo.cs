using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaModulzaro2
{
    static class ABKezelo
    {
        static SqlConnection conn = new SqlConnection();
        static SqlCommand cmd = new SqlCommand();

        // Kapcsolat nyitás
        public static void KapcsolatNyitas(string connStr)
        {
            try
            {
                conn.ConnectionString = connStr;
                conn.Open();
                cmd.Connection = conn;
            }
            catch (Exception ex)
            {
                throw new ABKivetel("Sikertelen csatlakozás az adatbázishoz!", ex.Message);
            }
        }
        // Kapcsolat zárás
        public static void KapcsolatZaras()
        {
            try
            {
                conn.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new ABKivetel("Sikertelen kapcsolatbontás!", ex.Message);
            }
        }
        // Teljes lekérdezés
        public static List<Jarmu> TeljesLekerdezes()
        {
            try
            {
                //SELECT* FROM[Jarmuvek] LEFT JOIN[Buszok] ON[Jarmuvek].[Id] = [buszok].[Id] LEFT JOIN[KotottPalyasok] ON[Jarmuvek].[Id] = [KotottPalyasok].[Id] LEFT JOIN[Metrok] ON[KotottPalyasok].[Id] = [Metrok].[Id] LEFT JOIN[Villamosok] ON[KotottPalyasok].[Id] = [Villamosok].[Id];
                List<Jarmu> jarmuvek = new List<Jarmu>();
                // 1. Buszok
                cmd.CommandText = "SELECT * FROM [Jarmuvek] INNER JOIN [Buszok] ON [Jarmuvek].[Id] = [Buszok].[Id]";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    jarmuvek.Add(new Busz((bool)reader["Hibrid"], (bool)reader["Csuklos"], (int)reader["Benzintartaly"], reader["Azonosito"].ToString(), reader["gyartoNeve"].ToString(), (int)reader["FutottKm"], (byte)reader["AjtokSzama"], (int)reader["FerohelyekSzama"], (int)reader["Id"]));
                }
                reader.Close();
                // 2. Metrók
                cmd.CommandText = "SELECT * FROM [Jarmuvek] INNER JOIN [KotottPalyasok] ON [Jarmuvek].[Id] = [KotottPalyasok].[Id] INNER JOIN [Metrok] ON [KotottPalyasok].[Id] = [Metrok].[Id]";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    jarmuvek.Add(new Metro((byte)reader["SzerelvenyekSzama"], (int)reader["SinSzelesseg"], (AramEllatasTipus)(int)reader["AramEllatasTipus"], reader["Azonosito"].ToString(), reader["gyartoNeve"].ToString(), (int)reader["FutottKm"], (byte)reader["AjtokSzama"], (int)reader["FerohelyekSzama"], (int)reader["Id"]));
                }
                reader.Close();
                // 3. Villamosok
                cmd.CommandText = "SELECT * FROM [Jarmuvek] INNER JOIN [KotottPalyasok] ON [Jarmuvek].[Id] = [KotottPalyasok].[Id] INNER JOIN [Villamosok] ON [KotottPalyasok].[Id] = [Villamosok].[Id]";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    jarmuvek.Add(new Villamos((bool)reader["Egybenyitott"], (int)reader["SinSzelesseg"], (AramEllatasTipus)(int)reader["AramEllatasTipus"], reader["Azonosito"].ToString(), reader["gyartoNeve"].ToString(), (int)reader["FutottKm"], (byte)reader["AjtokSzama"], (int)reader["FerohelyekSzama"], (int)reader["Id"]));
                }
                reader.Close();
                // Lamdba LINQ-val sorrendbe rendezem Id alapján.
                return jarmuvek.OrderBy(x => x.Id).ToList();
            }
            catch (Exception ex)
            {
                throw new ABKivetel("Sikertelen lekérdezés!", ex.Message);
            }
        }
        // Új jármű létrehozása
        public static void JarmuLetrehozas(Jarmu uj)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Transaction = conn.BeginTransaction();
                // 1. Jármű létrehozása
                cmd.CommandText = "INSERT INTO [Jarmuvek] OUTPUT INSERTED.Id VALUES (@azonosito, @gyartoNeve, @futottKm, @ajtokSzama, @ferohelyekSzama)";
                cmd.Parameters.AddWithValue("@azonosito", uj.Azonosito);
                cmd.Parameters.AddWithValue("@gyartoNeve", uj.GyartoNeve);
                cmd.Parameters.AddWithValue("@futottKm", uj.FutottKm);
                cmd.Parameters.AddWithValue("@ajtokSzama", uj.AjtokSzama);
                cmd.Parameters.AddWithValue("@ferohelyekSzama", uj.FerohelyekSzama);
                int id = -1;
                id = (int)cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                // 2. Ha az objektum BUSZ, akkor létrehozom
                if (id != -1)
                {
                    if (uj is Busz busz)
                    {
                        cmd.CommandText = "INSERT INTO [Buszok] VALUES (@id, @hibrid, @csuklos, @benzintartaly)";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@hibrid", busz.Hibrid);
                        cmd.Parameters.AddWithValue("@csuklos", busz.Csuklos);
                        cmd.Parameters.AddWithValue("@benzintartaly", busz.Benzintartaly);
                        cmd.ExecuteNonQuery();
                    }
                    // 3. Ha az objektum nem BUSZ, akkor létrehozom a kötöttpályást
                    else if(uj is KotottPalyas kotottPalyas)
                    {
                        cmd.CommandText = "INSERT INTO [KotottPalyasok] VALUES (@id, @sinSzelesseg, @aramEllatas)";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@sinSzelesseg", kotottPalyas.SinSzelesseg);
                        cmd.Parameters.AddWithValue("@aramEllatas", (int)kotottPalyas.AramEllatasTipusa);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        // 4. Ha az objektum METRO, vagy VILLAMOS, akkor úgy hozom létre
                        if (uj is Metro metro)
                        {
                            cmd.CommandText = "INSERT INTO [Metrok] VALUES (@id, @szerelvenyekSzama)";
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@szerelvenyekSzama", metro.SzerelvenyekSzama);
                            cmd.ExecuteNonQuery();
                        }
                        else if(uj is Villamos villamos)
                        {
                            cmd.CommandText = "INSERT INTO [Villamosok] VALUES (@id, @egybenyitott)";
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@egybenyitott", villamos.EgybenyitottTeru);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                cmd.Transaction.Commit();
            }
            catch (Exception ex)
            {
                try
                {
                    if (cmd.Transaction != null)
                    {
                        cmd.Transaction.Rollback();
                    }
                }
                catch (Exception innerEx)
                {
                    throw new ABKivetel("Végzetes hiba történt! A tranzakció lezárása sikertelen!", innerEx.Message);
                }
                throw new ABKivetel("A jármű létrehozása sikertelen!", ex.Message);
            }
        }
        // Jármnű módosítása
        public static void JarmuModositas(Jarmu modositando)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Transaction = conn.BeginTransaction();
                // 1. Jármű módosítása
                cmd.CommandText = "UPDATE [Jarmuvek] SET [Azonosito] = @azonosito, [GyartoNeve] = @gyartoNeve, [FutottKm] = @futottKm, [AjtokSzama] = @ajtokSzama, [FerohelyekSzama] = @ferohelyekSzama WHERE [Id] = @id";
                cmd.Parameters.AddWithValue("@azonosito", modositando.Azonosito);
                cmd.Parameters.AddWithValue("@gyartoNeve", modositando.GyartoNeve);
                cmd.Parameters.AddWithValue("@futottKm", modositando.FutottKm);
                cmd.Parameters.AddWithValue("@ajtokSzama", modositando.AjtokSzama);
                cmd.Parameters.AddWithValue("@ferohelyekSzama", modositando.FerohelyekSzama);
                cmd.Parameters.AddWithValue("@id", modositando.Id);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                // 2. Ha az objektum BUSZ, akkor módosítom
                if (modositando is Busz busz)
                {
                    cmd.CommandText = "UPDATE [Buszok] SET [Hibrid] = @hibrid, [Csuklos] = @csuklos, [Benzintartaly] = @benzintartaly WHERE [Id] = @id";
                    cmd.Parameters.AddWithValue("@hibrid", busz.Hibrid);
                    cmd.Parameters.AddWithValue("@csuklos", busz.Csuklos);
                    cmd.Parameters.AddWithValue("@benzintartaly", busz.Benzintartaly);
                    cmd.Parameters.AddWithValue("@id", busz.Id);
                    cmd.ExecuteNonQuery();
                }
                // 3. Ha az objektum nem BUSZ, akkor módosítom a kötöttpályást
                else if (modositando is KotottPalyas kotottPalyas)
                {
                    cmd.CommandText = "UPDATE [KotottPalyasok] SET [SinSzelesseg] = @sinSzelesseg, [AramEllatasTipus] = @aramEllatas WHERE [Id] = @id";
                    cmd.Parameters.AddWithValue("@sinSzelesseg", kotottPalyas.SinSzelesseg);
                    cmd.Parameters.AddWithValue("@aramEllatas", (int)kotottPalyas.AramEllatasTipusa);
                    cmd.Parameters.AddWithValue("@id", kotottPalyas.Id);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    // 4. Ha az objektum METRO, vagy VILLAMOS, akkor úgy hozom létre
                    if (modositando is Metro metro)
                    {
                        cmd.CommandText = "UPDATE [Metrok] SET [SzerelvenyekSzama] = @szerelvenyekSzama WHERE [Id] = @id";
                        cmd.Parameters.AddWithValue("@szerelvenyekSzama", metro.SzerelvenyekSzama);
                        cmd.Parameters.AddWithValue("@id", metro.Id);
                        cmd.ExecuteNonQuery();
                    }
                    else if (modositando is Villamos villamos)
                    {
                        cmd.CommandText = "UPDATE [Villamosok] SET [Egybenyitott] = @egybenyitott WHERE [Id] = @id";
                        cmd.Parameters.AddWithValue("@egybenyitott", villamos.EgybenyitottTeru);
                        cmd.Parameters.AddWithValue("@id", villamos.Id);
                        cmd.ExecuteNonQuery();
                    }
                }
                cmd.Transaction.Commit();
            }
            catch (Exception ex)
            {
                try
                {
                    if (cmd.Transaction != null)
                    {
                        cmd.Transaction.Rollback();
                    }
                }
                catch (Exception innerEx)
                {
                    throw new ABKivetel("Végzetes hiba történt! A tranzakció lezárása sikertelen!", innerEx.Message);
                }
                throw new ABKivetel("A jármű módosítása sikertelen!", ex.Message);
            }
        }
        // Jármű törlése
        public static void JarmuTorles(Jarmu torlendo)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Transaction = conn.BeginTransaction();
                cmd.Parameters.AddWithValue("@id", torlendo.Id);
                if (torlendo is Busz)
                {
                    cmd.CommandText = "DELETE FROM [Buszok] WHERE [Id] = @id; DELETE FROM [Jarmuvek] WHERE [Id] = @id";
                }
                else if (torlendo is Metro)
                {
                    cmd.CommandText = "DELETE FROM [Metrok] WHERE [Id] = @id; DELETE FROM [KotottPalyasok] WHERE [Id] = @id; DELETE FROM [Jarmuvek] WHERE [Id] = @id";
                }
                else
                {
                    cmd.CommandText = "DELETE FROM [Villamosok] WHERE [Id] = @id; DELETE FROM [KotottPalyasok] WHERE [Id] = @id; DELETE FROM [Jarmuvek] WHERE [Id] = @id";
                }
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (Exception ex)
            {
                try
                {
                    if (cmd.Transaction != null)
                    {
                        cmd.Transaction.Rollback();
                    }
                }
                catch (Exception innerEx)
                {
                    throw new ABKivetel("Végzetes hiba történt! A tranzakció lezárása sikertelen!", innerEx.Message);
                }
                throw new ABKivetel("A jármű törlése sikertelen!", ex.Message);
            }
        }
    }
}
