using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaModulzaro2
{
    enum AramEllatasTipus
    {
        [Description("Áramellátás áramszedő által")]
        Á,
        [Description("Áramellátás sín által")]
        S
    }
    abstract class KotottPalyas : Jarmu
    {
        int sinSzelesseg;
        AramEllatasTipus aramEllatasTipusa;

        public int SinSzelesseg
        {
            get => sinSzelesseg;
            set
            {
                if (value > 99)
                {
                    sinSzelesseg = value;
                }
                else
                {
                    throw new ArgumentException("A SÍNSZÉLESSÉG minimum 100 cm kell, hogy legyen!");
                }
            }
        }
        internal AramEllatasTipus AramEllatasTipusa
        {
            get => aramEllatasTipusa;
            set
            {
                if (Enum.IsDefined(typeof(AramEllatasTipus), value)) { aramEllatasTipusa = value; }
                else { throw new ArgumentException("Az ÁRAMELLÁTÁS TÍPUS nem tartalmaz ilyen adatot!"); }
            }
        }

        protected KotottPalyas(int sinSzelesseg, AramEllatasTipus aramEllatasTipusa, string azonosito, string gyartoNeve, int futottKm, byte ajtokSzama, int ferohelyekSzama, int id = -1) : base(azonosito, gyartoNeve, futottKm, ajtokSzama, ferohelyekSzama, id)
        {
            SinSzelesseg = sinSzelesseg;
            AramEllatasTipusa = aramEllatasTipusa;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - [KÖTÖTTPÁLYÁS]";
        }

        public override string ToDetails()
        {
            return $"{base.ToDetails()}\n\rKÖTÖTTPÁLYÁS ADATOK\n\rSínszélesség: {sinSzelesseg}\n\rÁramellátás típusa: {aramEllatasTipusa}\n\r";
        }

        public override double AktualisAr()
        {
            throw new NotImplementedException();
        }
    }
}
