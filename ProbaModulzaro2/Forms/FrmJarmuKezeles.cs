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
    public partial class FrmJarmuKezeles : Form
    {
        Jarmu jarmu;

        internal Jarmu Jarmu { get => jarmu; /*set => jarmu = value;*/ }

        public FrmJarmuKezeles()
        {
            InitializeComponent();
            cmbValasztas.DataSource = Enum.GetValues(typeof(Valasztas));
            //cmbAramEllatasTipusa.DataSource = Enum.GetValues(typeof(AramEllatasTipus));
            cmbAramEllatasTipusa.DataSource = Enum.GetValues(typeof(AramEllatasTipus)).Cast<Enum>().Select(value => new { (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description, value }).OrderBy(item => item.value).ToList();
            cmbAramEllatasTipusa.DisplayMember = "Description";
            cmbAramEllatasTipusa.ValueMember = "value";

        }

        internal FrmJarmuKezeles(Jarmu jarmu, bool megjelenites = false) : this()
        {
            this.jarmu = jarmu;
            txbId.Text = jarmu.Id.ToString();
            txbAzonosito.Text = jarmu.Azonosito;
            txbGyartoNeve.Text = jarmu.GyartoNeve;
            numFutottKm.Value = jarmu.FutottKm;
            numFutottKm.Minimum = jarmu.FutottKm;
            numAjtokSzama.Value = jarmu.AjtokSzama;
            numFerohelyekSzama.Value = jarmu.FerohelyekSzama;
            if (jarmu is Busz busz)
            {
                cmbValasztas.SelectedIndex = (int)Valasztas.Busz;
                grbKotottPalyas.Enabled = false;
                chbHibrid.Checked = busz.Hibrid;
                chbCsuklos.Checked = busz.Csuklos;
                numBenzintartaly.Value = busz.Benzintartaly;
            }
            else if (jarmu is KotottPalyas kotottPalyas)
            {
                numSinSzelesseg.Value = kotottPalyas.SinSzelesseg;
                cmbAramEllatasTipusa.SelectedIndex = (int)kotottPalyas.AramEllatasTipusa;
                if (jarmu is Metro metro)
                {
                    cmbValasztas.SelectedIndex = (int)Valasztas.Metró;
                    grbBusz.Enabled = false;
                    grbVillamos.Enabled = false;
                    numSzerelvenyekSzama.Value = metro.SzerelvenyekSzama;
                }
                else if (jarmu is Villamos villamnos)
                {
                    cmbValasztas.SelectedIndex = (int)Valasztas.Villamos;
                    grbBusz.Enabled = false;
                    grbMetro.Enabled = false;
                    chbEgybenyitott.Checked = villamnos.EgybenyitottTeru;
                }
            }
            cmbValasztas.Enabled = false;
            if (megjelenites)
            {
                foreach (Control item in this.Controls)
                {
                    item.Enabled = false;
                }
                btnMegsem.Enabled = true;
                this.ActiveControl = btnMegsem;
            }
        }

        private void cmbValasztas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((Valasztas)cmbValasztas.SelectedIndex)
            {
                case Valasztas.Busz:
                    grbBusz.Enabled = true;
                    grbKotottPalyas.Enabled = false;
                    break;
                case Valasztas.Metró:
                    grbBusz.Enabled = false;
                    grbKotottPalyas.Enabled = true;
                    grbMetro.Enabled = true;
                    grbVillamos.Enabled = false;
                    break;
                case Valasztas.Villamos:
                    grbBusz.Enabled = false;
                    grbKotottPalyas.Enabled = true;
                    grbMetro.Enabled = false;
                    grbVillamos.Enabled = true;
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (jarmu == null)
                {
                    switch ((Valasztas)cmbValasztas.SelectedIndex)
                    {
                        case Valasztas.Busz:
                            jarmu = new Busz(chbHibrid.Checked, chbCsuklos.Checked, (int)numBenzintartaly.Value, txbAzonosito.Text.Trim(), txbGyartoNeve.Text.Trim(), (int)numFutottKm.Value, (byte)numAjtokSzama.Value, (int)numFerohelyekSzama.Value);
                            break;
                        case Valasztas.Metró:
                            jarmu = new Metro((byte)numSzerelvenyekSzama.Value, (int)numSinSzelesseg.Value, (AramEllatasTipus)cmbAramEllatasTipusa.SelectedIndex, txbAzonosito.Text.Trim(), txbGyartoNeve.Text.Trim(), (int)numFutottKm.Value, (byte)numAjtokSzama.Value, (int)numFerohelyekSzama.Value);
                            break;
                        case Valasztas.Villamos:
                            jarmu = new Villamos(chbEgybenyitott.Checked, (int)numSinSzelesseg.Value, (AramEllatasTipus)cmbAramEllatasTipusa.SelectedIndex, txbAzonosito.Text.Trim(), txbGyartoNeve.Text.Trim(), (int)numFutottKm.Value, (byte)numAjtokSzama.Value, (int)numFerohelyekSzama.Value);
                            break;
                    }
                    ABKezelo.JarmuLetrehozas(Jarmu);
                }
                else
                {
                    jarmu.Azonosito = txbAzonosito.Text.Trim();
                    jarmu.GyartoNeve = txbGyartoNeve.Text.Trim();
                    jarmu.FutottKm = (int)numFutottKm.Value;
                    jarmu.AjtokSzama = (byte)numAjtokSzama.Value;
                    jarmu.FerohelyekSzama = (int)numFerohelyekSzama.Value;
                    switch ((Valasztas)cmbValasztas.SelectedIndex)
                    {
                        case Valasztas.Busz:
                            (jarmu as Busz).Hibrid = chbHibrid.Checked;
                            (jarmu as Busz).Csuklos = chbCsuklos.Checked;
                            (jarmu as Busz).Benzintartaly = (int)numBenzintartaly.Value;
                            break;
                        case Valasztas.Metró:
                            (jarmu as KotottPalyas).SinSzelesseg = (int)numSinSzelesseg.Value;
                            (jarmu as KotottPalyas).AramEllatasTipusa = (AramEllatasTipus)cmbAramEllatasTipusa.SelectedIndex;
                            (jarmu as Metro).SzerelvenyekSzama = (byte)numSzerelvenyekSzama.Value;
                            break;
                        case Valasztas.Villamos:
                            (jarmu as KotottPalyas).SinSzelesseg = (int)numSinSzelesseg.Value;
                            (jarmu as KotottPalyas).AramEllatasTipusa = (AramEllatasTipus)cmbAramEllatasTipusa.SelectedIndex;
                            (jarmu as Villamos).EgybenyitottTeru = chbEgybenyitott.Checked;
                            break;
                    }
                    ABKezelo.JarmuModositas(Jarmu);
                }
            }
            catch (ABKivetel ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }
    }
}
