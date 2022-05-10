using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaModulzaro
{
    class ButorRaktar
    {
        #region Private fileds
        string raktarSzam;
        string raktarNev;
        RaktarCim raktarCime;
        byte butorokMaxSzama;
        bool vasarnap;
        List<AltalanosButor> butorok;
        #endregion

        #region Public properties
        public string RaktarSzam { get => raktarSzam; private set => raktarSzam = value; }
        public string RaktarNev
        {
            get => raktarNev;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    raktarNev = value;
                }
                else
                {
                    throw new Exception("A RAKTÁR NEVE mezőt kötelező kitölteni, nem lehet üres!");
                }
            }
        }
        internal RaktarCim RaktarCime { get => raktarCime; set => raktarCime = value; }
        public byte ButorokMaxSzama
        {
            get => butorokMaxSzama;
            set
            {
                if (value >= 10 && value <= 100)
                {
                    butorokMaxSzama = value;
                }
                else
                {
                    throw new Exception("A BÚTOROK MAXIMÁLIS SZÁMA mező értéke 10 és 100 között kell, hogy legyen!");
                }
            }
        }
        public bool Vasarnap { get => vasarnap; set => vasarnap = value; }
        internal List<AltalanosButor> Butorok
        {
            get => butorok.ToList();
            //get
            //{
            //    List<AltalanosButor> visszaAd = new List<AltalanosButor>();
            //    foreach (AltalanosButor item in butorok)
            //    {
            //        visszaAd.Add(item);
            //    }
            //    return visszaAd;
            //}
            //set => butorok = value; 
        }

        public uint TaroltButorokAra
        {
            get
            {
                uint butorokAraOsszesen = 0;
                foreach (AltalanosButor item in butorok)
                {
                    butorokAraOsszesen += item.ButorAra;
                }
                return butorokAraOsszesen;
            }
        }

        public uint TaroltButorokSzama
        {
            get
            {
                return (byte)butorok.Count;
                //byte butorokSzamaOsszesen = 0;
                //foreach (AltalanosButor item in butorok)
                //{
                //    butorokSzamaOsszesen++;
                //}
                //return butorokSzamaOsszesen;
            }
        }
        #endregion

        #region Constructors
        public ButorRaktar(string raktarSzam, string raktarNev, RaktarCim raktarCime, byte butorokMaxSzama, bool vasarnap)
        {
            butorok = new List<AltalanosButor>();
            RaktarSzam = raktarSzam;
            RaktarNev = raktarNev;
            RaktarCime = raktarCime;
            ButorokMaxSzama = butorokMaxSzama;
            Vasarnap = vasarnap;
        }
        #endregion

        #region Methods
        public static string RaktarSzamMeghatarozas(List<ButorRaktar> raktarLista)
        {
            if (raktarLista.Count == 0)
            {
                // Nincs raktár, visszaadom a 00001 azonosítót.
                return String.Format("{0:00000}", 1);
            }
            else
            {
                //string tmpSzam = raktarLista.Last().RaktarSzam;
                //int tmpInt = int.Parse(tmpSzam);
                //int EzKell = tmpInt + 1;
                // Van raktár, visszaadom az utolsó azonosító + 1 értéket.
                return String.Format("{0:00000}", (int.Parse(raktarLista.Last().raktarSzam)) + 1);
            }
        }

        public string CikkSzamMeghatarozas(bool faButor)
        {
            string cikkSzamTmp = String.Empty;
            //if (faButor)
            //{
            //    foreach (AltalanosButor item in butorok)
            //    {
            //        if (item.CikkSzam.StartsWith("FAB"))
            //        {
            //            cikkSzamTmp = item.CikkSzam;
            //        }
            //    }
            //}
            //else
            //{
            //    foreach (AltalanosButor item in butorok)
            //    {
            //        if (item.CikkSzam.StartsWith("FEM"))
            //        {
            //            cikkSzamTmp = item.CikkSzam;
            //        }
            //    }
            //}

            // ***** LINQ-val megoldva
            //List<AltalanosButor> tmpLista = butorok.Where(x => x.CikkSzam.StartsWith("FAB")).ToList();
            //if (faButor && butorok.Where(x => x.CikkSzam.StartsWith("FAB")).ToList().Count > 0)
            //{
            //    //cikkSzamTmp = butorok.Where(x => x.CikkSzam.StartsWith("FAB")).ToList().Last().CikkSzam;
            //    //cikkSzamTmp = $"FAB{String.Format("{0:00000}", (int.Parse(butorok.Where(x => x.CikkSzam.StartsWith("FAB")).ToList().Last().CikkSzam.Substring(3))) + 1)}";
            //    return $"FAB{String.Format("{0:00000}", (int.Parse(butorok.Where(x => x.CikkSzam.StartsWith("FAB")).ToList().Last().CikkSzam.Substring(3))) + 1)}";
            //}
            //else
            //{
            //    return $"FAB{String.Format("{0:00000}", 1)}";
            //}
            // ***** LINQ-val megoldva

            if (cikkSzamTmp == String.Empty)
            {
                return faButor ? $"FAB{String.Format("{0:00000}", 1)}" : $"FEM{String.Format("{0:00000}", 1)}";
            }
            else
            {
                return faButor ? $"FAB{String.Format("{0:00000}", (int.Parse(cikkSzamTmp.Substring(3))) + 1)}" : $"FEM{String.Format("{0:00000}", (int.Parse(cikkSzamTmp.Substring(3))) + 1)}";
            }
        }

        public void UjButor(AltalanosButor uj)
        {
            if (TaroltButorokSzama + 1 <= ButorokMaxSzama)
            {
                butorok.Add(uj);
            }
        }
        public void ButorModositas(int index, AltalanosButor modositando)
        {
            butorok.RemoveAt(index);
            butorok.Insert(index, modositando);
        }
        public void ButorTorles(int index)
        {
            butorok.RemoveAt(index);
        }
        public override string ToString()
        {
            return $"{RaktarSzam} - {RaktarNev} - {RaktarCime} - {ButorokMaxSzama} - Vasárnap {(vasarnap ? "nyitva" : "zárva")} - {String.Format(CultureInfo.CurrentCulture, "{0:C0}", TaroltButorokAra)}";
        }
        #endregion
    }
}
