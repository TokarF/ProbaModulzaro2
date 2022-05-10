
namespace ProbaModulzaro2
{
    partial class FrmKezdo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsbAdatok = new System.Windows.Forms.ListBox();
            this.grbKezeles = new System.Windows.Forms.GroupBox();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnMegjelenites = new System.Windows.Forms.Button();
            this.btnModositas = new System.Windows.Forms.Button();
            this.btnUj = new System.Windows.Forms.Button();
            this.grbEgyeb = new System.Windows.Forms.GroupBox();
            this.txbKereses = new System.Windows.Forms.TextBox();
            this.btnRendezes = new System.Windows.Forms.Button();
            this.btnSzures = new System.Windows.Forms.Button();
            this.btnKereses = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.grbKezeles.SuspendLayout();
            this.grbEgyeb.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbAdatok
            // 
            this.lsbAdatok.FormattingEnabled = true;
            this.lsbAdatok.ItemHeight = 20;
            this.lsbAdatok.Location = new System.Drawing.Point(12, 12);
            this.lsbAdatok.Name = "lsbAdatok";
            this.lsbAdatok.Size = new System.Drawing.Size(766, 704);
            this.lsbAdatok.TabIndex = 0;
            this.lsbAdatok.DoubleClick += new System.EventHandler(this.lsbAdatok_DoubleClick);
            // 
            // grbKezeles
            // 
            this.grbKezeles.Controls.Add(this.btnTorles);
            this.grbKezeles.Controls.Add(this.btnMegjelenites);
            this.grbKezeles.Controls.Add(this.btnModositas);
            this.grbKezeles.Controls.Add(this.btnUj);
            this.grbKezeles.Location = new System.Drawing.Point(784, 12);
            this.grbKezeles.Name = "grbKezeles";
            this.grbKezeles.Size = new System.Drawing.Size(212, 209);
            this.grbKezeles.TabIndex = 1;
            this.grbKezeles.TabStop = false;
            this.grbKezeles.Text = "Járművek kezelése";
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(6, 163);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(200, 40);
            this.btnTorles.TabIndex = 3;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // btnMegjelenites
            // 
            this.btnMegjelenites.Location = new System.Drawing.Point(6, 117);
            this.btnMegjelenites.Name = "btnMegjelenites";
            this.btnMegjelenites.Size = new System.Drawing.Size(200, 40);
            this.btnMegjelenites.TabIndex = 2;
            this.btnMegjelenites.Text = "Megjelenítés";
            this.btnMegjelenites.UseVisualStyleBackColor = true;
            this.btnMegjelenites.Click += new System.EventHandler(this.btnMegjelenites_Click);
            // 
            // btnModositas
            // 
            this.btnModositas.Location = new System.Drawing.Point(6, 71);
            this.btnModositas.Name = "btnModositas";
            this.btnModositas.Size = new System.Drawing.Size(200, 40);
            this.btnModositas.TabIndex = 1;
            this.btnModositas.Text = "Módosítás";
            this.btnModositas.UseVisualStyleBackColor = true;
            this.btnModositas.Click += new System.EventHandler(this.btnModositas_Click);
            // 
            // btnUj
            // 
            this.btnUj.Location = new System.Drawing.Point(6, 25);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(200, 40);
            this.btnUj.TabIndex = 0;
            this.btnUj.Text = "Új felvitel";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // grbEgyeb
            // 
            this.grbEgyeb.Controls.Add(this.txbKereses);
            this.grbEgyeb.Controls.Add(this.btnRendezes);
            this.grbEgyeb.Controls.Add(this.btnSzures);
            this.grbEgyeb.Controls.Add(this.btnKereses);
            this.grbEgyeb.Location = new System.Drawing.Point(784, 227);
            this.grbEgyeb.Name = "grbEgyeb";
            this.grbEgyeb.Size = new System.Drawing.Size(212, 195);
            this.grbEgyeb.TabIndex = 2;
            this.grbEgyeb.TabStop = false;
            this.grbEgyeb.Text = "Egyéb funckiók";
            // 
            // txbKereses
            // 
            this.txbKereses.Location = new System.Drawing.Point(6, 117);
            this.txbKereses.Name = "txbKereses";
            this.txbKereses.Size = new System.Drawing.Size(200, 26);
            this.txbKereses.TabIndex = 8;
            // 
            // btnRendezes
            // 
            this.btnRendezes.Location = new System.Drawing.Point(6, 25);
            this.btnRendezes.Name = "btnRendezes";
            this.btnRendezes.Size = new System.Drawing.Size(200, 40);
            this.btnRendezes.TabIndex = 4;
            this.btnRendezes.Text = "Rendezés";
            this.btnRendezes.UseVisualStyleBackColor = true;
            this.btnRendezes.Click += new System.EventHandler(this.btnRendezes_Click);
            // 
            // btnSzures
            // 
            this.btnSzures.Location = new System.Drawing.Point(6, 71);
            this.btnSzures.Name = "btnSzures";
            this.btnSzures.Size = new System.Drawing.Size(200, 40);
            this.btnSzures.TabIndex = 5;
            this.btnSzures.Text = "Szűrés";
            this.btnSzures.UseVisualStyleBackColor = true;
            this.btnSzures.Click += new System.EventHandler(this.btnSzures_Click);
            // 
            // btnKereses
            // 
            this.btnKereses.Location = new System.Drawing.Point(6, 149);
            this.btnKereses.Name = "btnKereses";
            this.btnKereses.Size = new System.Drawing.Size(200, 40);
            this.btnKereses.TabIndex = 6;
            this.btnKereses.Text = "Keresés";
            this.btnKereses.UseVisualStyleBackColor = true;
            this.btnKereses.Click += new System.EventHandler(this.btnKereses_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKilepes.Location = new System.Drawing.Point(796, 677);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(200, 40);
            this.btnKilepes.TabIndex = 7;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // FrmKezdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKilepes;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.grbEgyeb);
            this.Controls.Add(this.grbKezeles);
            this.Controls.Add(this.lsbAdatok);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKezdo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKezdo_FormClosing);
            this.Load += new System.EventHandler(this.FrmKezdo_Load);
            this.grbKezeles.ResumeLayout(false);
            this.grbEgyeb.ResumeLayout(false);
            this.grbEgyeb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbAdatok;
        private System.Windows.Forms.GroupBox grbKezeles;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnMegjelenites;
        private System.Windows.Forms.Button btnModositas;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.GroupBox grbEgyeb;
        private System.Windows.Forms.Button btnRendezes;
        private System.Windows.Forms.Button btnSzures;
        private System.Windows.Forms.Button btnKereses;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.TextBox txbKereses;
    }
}

