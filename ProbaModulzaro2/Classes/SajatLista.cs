using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaModulzaro2
{
    class SajatLista: List<Jarmu>
    {
        public delegate void HozzaAdasEsemenyKezelo(Jarmu uj);
        public event HozzaAdasEsemenyKezelo HozzaAdas;

        public delegate void TorlesEsemenyKezelo(Jarmu torlendo);
        public event TorlesEsemenyKezelo Torles;

        public new void Add(Jarmu item)
        {
            base.Add(item);
            HozzaAdas?.Invoke(item);
        }
        public new void Remove(Jarmu item)
        {
            base.Remove(item);
            Torles?.Invoke(item);
        }
    }
}
