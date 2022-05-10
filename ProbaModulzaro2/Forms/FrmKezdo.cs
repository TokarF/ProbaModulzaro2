using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ProbaModulzaro2
{
    public partial class FrmKezdo : Form
    {
        SajatLista lista = new SajatLista();
        public FrmKezdo()
        {
            InitializeComponent();
        }

        private void FrmKezdo_Load(object sender, EventArgs e)
        {
            try
            {
                ABKezelo.KapcsolatNyitas(ConfigurationManager.ConnectionStrings["ProbaModulzaro2.Properties.Settings.ProbaModulzaro2ABConnectionString"].ConnectionString);
                MessageBox.Show("Sikeres csatlakozás!", "Csatlakozás...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListBoxRefresh();
                lista.HozzaAdas += Lista_HozzaAdas;
                lista.Torles += Lista_Torles;
                LogKezeles.LogNyitas();
            }
            catch (ABKivetel ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.FormClosing -= FrmKezdo_FormClosing;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.FormClosing -= FrmKezdo_FormClosing;
                this.Close();
            }
        }

        private void FrmKezdo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Valóban ki szeretne lépni a programból?", "Kilépés...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    ABKezelo.KapcsolatZaras();
                    LogKezeles.LogZaras();
                }
                catch (ABKivetel ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            FrmJarmuKezeles frm = new FrmJarmuKezeles();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                lista.Add(frm.Jarmu);
                ListBoxRefresh();
                LogKezeles.LogIras(Funkcio.Létrehozás, frm.Jarmu);
            }
        }

        private void btnModositas_Click(object sender, EventArgs e)
        {
            if (lsbAdatok.SelectedIndex != -1)
            {
                FrmJarmuKezeles frm = new FrmJarmuKezeles((Jarmu)lsbAdatok.SelectedItem);
                frm.ShowDialog();
                ListBoxRefresh();
                LogKezeles.LogIras(Funkcio.Módosítás, (Jarmu)lsbAdatok.SelectedItem);
            }
        }

        private void btnMegjelenites_Click(object sender, EventArgs e)
        {
            if (lsbAdatok.SelectedIndex != -1)
            {
                FrmJarmuKezeles frm = new FrmJarmuKezeles((Jarmu)lsbAdatok.SelectedItem, true);
                frm.ShowDialog();
                ListBoxRefresh();
                LogKezeles.LogIras(Funkcio.Megjelenítés, (Jarmu)lsbAdatok.SelectedItem);
            }
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            if (lsbAdatok.SelectedIndex != -1 && MessageBox.Show("Valóban törli a kijelölt járművet?", "Törlés...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    ABKezelo.JarmuTorles((Jarmu)lsbAdatok.SelectedItem);
                    LogKezeles.LogIras(Funkcio.Törlés, (Jarmu)lsbAdatok.SelectedItem);
                    lista.Remove((Jarmu)lsbAdatok.SelectedItem);
                    ListBoxRefresh();
                }
                catch (ABKivetel ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRendezes_Click(object sender, EventArgs e)
        {
            FrmRendezes frm = new FrmRendezes(lista);
            frm.ShowDialog();
            LogKezeles.LogIras(Funkcio.Rendezés);
        }

        private void btnSzures_Click(object sender, EventArgs e)
        {
            FrmSzures frm = new FrmSzures(lista);
            frm.ShowDialog();
            LogKezeles.LogIras(Funkcio.Szűrés);
        }

        private void btnKereses_Click(object sender, EventArgs e)
        {
            if (txbKereses.Text.Trim().Length > 0)
            {
                List<Jarmu> eredmeny = lista.Where(x => x.GyartoNeve.ToLower() == txbKereses.Text.Trim().ToLower()).ToList();
                if (eredmeny.Count > 0)
                {
                    MessageBox.Show("Van találat!", "Eredmény...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nincs találat!", "Eredmény...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LogKezeles.LogIras(Funkcio.Keresés);
            }
            else
            {
                MessageBox.Show("Kérem, adjon meg keresési szempontot!", "Keresés...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = txbKereses;
            }
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lsbAdatok_DoubleClick(object sender, EventArgs e)
        {
            if (lsbAdatok.SelectedIndex != -1)
            {
                if (lsbAdatok.SelectedItem is KotottPalyas)
                {
                    FrmKotottPalyasAdatok frm = new FrmKotottPalyasAdatok((Jarmu)lsbAdatok.SelectedItem);
                    frm.ShowDialog();
                    ListBoxRefresh();
                    LogKezeles.LogIras(Funkcio.Kötöttpályás_adatok);
                }
                else
                {
                    MessageBox.Show("A kijelölt elem BUSZ típusú. Adatok megjelenítése nem lehetséges!", "Adatok megjelenítése...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ListBoxRefresh(bool indexMegorzes = false)
        {
            try
            {
                int index = -1;
                if (indexMegorzes)
                {
                    index = lsbAdatok.SelectedIndex;
                }
                lista.Clear();
                foreach (Jarmu item in ABKezelo.TeljesLekerdezes())
                {
                    lista.HozzaAdas -= Lista_HozzaAdas;
                    lista.Add(item);
                    lista.HozzaAdas += Lista_HozzaAdas;
                }
                lsbAdatok.DataSource = null;
                lsbAdatok.DataSource = lista;
            }
            catch (ABKivetel ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Lista_HozzaAdas(Jarmu uj)
        {
            this.Text = $"Új jármű hozzáadása történt: {uj}";
        }

        private void Lista_Torles(Jarmu torlendo)
        {
            this.Text = $"Jármű törlése történt: {torlendo}";
        }
    }
}
