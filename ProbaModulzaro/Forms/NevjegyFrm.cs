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
    public partial class NevjegyFrm : Form
    {
        int ido = 10;
        Random rnd = new Random();

        public NevjegyFrm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            int percek = ido / 60;
            int masodpercek = ido - percek / 60;
            lblNevjegy.Text = percek + " : " + masodpercek;
            if (ido > 0)
            {
                ido--;
                lblNevjegy.BackColor = randomColor;
            }
            else
            {
                Close();
            }
        }
    }
}
