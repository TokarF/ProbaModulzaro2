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
    public partial class FrmKotottPalyasAdatok : Form
    {
        Jarmu jarmu;
        internal FrmKotottPalyasAdatok(Jarmu jarmu)
        {
            InitializeComponent();
            this.jarmu = jarmu;
        }

        private void FrmKotottPalyasAdatok_Paint(object sender, PaintEventArgs e)
        {
            string jeloles = String.Empty;
            string adatok = String.Empty;
            Pen szin = new Pen(this.BackColor);
            if (jarmu is Metro metro)
            {
                jeloles = "M";
                szin = new Pen(Color.Blue);
                adatok = metro.ToDetails();
            }
            else if(jarmu is Villamos villamos)
            {
                jeloles = "V";
                szin = new Pen(Color.Yellow);
                adatok = villamos.ToDetails();
            }
            e.Graphics.Clear(this.BackColor);
            e.Graphics.DrawString(jeloles, new Font(FontFamily.GenericSansSerif, 30, FontStyle.Bold), szin.Brush, 20, 10);
            e.Graphics.DrawString(adatok, new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular), Brushes.Black, 20, 75);
        }

        private void FrmKotottPalyasAdatok_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
