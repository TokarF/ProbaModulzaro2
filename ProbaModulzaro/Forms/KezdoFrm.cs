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
    public partial class KezdoFrm : Form
    {
        #region Private fields
        List<ButorRaktar> raktarLista;
        #endregion

        #region Constructors
        public KezdoFrm()
        {
            InitializeComponent();
            raktarLista = new List<ButorRaktar>();
            // ***** TESZTELÉS MIATTI FELTÖLTÉS
            ButorRaktar tmp = new ButorRaktar("00010", "Raktárnév", new RaktarCim(1205, "Budapest", "Szigligeti utca", " 15."), 10, true);
            tmp.UjButor(new Fabutor(HasznaltFaFajta.bükk, true, "100", "Bútor neve", 2018, false, ButorTipusa.asztal, FelhasznalasiHelye.egyéb, 15000));
            raktarLista.Add(tmp);
            lsbButorRaktarak.Items.Add(tmp);
            lsbFabutorok.Items.Add(tmp.Butorok.First());
            // ***** TESZTELÉS MIATTI FELTÖLTÉS
        }
        #endregion

        #region Form events
        private void KezdoFrm_Load(object sender, EventArgs e)
        {
            if (lsbButorRaktarak.Items.Count > 0)
            {
                lsbButorRaktarak.SelectedIndex = 0;
            }
            GombokEngedelyezese();
        }
        #endregion

        #region Component events
        private void btnRaktarUj_Click(object sender, EventArgs e)
        {
            //string raktarSzam = ButorRaktar.RaktarSzamMeghatarozas(raktarLista);
            RaktarKezelesFrm frm = new RaktarKezelesFrm(ButorRaktar.RaktarSzamMeghatarozas(raktarLista));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                raktarLista.Add(frm.Raktar);
                lsbButorRaktarak.Items.Add(frm.Raktar);
                lsbButorRaktarak.SelectedIndex = lsbButorRaktarak.Items.Count - 1;
            }
        }

        private void btnRaktarModosit_Click(object sender, EventArgs e)
        {
            if (lsbButorRaktarak.SelectedIndex != -1)
            {
                RaktarKezelesFrm frm = new RaktarKezelesFrm((ButorRaktar)lsbButorRaktarak.SelectedItem);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    int index = lsbButorRaktarak.SelectedIndex;
                    lsbButorRaktarak.Items.RemoveAt(index);
                    lsbButorRaktarak.Items.Insert(index, frm.Raktar);
                    lsbButorRaktarak.SelectedIndex = index;
                }
            }
        }

        private void btnRaktarMegjelenit_Click(object sender, EventArgs e)
        {
            if (lsbButorRaktarak.SelectedIndex != -1)
            {
                RaktarKezelesFrm frm = new RaktarKezelesFrm((ButorRaktar)lsbButorRaktarak.SelectedItem, true);
                frm.ShowDialog();
            }
        }

        private void btnRaktarTorol_Click(object sender, EventArgs e)
        {
            if (lsbButorRaktarak.SelectedIndex != -1 && MessageBox.Show("Valóban törli a kijelölt raktárat?", "Raktár törlése", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                lsbButorRaktarak.Items.RemoveAt(lsbButorRaktarak.SelectedIndex);
                if (lsbButorRaktarak.Items.Count != 0)
                {
                    lsbButorRaktarak.SelectedIndex = 0;
                }
                GombokEngedelyezese();
            }
        }

        private void btnButorUj_Click(object sender, EventArgs e)
        {
            if (lsbButorRaktarak.SelectedIndex != -1 )
            {
                if ((lsbButorRaktarak.SelectedItem as ButorRaktar).ButorokMaxSzama - (lsbButorRaktarak.SelectedItem as ButorRaktar).TaroltButorokSzama > 0)
                {
                    ButorKezelesFrm frm = new ButorKezelesFrm((ButorRaktar)lsbButorRaktarak.SelectedItem);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ButorListaFrissites();
                    }
                }
                else
                {
                    MessageBox.Show("A kijelölt bútorraktárhoz nem lehet új bútort hozzáadni!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Kérem, jelöljön ki egy raktárat!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnButorModosit_Click(object sender, EventArgs e)
        {

        }

        private void btnButorMegjelenit_Click(object sender, EventArgs e)
        {

        }

        private void btnButorTorol_Click(object sender, EventArgs e)
        {

        }

        private void lsbButorRaktarak_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButorListaFrissites();
            GombokEngedelyezese();
        }

        private void lsbFabutorok_SelectedIndexChanged(object sender, EventArgs e)
        {
            GombokEngedelyezese();
        }

        private void lsbFembutorok_SelectedIndexChanged(object sender, EventArgs e)
        {
            GombokEngedelyezese();
        }

        private void lsbFabutorok_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is ListBox lb)
            {
                foreach (Control item in this.Controls)
                {
                    if (item is ListBox && item != lb && item != lsbButorRaktarak)
                    {
                        (item as ListBox).SelectedIndex = -1;
                    }
                }
            }
        }
        #endregion

        #region Methods
        private void GombokEngedelyezese()
        {
            // Semmi nincs
            if (lsbButorRaktarak.SelectedIndex == -1)
            {
                foreach (Control item in grbButorRaktar.Controls)
                {
                    item.Enabled = (item.Name == "btnRaktarUj") ? true : false;
                }
                foreach (Control item in grbButor.Controls)
                {
                    item.Enabled = false;
                }
            }
            // Már van Bútorraktár és lehet, hogy van Bútor
            else
            {
                foreach (Control item in grbButorRaktar.Controls)
                {
                    item.Enabled = true;
                }
                if (lsbFabutorok.SelectedIndex == -1 && lsbFembutorok.SelectedIndex == -1)
                {
                    foreach (Control item in grbButor.Controls)
                    {
                        item.Enabled = (item.Name == "btnButorUj") ? true : false;
                    }
                }
                else
                {
                    foreach (Control item in grbButor.Controls)
                    {
                        item.Enabled = true;
                    }
                }
            }
        }

        private void ButorListaFrissites()
        {
            // Mindkét bútorlista listboxot kiürítjük.
            lsbFabutorok.DataSource = lsbFembutorok.DataSource = null;
            // A kijelölt bútorraktár listájával felöltjük
            List<Fabutor> faButorok = new List<Fabutor>();
            List<Fembutor> femButorok = new List<Fembutor>();
            if (lsbButorRaktarak.SelectedIndex != -1 && (lsbButorRaktarak.SelectedItem as ButorRaktar).Butorok.Count > 0)
            {
                foreach (AltalanosButor item in (lsbButorRaktarak.SelectedItem as ButorRaktar).Butorok)
                {
                    if (item is Fabutor)
                    {
                        faButorok.Add(item as Fabutor);
                    }
                    else
                    {
                        femButorok.Add(item as Fembutor);
                    }
                }
                lsbFabutorok.DataSource = faButorok;
                lsbFembutorok.DataSource = femButorok;
                // Mindkét listboxról elvesszük a fókuszt.
                lsbFabutorok.SelectedIndex = lsbFembutorok.SelectedIndex = -1;
            }
        }
        #endregion
    }
}
