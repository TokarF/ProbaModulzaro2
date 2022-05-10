using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbaModulzaro
{
    public partial class ButorKezelesFrm : Form
    {
        ButorRaktar raktar;
        int index = -1;
        // Fabútor
        Label faFajta_lb;
        ComboBox faFajta_cb;
        CheckBox kezelt_ch;
        // Fémbútor
        Label femFajta_lb;
        ComboBox femFajta_cb;
        CheckBox hegesztett_ch;

        public ButorKezelesFrm()
        {
            InitializeComponent();
            GroupBoxKomponensek();
            cmbButorTipus.DataSource = Enum.GetValues(typeof(ButorTipusa));
            cmbFelhasznalasiHely.DataSource = Enum.GetValues(typeof(FelhasznalasiHelye));
            cmbValasztas.DataSource = Enum.GetValues(typeof(Valasztas));
            numGyartasiEv.Maximum = DateTime.Now.Year;
        }

        internal ButorKezelesFrm(ButorRaktar raktar) : this()
        {
            this.raktar = raktar;
            numGyartasiEv.Value = DateTime.Now.Year;
            this.ActiveControl = txbMegnevezes;
        }

        internal ButorKezelesFrm(ButorRaktar raktar, int index, bool megjelenites = false): this()
        {
            this.raktar = raktar;
            this.index = index;
            txbCikkSzam.Text = raktar.Butorok[index].CikkSzam;
            txbMegnevezes.Text = raktar.Butorok[index].Megnevezes;
            numGyartasiEv.Value = raktar.Butorok[index].GyartasiEv;
            cmbButorTipus.SelectedIndex = (int)raktar.Butorok[index].ButorTipus;
            cmbFelhasznalasiHely.SelectedIndex = (int)raktar.Butorok[index].FelhasznalasiHely;
            chbHasznaltButor.Checked = raktar.Butorok[index].HasznaltButor;
            numButorAra.Value = raktar.Butorok[index].ButorAra;
            if (raktar.Butorok[index] is Fabutor)
            {
                cmbValasztas.SelectedIndex = (int)Valasztas.fabútor;
                faFajta_cb.SelectedIndex = (int)(raktar.Butorok[index] as Fabutor).FaFajta;
                kezelt_ch.Checked = (raktar.Butorok[index] as Fabutor).Kezelt;
            }
            else
            {
                cmbValasztas.SelectedIndex = (int)Valasztas.fémbútor;
                femFajta_cb.SelectedIndex = (int)(raktar.Butorok[index] as Fembutor).FemFajta;
                hegesztett_ch.Checked = (raktar.Butorok[index] as Fembutor).Hegesztett;
            }
            cmbValasztas.Enabled = false;
            this.ActiveControl = txbMegnevezes;
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
                        foreach (Control grbItem in grbAdatok.Controls)
                        {
                            if (!(grbItem is Label))
                            {
                                grbItem.Enabled = false;
                            }
                        }
                    }
                }
            }
        }

        private void GroupBoxKomponensek()
        {
            // Fabútor
            faFajta_lb = new Label()
            {
                Parent = grbAdatok,
                Top = 25,
                Left = 6,
                Width = lblValasztas.Width - grbAdatok.Padding.Left - grbAdatok.Margin.Left,
                Height = lblValasztas.Height,
                TextAlign = ContentAlignment.MiddleLeft,
                Text = "Fafajta"
            };
            faFajta_cb = new ComboBox()
            {
                Parent = grbAdatok,
                Top = faFajta_lb.Top,
                Left = faFajta_lb.Right + 6,
                Width = cmbValasztas.Width,
                Height = cmbValasztas.Height,
                DataSource = Enum.GetValues(typeof(HasznaltFaFajta)),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            kezelt_ch = new CheckBox()
            {
                Parent = grbAdatok,
                Top = faFajta_cb.Bottom + 6,
                Left = faFajta_cb.Left,
                Width = chbHasznaltButor.Width,
                Height = chbHasznaltButor.Height,
                Text = "Kezelt vagy kezeletlen (X = kezelt)"
            };

            // Fémbútor
            femFajta_lb = new Label()
            {
                Parent = grbAdatok,
                Top = 25,
                Left = 6,
                Width = lblValasztas.Width - grbAdatok.Padding.Left - grbAdatok.Margin.Left,
                Height = lblValasztas.Height,
                TextAlign = ContentAlignment.MiddleLeft,
                Text = "Fémfajta"
            };
            femFajta_cb = new ComboBox()
            {
                Parent = grbAdatok,
                Top = femFajta_lb.Top,
                Left = femFajta_lb.Right + 6,
                Width = cmbValasztas.Width,
                Height = cmbValasztas.Height,
                DataSource = Enum.GetValues(typeof(HasznaltFemFajta)),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            hegesztett_ch = new CheckBox()
            {
                Parent = grbAdatok,
                Top = femFajta_cb.Bottom + 6,
                Left = femFajta_cb.Left,
                Width = chbHasznaltButor.Width,
                Height = chbHasznaltButor.Height,
                Text = "Hegesztett vagy csavarozott (X = hegesztett)"
            };
        }

        private void cmbValasztas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((Valasztas)cmbValasztas.SelectedIndex)
            {
                case Valasztas.választás:
                    grbAdatok.Visible = false;
                    btnOK.Enabled = false;
                    break;
                case Valasztas.fabútor:
                    grbAdatok.Visible = true;
                    faFajta_lb.Visible = true;
                    faFajta_cb.Visible = true;
                    kezelt_ch.Visible = true;
                    femFajta_lb.Visible = false;
                    femFajta_cb.Visible = false;
                    hegesztett_ch.Visible = false;
                    btnOK.Enabled = true;
                    // Cikkszám meghatározása
                    break;
                case Valasztas.fémbútor:
                    grbAdatok.Visible = true;
                    faFajta_lb.Visible = false;
                    faFajta_cb.Visible = false;
                    kezelt_ch.Visible = false;
                    femFajta_lb.Visible = true;
                    femFajta_cb.Visible = true;
                    hegesztett_ch.Visible = true;
                    btnOK.Enabled = true;
                    // Cikkszám meghatározása
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            switch ((Valasztas)cmbValasztas.SelectedIndex)
            {
                case Valasztas.fabútor:
                    try
                    {
                        AltalanosButor butor = new Fabutor((HasznaltFaFajta)faFajta_cb.SelectedIndex, kezelt_ch.Checked, txbCikkSzam.Text.Trim(), txbMegnevezes.Text.Trim(), (int)numGyartasiEv.Value, chbHasznaltButor.Checked, (ButorTipusa)cmbButorTipus.SelectedIndex, (FelhasznalasiHelye)cmbFelhasznalasiHely.SelectedIndex, (uint)numButorAra.Value);
                        if (index == -1)
                        {
                            raktar.UjButor(butor);
                        }
                        else
                        {
                            raktar.ButorModositas(index, butor);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        DialogResult = DialogResult.None;
                    }
                    break;
                case Valasztas.fémbútor:
                    try
                    {
                        AltalanosButor butor = new Fembutor((HasznaltFemFajta)femFajta_cb.SelectedIndex, hegesztett_ch.Checked, txbCikkSzam.Text.Trim(), txbMegnevezes.Text.Trim(), (int)numGyartasiEv.Value, chbHasznaltButor.Checked, (ButorTipusa)cmbButorTipus.SelectedIndex, (FelhasznalasiHelye)cmbFelhasznalasiHely.SelectedIndex, (uint)numButorAra.Value);
                        if (index == -1)
                        {
                            raktar.UjButor(butor);
                        }
                        else
                        {
                            raktar.ButorModositas(index, butor);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        DialogResult = DialogResult.None;
                    }
                    break;
            }
        }
    }
}
