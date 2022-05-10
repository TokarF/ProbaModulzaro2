using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbaModulzaro
{
    enum Valasztas
    {
        választás, fabútor, fémbútor
    }
    enum ButorTipusa
    {
        asztal, szék, szekrény, ágy, egyéb
    }
    enum FelhasznalasiHelye
    {
        nappali, hálószoba, konyha, fürdőszoba, előszoba, egyéb
    }

    abstract class AltalanosButor
    {
        #region Private fileds
        string cikkSzam;
        string megnevezes;
        int gyartasiEv;
        ButorTipusa butorTipus;
        FelhasznalasiHelye felhasznalasiHely;
        bool hasznaltButor;
        uint butorAra;
        #endregion

        #region Public properties
        public string CikkSzam { get => cikkSzam; private set => cikkSzam = value; }
        public string Megnevezes
        {
            get => megnevezes;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    megnevezes = value;
                }
                else
                {
                    throw new Exception("A BÚTOR MEGNEVEZÉSE mezőt kötelező kitölteni, nem lehet üres!");
                }
            }
        }
        public int GyartasiEv
        {
            get => gyartasiEv;
            set
            {
                if (value >= DateTime.MinValue.Year && value <= DateTime.Now.Year)
                {
                    gyartasiEv = value;
                }
                else
                {
                    throw new Exception("A GYÁRTÁSI ÉV mező nem lehet üres, és nem lehet jövőbeni dátum!");
                }
            }
        }
        public bool HasznaltButor { get => hasznaltButor; set => hasznaltButor = value; }
        internal ButorTipusa ButorTipus { get => butorTipus; set => butorTipus = value; }
        internal FelhasznalasiHelye FelhasznalasiHely { get => felhasznalasiHely; set => felhasznalasiHely = value; }
        public uint ButorAra
        {
            get => butorAra;
            set
            {
                if (value > 0)
                {
                    butorAra = value;
                }
                else
                {
                    throw new Exception("A BÚTOR ÁRA mező értéke nem lehet 0!");
                }
            }
        }
        #endregion

        #region Constructors
        protected AltalanosButor(string cikkSzam, string megnevezes, int gyartasiEv, bool hasznaltButor, ButorTipusa butorTipus, FelhasznalasiHelye felhasznalasiHely, uint butorAra)
        {
            CikkSzam = cikkSzam;
            Megnevezes = megnevezes;
            GyartasiEv = gyartasiEv;
            HasznaltButor = hasznaltButor;
            ButorTipus = butorTipus;
            FelhasznalasiHely = felhasznalasiHely;
            ButorAra = butorAra;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{CikkSzam} - {Megnevezes} - {GyartasiEv} - {ButorTipus} - {FelhasznalasiHely} - {(HasznaltButor? "Használt": "Új")} bútor - {String.Format(CultureInfo.CurrentCulture, "{0:C0}", ButorAra)}";
        }
        #endregion
    }
}
