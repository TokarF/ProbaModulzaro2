using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaModulzaro2
{
    class Metro : KotottPalyas
    {
        byte szerelvenyekSzama;

        public byte SzerelvenyekSzama
        {
            get => szerelvenyekSzama;
            set
            {
                if (value > 0) { szerelvenyekSzama = value; }
                else { throw new ArgumentException("A SZERELVÉNYEK SZÁMA nem lehet 0!"); }
            }
        }

        public Metro(byte szerelvenyekSzama, int sinSzelesseg, AramEllatasTipus aramEllatasTipusa, string azonosito, string gyartoNeve, int futottKm, byte ajtokSzama, int ferohelyekSzama, int id = -1) : base(sinSzelesseg, aramEllatasTipusa, azonosito, gyartoNeve, futottKm, ajtokSzama, ferohelyekSzama, id)
        {
            SzerelvenyekSzama = szerelvenyekSzama;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - [METRÓ]";
        }

        public override string ToDetails()
        {
            return $"{base.ToDetails()}\n\rMETRÓ ADATOK\n\rSzerelvények száma: {szerelvenyekSzama}";
        }
    }
}
