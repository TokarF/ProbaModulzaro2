using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbaModulzaro
{
    public partial class RaktarKezelesFrm : Form
    {
        ButorRaktar raktar;
        internal ButorRaktar Raktar { get => raktar; /*set => raktar = value;*/ }
        public RaktarKezelesFrm()
        {
            InitializeComponent();
            this.ActiveControl = txbRaktarNev;
        }

        public RaktarKezelesFrm(string raktarSzam) : this()
        {
            txbRaktarSzam.Text = raktarSzam;
        }

        internal RaktarKezelesFrm(ButorRaktar raktar, bool megjelenites = false) : this()
        {
            this.raktar = raktar;
            txbRaktarSzam.Text = raktar.RaktarSzam;
            txbRaktarNev.Text = raktar.RaktarNev;
            numIranyitoSzam.Value = raktar.RaktarCime.IranyitoSzam;
            txbHelyseg.Text = raktar.RaktarCime.Helyseg;
            txbUtca.Text = raktar.RaktarCime.Utca;
            txbHazSzam.Text = raktar.RaktarCime.HazSzam;
            numButorokMaxSzama.Value = raktar.ButorokMaxSzama;
            chbVasarnap.Checked = raktar.Vasarnap;
            if (megjelenites)
            {
                foreach (Control item in this.Controls)
                {
                    if (!(item is Label) && !(item is GroupBox))
                    {
                        item.Enabled = false;
                    }
                    else if (item is GroupBox)
                    {
                        foreach (Control grbItem in grbRaktarCim.Controls)
                        {
                            if (!(grbItem is Label))
                            {
                                grbItem.Enabled = false;
                            }
                        }
                    }
                }
                btnMegsem.Enabled = true;
                this.ActiveControl = btnMegsem;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Új felvitel
            if (raktar is null)
            {
                try
                {
                    //RaktarCim tmpCim = new RaktarCim((ushort)numIranyitoSzam.Value, txbHelyseg.Text.Trim(), txbUtca.Text.Trim(), txbHazSzam.Text.Trim());
                    //raktar = new ButorRaktar(txbRaktarSzam.Text.Trim(), txbRaktarNev.Text.Trim(), tmpCim, (byte)numButorokMaxSzama.Value, chbVasarnap.Checked);
                    raktar = new ButorRaktar(txbRaktarSzam.Text.Trim(), txbRaktarNev.Text.Trim(), new RaktarCim((ushort)numIranyitoSzam.Value, txbHelyseg.Text.Trim(), txbUtca.Text.Trim(), txbHazSzam.Text.Trim()), (byte)numButorokMaxSzama.Value, chbVasarnap.Checked);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                }
            }
            // Módosítás
            else
            {
                try
                {
                    raktar.RaktarNev = txbRaktarNev.Text.Trim();
                    raktar.RaktarCime.IranyitoSzam = (ushort)numIranyitoSzam.Value;
                    raktar.RaktarCime.Helyseg = txbHelyseg.Text.Trim();
                    raktar.RaktarCime.Utca = txbUtca.Text.Trim();
                    raktar.RaktarCime.HazSzam = txbHazSzam.Text.Trim();
                    raktar.ButorokMaxSzama = (byte)numButorokMaxSzama.Value;
                    raktar.Vasarnap = chbVasarnap.Checked;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                }
            }
        }
    }
}
