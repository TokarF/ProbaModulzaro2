using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaModulzaro2
{
    class Busz : Jarmu
    {
        bool hibrid;
        bool csuklos;
        int benzintartaly;

        public bool Hibrid { get => hibrid; set => hibrid = value; }
        public bool Csuklos { get => csuklos; set => csuklos = value; }
        public int Benzintartaly
        {
            get => benzintartaly;
            set
            {
                if (value > 49) { benzintartaly = value; }
                else { throw new ArgumentException("A BENZINTARTÁLY minimum 50 liter kell, hogy legyen!"); }
            }
        }

        public Busz(bool hibrid, bool csuklos, int benzintartaly, string azonosito, string gyartoNeve, int futottKm, byte ajtokSzama, int ferohelyekSzama, int id = -1) : base(azonosito, gyartoNeve, futottKm, ajtokSzama, ferohelyekSzama, id)
        {
            Hibrid = hibrid;
            Csuklos = csuklos;
            Benzintartaly = benzintartaly;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - [BUSZ]";
        }

        public override double AktualisAr()
        {
            throw new NotImplementedException();
        }
    }
}
