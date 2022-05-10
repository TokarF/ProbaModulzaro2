using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaModulzaro
{
    enum HasznaltFemFajta
    {
        alumínium, acél, egyéb
    }
    class Fembutor: AltalanosButor
    {
        #region Private fileds
        HasznaltFemFajta femFajta;
        bool hegesztett;
        #endregion

        #region Public properties
        internal HasznaltFemFajta FemFajta { get => femFajta; set => femFajta = value; }
        public bool Hegesztett { get => hegesztett; set => hegesztett = value; }
        #endregion

        #region Constructors
        public Fembutor(HasznaltFemFajta femFajta, bool hegesztett, string cikkSzam, string megnevezes, int gyartasiEv, bool hasznaltButor, ButorTipusa butorTipus, FelhasznalasiHelye felhasznalasiHely, uint butorAra) : base(cikkSzam, megnevezes, gyartasiEv, hasznaltButor, butorTipus, felhasznalasiHely, butorAra)
        {
            FemFajta = femFajta;
            Hegesztett = hegesztett;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{base.ToString()} ({FemFajta} - {(Hegesztett ? "Hegesztett" : "Csavarozott")})";
        }
        #endregion
    }
}
