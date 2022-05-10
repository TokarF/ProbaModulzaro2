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
    public partial class FrmSzures : Form
    {
        SajatLista lista;
        EldontoFuggvenyTarolo fv;
        internal FrmSzures(SajatLista lista)
        {
            InitializeComponent();
            this.lista = lista;
            rdb1_CheckedChanged(null, null);
        }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb1.Checked) { fv = FutottKmSzures; }
            else { fv = SzallithatoUtasokSzures; }
        }

        private bool FutottKmSzures(Jarmu jarmu)
        {
            return numSzures.Value >= jarmu.FutottKm;
        }

        private bool SzallithatoUtasokSzures(Jarmu jarmu)
        {
            return numSzures.Value <= jarmu.FerohelyekSzama;
        }

        private void btnSzures_Click(object sender, EventArgs e)
        {
            lsbAdatok.DataSource = null;
            lsbAdatok.DataSource = Jarmu.Szures(lista, fv);
        }
    }
}
