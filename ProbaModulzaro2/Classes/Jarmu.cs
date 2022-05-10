using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaModulzaro2
{
    delegate bool EldontoFuggvenyTarolo(Jarmu jarmu);
    enum Valasztas
    {
        Busz, Metró, Villamos
    }
    
    // Azonosító(nem lehet üres, egy pontosan 8 karakteres szöveg)
    // Gyártó neve(nem lehet üres)
    // Futott kilométer(minimum 1)
    // Ajtók száma(minimum 1)
    // Férőhelyek száma(minimum 10)
    abstract class Jarmu
    {
        int id;
        string azonosito;
        string gyartoNeve;
        int futottKm;
        byte ajtokSzama;
        int ferohelyekSzama;

        public int Id
        {
            get => id;
            private set
            {
                if (id == -1) { id = value; }
                else { throw new InvalidOperationException("Az ID módosítása nem lehetséges, mert már van értéke!"); }
            }
        }
        public string Azonosito
        {
            get => azonosito;
            set
            {
                if (value.Trim().Length == 8) { azonosito = value; }
                else { throw new ArgumentException("Az AZONOSÍTÓ nem lehet üres, és pontosan 8 karakter kell, hogy legyen!"); }
            }
        }
        public string GyartoNeve
        {
            get => gyartoNeve;
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()) && value.Trim().Length <= 40) { gyartoNeve = value; }
                else { throw new ArgumentException("A GYÁRTÓ nem lehet üres!"); }
            }
        }
        public int FutottKm
        {
            get => futottKm;
            set
            {
                if (value > 0 && value >= futottKm) { futottKm = value; }
                else { throw new ArgumentException("A FUTOTT KM nem lehet 0, és nem lehet kisebb, mint az utolsó érték!"); }
            }
        }
        public byte AjtokSzama
        {
            get => ajtokSzama;
            set
            {
                if (value > 0) { ajtokSzama = value; }
                else { throw new ArgumentException("Az AJTÓK SZÁMA nem lehet 0!"); }
            }
        }
        public int FerohelyekSzama
        {
            get => ferohelyekSzama;
            set
            {
                if (value > 9) { ferohelyekSzama = value; }
                else { throw new ArgumentException("A FÉRŐHELYEK SZÁMA minimum 10 kell, hogy legyen!"); }
            }
        }

        protected Jarmu(string azonosito, string gyartoNeve, int futottKm, byte ajtokSzama, int ferohelyekSzama, int id = -1)
        {
            if (id != -1) { this.id = id; }
            Azonosito = azonosito;
            GyartoNeve = gyartoNeve;
            FutottKm = futottKm;
            AjtokSzama = ajtokSzama;
            FerohelyekSzama = ferohelyekSzama;
        }

        public override string ToString()
        {
            return $"{id} - {azonosito} - {gyartoNeve} - {futottKm} - {ajtokSzama} - {ferohelyekSzama}";
        }

        public virtual string ToDetails()
        {
            return $"JÁRMŰ ADATOK\n\rId: {id}\n\rAzonosító: {azonosito}\n\rGyártó neve: {gyartoNeve}\n\rFutott Km: {futottKm}\n\rAjtók száma: {ajtokSzama}\n\rFérőhelyek száma: {ferohelyekSzama}\n\r";
        }

        public static SajatLista Szures(SajatLista jarmuvek, EldontoFuggvenyTarolo eldontes)
        {
            SajatLista szurtLista = new SajatLista();
            foreach (Jarmu item in jarmuvek)
            {
                if (eldontes(item))
                {
                    szurtLista.Add(item);
                }
            }
            return szurtLista;
        }

        public abstract double AktualisAr();
    }
}
