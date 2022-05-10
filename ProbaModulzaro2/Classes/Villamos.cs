using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaModulzaro2
{
    class Villamos : KotottPalyas
    {
        bool egybenyitottTeru;

        public bool EgybenyitottTeru { get => egybenyitottTeru; set => egybenyitottTeru = value; }

        public Villamos(bool egybenyitottTeru, int sinSzelesseg, AramEllatasTipus aramEllatasTipusa, string azonosito, string gyartoNeve, int futottKm, byte ajtokSzama, int ferohelyekSzama, int id = -1) : base(sinSzelesseg, aramEllatasTipusa, azonosito, gyartoNeve, futottKm, ajtokSzama, ferohelyekSzama, id)
        {
            EgybenyitottTeru = egybenyitottTeru;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - [VILLAMOS]";
        }

        public override string ToDetails()
        {
            return $"{base.ToDetails()}\n\rVILLAMOS ADATOK\n\rEgybenyitott terű? {(egybenyitottTeru ? "IGEN" : "NEM")}";
        }
    }
}
