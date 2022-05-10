using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbaModulzaro2
{
    public partial class FrmRendezes : Form
    {
        internal FrmRendezes(SajatLista lista)
        {
            InitializeComponent();
            List<Jarmu> rendezettLista = lista.OrderBy(x => x.GyartoNeve).ThenBy(y => y.Azonosito).ToList();
            lsbAdatok.DataSource = rendezettLista;
        }
    }
}
