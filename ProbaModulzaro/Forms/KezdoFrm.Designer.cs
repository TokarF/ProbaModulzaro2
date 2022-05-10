namespace ProbaModulzaro
{
    partial class KezdoFrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblButorRaktarak = new System.Windows.Forms.Label();
            this.lsbButorRaktarak = new System.Windows.Forms.ListBox();
            this.lblFabutorok = new System.Windows.Forms.Label();
            this.lsbFabutorok = new System.Windows.Forms.ListBox();
            this.lblFembutorok = new System.Windows.Forms.Label();
            this.lsbFembutorok = new System.Windows.Forms.ListBox();
            this.lblRaktarKereses = new System.Windows.Forms.Label();
            this.txbRaktarKereses = new System.Windows.Forms.TextBox();
            this.grbButorRaktar = new System.Windows.Forms.GroupBox();
            this.btnRaktarTorol = new System.Windows.Forms.Button();
            this.btnRaktarMegjelenit = new System.Windows.Forms.Button();
            this.btnRaktarModosit = new System.Windows.Forms.Button();
            this.btnRaktarUj = new System.Windows.Forms.Button();
            this.grbButor = new System.Windows.Forms.GroupBox();
            this.btnButorTorol = new System.Windows.Forms.Button();
            this.btnButorMegjelenit = new System.Windows.Forms.Button();
            this.btnButorModosit = new System.Windows.Forms.Button();
            this.btnButorUj = new System.Windows.Forms.Button();
            this.btnRaktarakMegjelenit = new System.Windows.Forms.Button();
            this.btnButorokMegjelenit = new System.Windows.Forms.Button();
            this.btnRendezesek = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grbButorRaktar.SuspendLayout();
            this.grbButor.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.névjegyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // névjegyToolStripMenuItem
            // 
            this.névjegyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.névjegyToolStripMenuItem1});
            this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.névjegyToolStripMenuItem.Text = "Névjegy";
            // 
            // névjegyToolStripMenuItem1
            // 
            this.névjegyToolStripMenuItem1.Name = "névjegyToolStripMenuItem1";
            this.névjegyToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.névjegyToolStripMenuItem1.Text = "Névjegy";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblButorRaktarak
            // 
            this.lblButorRaktarak.Location = new System.Drawing.Point(12, 28);
            this.lblButorRaktarak.Name = "lblButorRaktarak";
            this.lblButorRaktarak.Size = new System.Drawing.Size(150, 25);
            this.lblButorRaktarak.TabIndex = 1;
            this.lblButorRaktarak.Text = "Bútorraktárak";
            this.lblButorRaktarak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lsbButorRaktarak
            // 
            this.lsbButorRaktarak.FormattingEnabled = true;
            this.lsbButorRaktarak.ItemHeight = 20;
            this.lsbButorRaktarak.Location = new System.Drawing.Point(12, 56);
            this.lsbButorRaktarak.Name = "lsbButorRaktarak";
            this.lsbButorRaktarak.Size = new System.Drawing.Size(816, 164);
            this.lsbButorRaktarak.TabIndex = 2;
            this.lsbButorRaktarak.SelectedIndexChanged += new System.EventHandler(this.lsbButorRaktarak_SelectedIndexChanged);
            // 
            // lblFabutorok
            // 
            this.lblFabutorok.Location = new System.Drawing.Point(12, 223);
            this.lblFabutorok.Name = "lblFabutorok";
            this.lblFabutorok.Size = new System.Drawing.Size(150, 25);
            this.lblFabutorok.TabIndex = 3;
            this.lblFabutorok.Text = "Fabútorok";
            this.lblFabutorok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lsbFabutorok
            // 
            this.lsbFabutorok.FormattingEnabled = true;
            this.lsbFabutorok.ItemHeight = 20;
            this.lsbFabutorok.Location = new System.Drawing.Point(12, 251);
            this.lsbFabutorok.Name = "lsbFabutorok";
            this.lsbFabutorok.Size = new System.Drawing.Size(816, 164);
            this.lsbFabutorok.TabIndex = 4;
            this.lsbFabutorok.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsbFabutorok_MouseClick);
            this.lsbFabutorok.SelectedIndexChanged += new System.EventHandler(this.lsbFabutorok_SelectedIndexChanged);
            // 
            // lblFembutorok
            // 
            this.lblFembutorok.Location = new System.Drawing.Point(12, 418);
            this.lblFembutorok.Name = "lblFembutorok";
            this.lblFembutorok.Size = new System.Drawing.Size(150, 25);
            this.lblFembutorok.TabIndex = 5;
            this.lblFembutorok.Text = "Fémbútorok";
            this.lblFembutorok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lsbFembutorok
            // 
            this.lsbFembutorok.FormattingEnabled = true;
            this.lsbFembutorok.ItemHeight = 20;
            this.lsbFembutorok.Location = new System.Drawing.Point(12, 446);
            this.lsbFembutorok.Name = "lsbFembutorok";
            this.lsbFembutorok.Size = new System.Drawing.Size(816, 164);
            this.lsbFembutorok.TabIndex = 6;
            this.lsbFembutorok.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsbFabutorok_MouseClick);
            this.lsbFembutorok.SelectedIndexChanged += new System.EventHandler(this.lsbFembutorok_SelectedIndexChanged);
            // 
            // lblRaktarKereses
            // 
            this.lblRaktarKereses.Location = new System.Drawing.Point(12, 679);
            this.lblRaktarKereses.Name = "lblRaktarKereses";
            this.lblRaktarKereses.Size = new System.Drawing.Size(150, 26);
            this.lblRaktarKereses.TabIndex = 7;
            this.lblRaktarKereses.Text = "Raktár keresés";
            this.lblRaktarKereses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbRaktarKereses
            // 
            this.txbRaktarKereses.Location = new System.Drawing.Point(168, 679);
            this.txbRaktarKereses.Name = "txbRaktarKereses";
            this.txbRaktarKereses.Size = new System.Drawing.Size(204, 26);
            this.txbRaktarKereses.TabIndex = 8;
            // 
            // grbButorRaktar
            // 
            this.grbButorRaktar.Controls.Add(this.btnRaktarTorol);
            this.grbButorRaktar.Controls.Add(this.btnRaktarMegjelenit);
            this.grbButorRaktar.Controls.Add(this.btnRaktarModosit);
            this.grbButorRaktar.Controls.Add(this.btnRaktarUj);
            this.grbButorRaktar.Location = new System.Drawing.Point(834, 28);
            this.grbButorRaktar.Name = "grbButorRaktar";
            this.grbButorRaktar.Size = new System.Drawing.Size(162, 249);
            this.grbButorRaktar.TabIndex = 9;
            this.grbButorRaktar.TabStop = false;
            this.grbButorRaktar.Text = "Bútorraktár";
            // 
            // btnRaktarTorol
            // 
            this.btnRaktarTorol.Location = new System.Drawing.Point(6, 193);
            this.btnRaktarTorol.Name = "btnRaktarTorol";
            this.btnRaktarTorol.Size = new System.Drawing.Size(150, 50);
            this.btnRaktarTorol.TabIndex = 3;
            this.btnRaktarTorol.Text = "Törlés";
            this.btnRaktarTorol.UseVisualStyleBackColor = true;
            this.btnRaktarTorol.Click += new System.EventHandler(this.btnRaktarTorol_Click);
            // 
            // btnRaktarMegjelenit
            // 
            this.btnRaktarMegjelenit.Location = new System.Drawing.Point(6, 137);
            this.btnRaktarMegjelenit.Name = "btnRaktarMegjelenit";
            this.btnRaktarMegjelenit.Size = new System.Drawing.Size(150, 50);
            this.btnRaktarMegjelenit.TabIndex = 2;
            this.btnRaktarMegjelenit.Text = "Megjelenítés";
            this.btnRaktarMegjelenit.UseVisualStyleBackColor = true;
            this.btnRaktarMegjelenit.Click += new System.EventHandler(this.btnRaktarMegjelenit_Click);
            // 
            // btnRaktarModosit
            // 
            this.btnRaktarModosit.Location = new System.Drawing.Point(6, 81);
            this.btnRaktarModosit.Name = "btnRaktarModosit";
            this.btnRaktarModosit.Size = new System.Drawing.Size(150, 50);
            this.btnRaktarModosit.TabIndex = 1;
            this.btnRaktarModosit.Text = "Módosítás";
            this.btnRaktarModosit.UseVisualStyleBackColor = true;
            this.btnRaktarModosit.Click += new System.EventHandler(this.btnRaktarModosit_Click);
            // 
            // btnRaktarUj
            // 
            this.btnRaktarUj.Location = new System.Drawing.Point(6, 25);
            this.btnRaktarUj.Name = "btnRaktarUj";
            this.btnRaktarUj.Size = new System.Drawing.Size(150, 50);
            this.btnRaktarUj.TabIndex = 0;
            this.btnRaktarUj.Text = "Új felvitel";
            this.btnRaktarUj.UseVisualStyleBackColor = true;
            this.btnRaktarUj.Click += new System.EventHandler(this.btnRaktarUj_Click);
            // 
            // grbButor
            // 
            this.grbButor.Controls.Add(this.btnButorTorol);
            this.grbButor.Controls.Add(this.btnButorMegjelenit);
            this.grbButor.Controls.Add(this.btnButorModosit);
            this.grbButor.Controls.Add(this.btnButorUj);
            this.grbButor.Location = new System.Drawing.Point(834, 283);
            this.grbButor.Name = "grbButor";
            this.grbButor.Size = new System.Drawing.Size(162, 249);
            this.grbButor.TabIndex = 10;
            this.grbButor.TabStop = false;
            this.grbButor.Text = "Bútor";
            // 
            // btnButorTorol
            // 
            this.btnButorTorol.Location = new System.Drawing.Point(6, 193);
            this.btnButorTorol.Name = "btnButorTorol";
            this.btnButorTorol.Size = new System.Drawing.Size(150, 50);
            this.btnButorTorol.TabIndex = 4;
            this.btnButorTorol.Text = "Törlés";
            this.btnButorTorol.UseVisualStyleBackColor = true;
            this.btnButorTorol.Click += new System.EventHandler(this.btnButorTorol_Click);
            // 
            // btnButorMegjelenit
            // 
            this.btnButorMegjelenit.Location = new System.Drawing.Point(6, 137);
            this.btnButorMegjelenit.Name = "btnButorMegjelenit";
            this.btnButorMegjelenit.Size = new System.Drawing.Size(150, 50);
            this.btnButorMegjelenit.TabIndex = 3;
            this.btnButorMegjelenit.Text = "Megjelenítés";
            this.btnButorMegjelenit.UseVisualStyleBackColor = true;
            this.btnButorMegjelenit.Click += new System.EventHandler(this.btnButorMegjelenit_Click);
            // 
            // btnButorModosit
            // 
            this.btnButorModosit.Location = new System.Drawing.Point(6, 81);
            this.btnButorModosit.Name = "btnButorModosit";
            this.btnButorModosit.Size = new System.Drawing.Size(150, 50);
            this.btnButorModosit.TabIndex = 2;
            this.btnButorModosit.Text = "Módosítás";
            this.btnButorModosit.UseVisualStyleBackColor = true;
            this.btnButorModosit.Click += new System.EventHandler(this.btnButorModosit_Click);
            // 
            // btnButorUj
            // 
            this.btnButorUj.Location = new System.Drawing.Point(6, 25);
            this.btnButorUj.Name = "btnButorUj";
            this.btnButorUj.Size = new System.Drawing.Size(150, 50);
            this.btnButorUj.TabIndex = 1;
            this.btnButorUj.Text = "Új felvitel";
            this.btnButorUj.UseVisualStyleBackColor = true;
            this.btnButorUj.Click += new System.EventHandler(this.btnButorUj_Click);
            // 
            // btnRaktarakMegjelenit
            // 
            this.btnRaktarakMegjelenit.Location = new System.Drawing.Point(378, 667);
            this.btnRaktarakMegjelenit.Name = "btnRaktarakMegjelenit";
            this.btnRaktarakMegjelenit.Size = new System.Drawing.Size(150, 50);
            this.btnRaktarakMegjelenit.TabIndex = 11;
            this.btnRaktarakMegjelenit.Text = "Raktárak megjelenítése";
            this.btnRaktarakMegjelenit.UseVisualStyleBackColor = true;
            // 
            // btnButorokMegjelenit
            // 
            this.btnButorokMegjelenit.Location = new System.Drawing.Point(534, 667);
            this.btnButorokMegjelenit.Name = "btnButorokMegjelenit";
            this.btnButorokMegjelenit.Size = new System.Drawing.Size(150, 50);
            this.btnButorokMegjelenit.TabIndex = 12;
            this.btnButorokMegjelenit.Text = "Bútorok megjelenítése";
            this.btnButorokMegjelenit.UseVisualStyleBackColor = true;
            // 
            // btnRendezesek
            // 
            this.btnRendezesek.Location = new System.Drawing.Point(690, 667);
            this.btnRendezesek.Name = "btnRendezesek";
            this.btnRendezesek.Size = new System.Drawing.Size(150, 50);
            this.btnRendezesek.TabIndex = 13;
            this.btnRendezesek.Text = "Rendezések";
            this.btnRendezesek.UseVisualStyleBackColor = true;
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(846, 667);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(150, 50);
            this.btnKilepes.TabIndex = 14;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            // 
            // KezdoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnRendezesek);
            this.Controls.Add(this.btnButorokMegjelenit);
            this.Controls.Add(this.btnRaktarakMegjelenit);
            this.Controls.Add(this.grbButor);
            this.Controls.Add(this.grbButorRaktar);
            this.Controls.Add(this.txbRaktarKereses);
            this.Controls.Add(this.lblRaktarKereses);
            this.Controls.Add(this.lsbFembutorok);
            this.Controls.Add(this.lblFembutorok);
            this.Controls.Add(this.lsbFabutorok);
            this.Controls.Add(this.lblFabutorok);
            this.Controls.Add(this.lsbButorRaktarak);
            this.Controls.Add(this.lblButorRaktarak);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KezdoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bútorraktár kezelő alkalmazás";
            this.Load += new System.EventHandler(this.KezdoFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbButorRaktar.ResumeLayout(false);
            this.grbButor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblButorRaktarak;
        private System.Windows.Forms.ListBox lsbButorRaktarak;
        private System.Windows.Forms.Label lblFabutorok;
        private System.Windows.Forms.ListBox lsbFabutorok;
        private System.Windows.Forms.Label lblFembutorok;
        private System.Windows.Forms.ListBox lsbFembutorok;
        private System.Windows.Forms.Label lblRaktarKereses;
        private System.Windows.Forms.TextBox txbRaktarKereses;
        private System.Windows.Forms.GroupBox grbButorRaktar;
        private System.Windows.Forms.Button btnRaktarTorol;
        private System.Windows.Forms.Button btnRaktarMegjelenit;
        private System.Windows.Forms.Button btnRaktarModosit;
        private System.Windows.Forms.Button btnRaktarUj;
        private System.Windows.Forms.GroupBox grbButor;
        private System.Windows.Forms.Button btnButorTorol;
        private System.Windows.Forms.Button btnButorMegjelenit;
        private System.Windows.Forms.Button btnButorModosit;
        private System.Windows.Forms.Button btnButorUj;
        private System.Windows.Forms.Button btnRaktarakMegjelenit;
        private System.Windows.Forms.Button btnButorokMegjelenit;
        private System.Windows.Forms.Button btnRendezesek;
        private System.Windows.Forms.Button btnKilepes;
    }
}

