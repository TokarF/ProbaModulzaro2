using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaModulzaro
{
    enum HasznaltFaFajta
    {
        bükk, nyár, tölgy, fenyő, egyéb
    }
    class Fabutor : AltalanosButor
    {
        #region Private fileds
        HasznaltFaFajta faFajta;
        bool kezelt;
        #endregion

        #region Public properties
        internal HasznaltFaFajta FaFajta { get => faFajta; set => faFajta = value; }
        public bool Kezelt { get => kezelt; set => kezelt = value; }
        #endregion

        #region Constructors
        public Fabutor(HasznaltFaFajta faFajta, bool kezelt, string cikkSzam, string megnevezes, int gyartasiEv, bool hasznaltButor, ButorTipusa butorTipus, FelhasznalasiHelye felhasznalasiHely, uint butorAra) : base(cikkSzam, megnevezes, gyartasiEv, hasznaltButor, butorTipus, felhasznalasiHely, butorAra)
        {
            FaFajta = faFajta;
            Kezelt = kezelt;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{base.ToString()} ({FaFajta} - {(kezelt ? "Kezelt" : "Kezeletlen")})";
        }
        #endregion
    }
}
