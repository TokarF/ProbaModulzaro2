using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaModulzaro2
{
    enum Funkcio
    {
        Létrehozás,
        Módosítás,
        Megjelenítés,
        Törlés,
        Rendezés,
        Szűrés,
        Keresés,
        Kötöttpályás_adatok
    }

    static class LogKezeles
    {
        static StreamWriter logFile;

        public static void LogNyitas()
        {
            string fileNev = "jarmuvek_log.csv";
            logFile = new StreamWriter(fileNev, true, Encoding.Default);
            logFile.WriteLine("==================================================");
            logFile.WriteLine($"Programfutás kezdete: {DateTime.Now}");
            logFile.WriteLine($"Programot futtató felhasználó: {Environment.UserName} / {Environment.UserDomainName}");
            logFile.Flush();
        }

        public static void LogZaras()
        {
            logFile.WriteLine($"Programfutás vége: {DateTime.Now}");
            logFile.Close();
        }

        public static void LogIras(Funkcio id, Jarmu jarmu = null)
        {
            switch (id)
            {
                case Funkcio.Létrehozás:
                    if (jarmu != null)
                    {
                        logFile.WriteLine($"Jármű létrehozva: {jarmu.Id} - {jarmu.Azonosito} ({DateTime.Now})");
                    }
                    break;
                case Funkcio.Módosítás:
                    if (jarmu != null)
                    {
                        logFile.WriteLine($"Jármű módosítva: {jarmu.Id} - {jarmu.Azonosito} ({DateTime.Now})");
                    }
                    break;
                case Funkcio.Megjelenítés:
                    if (jarmu != null)
                    {
                        logFile.WriteLine($"Jármű megjelenítve: {jarmu.Id} - {jarmu.Azonosito} ({DateTime.Now})");
                    }
                    break;
                case Funkcio.Törlés:
                    if (jarmu != null)
                    {
                        logFile.WriteLine($"Jármű törölve: {jarmu.Id} - {jarmu.Azonosito} ({DateTime.Now})");
                    }
                    break;
                case Funkcio.Rendezés:
                    logFile.WriteLine($"Rendezés funkció végrehajtva. ({DateTime.Now})");
                    break;
                case Funkcio.Szűrés:
                    logFile.WriteLine($"Szűrés funkció végrehajtva. ({DateTime.Now})");
                    break;
                case Funkcio.Keresés:
                    logFile.WriteLine($"Keresés funkció végrehajtva. ({DateTime.Now})");
                    break;
                case Funkcio.Kötöttpályás_adatok:
                    if (jarmu != null)
                    {
                        logFile.WriteLine($"kötöttpályás jármű adatok megjelenítve: {jarmu.Id} - {jarmu.Azonosito} ({DateTime.Now})");
                    }
                    break;
            }
        }
    }
}
