namespace ProbaModulzaro
{
    partial class RaktarKezelesFrm
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
            this.lblRaktarSzam = new System.Windows.Forms.Label();
            this.lblRaktarNev = new System.Windows.Forms.Label();
            this.grbRaktarCim = new System.Windows.Forms.GroupBox();
            this.txbUtca = new System.Windows.Forms.TextBox();
            this.txbHelyseg = new System.Windows.Forms.TextBox();
            this.numIranyitoSzam = new System.Windows.Forms.NumericUpDown();
            this.lblUtca = new System.Windows.Forms.Label();
            this.lblHelyseg = new System.Windows.Forms.Label();
            this.lblIranyitoSzam = new System.Windows.Forms.Label();
            this.lblButorokMaxSzama = new System.Windows.Forms.Label();
            this.txbRaktarSzam = new System.Windows.Forms.TextBox();
            this.txbRaktarNev = new System.Windows.Forms.TextBox();
            this.numButorokMaxSzama = new System.Windows.Forms.NumericUpDown();
            this.chbVasarnap = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnMegsem = new System.Windows.Forms.Button();
            this.txbHazSzam = new System.Windows.Forms.TextBox();
            this.lblHazSzam = new System.Windows.Forms.Label();
            this.grbRaktarCim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIranyitoSzam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numButorokMaxSzama)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRaktarSzam
            // 
            this.lblRaktarSzam.Location = new System.Drawing.Point(12, 12);
            this.lblRaktarSzam.Name = "lblRaktarSzam";
            this.lblRaktarSzam.Size = new System.Drawing.Size(200, 26);
            this.lblRaktarSzam.TabIndex = 0;
            this.lblRaktarSzam.Text = "Raktár száma";
            this.lblRaktarSzam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRaktarNev
            // 
            this.lblRaktarNev.Location = new System.Drawing.Point(12, 44);
            this.lblRaktarNev.Name = "lblRaktarNev";
            this.lblRaktarNev.Size = new System.Drawing.Size(200, 26);
            this.lblRaktarNev.TabIndex = 1;
            this.lblRaktarNev.Text = "Raktár neve";
            this.lblRaktarNev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbRaktarCim
            // 
            this.grbRaktarCim.Controls.Add(this.txbHazSzam);
            this.grbRaktarCim.Controls.Add(this.lblHazSzam);
            this.grbRaktarCim.Controls.Add(this.txbUtca);
            this.grbRaktarCim.Controls.Add(this.txbHelyseg);
            this.grbRaktarCim.Controls.Add(this.numIranyitoSzam);
            this.grbRaktarCim.Controls.Add(this.lblUtca);
            this.grbRaktarCim.Controls.Add(this.lblHelyseg);
            this.grbRaktarCim.Controls.Add(this.lblIranyitoSzam);
            this.grbRaktarCim.Location = new System.Drawing.Point(12, 76);
            this.grbRaktarCim.Name = "grbRaktarCim";
            this.grbRaktarCim.Size = new System.Drawing.Size(760, 153);
            this.grbRaktarCim.TabIndex = 2;
            this.grbRaktarCim.TabStop = false;
            this.grbRaktarCim.Text = "Raktár címe";
            // 
            // txbUtca
            // 
            this.txbUtca.Location = new System.Drawing.Point(206, 89);
            this.txbUtca.Name = "txbUtca";
            this.txbUtca.Size = new System.Drawing.Size(548, 26);
            this.txbUtca.TabIndex = 4;
            // 
            // txbHelyseg
            // 
            this.txbHelyseg.Location = new System.Drawing.Point(206, 57);
            this.txbHelyseg.Name = "txbHelyseg";
            this.txbHelyseg.Size = new System.Drawing.Size(548, 26);
            this.txbHelyseg.TabIndex = 3;
            // 
            // numIranyitoSzam
            // 
            this.numIranyitoSzam.Location = new System.Drawing.Point(206, 25);
            this.numIranyitoSzam.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numIranyitoSzam.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIranyitoSzam.Name = "numIranyitoSzam";
            this.numIranyitoSzam.Size = new System.Drawing.Size(70, 26);
            this.numIranyitoSzam.TabIndex = 2;
            this.numIranyitoSzam.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblUtca
            // 
            this.lblUtca.Location = new System.Drawing.Point(6, 89);
            this.lblUtca.Name = "lblUtca";
            this.lblUtca.Size = new System.Drawing.Size(194, 26);
            this.lblUtca.TabIndex = 3;
            this.lblUtca.Text = "Utca";
            this.lblUtca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHelyseg
            // 
            this.lblHelyseg.Location = new System.Drawing.Point(6, 57);
            this.lblHelyseg.Name = "lblHelyseg";
            this.lblHelyseg.Size = new System.Drawing.Size(194, 26);
            this.lblHelyseg.TabIndex = 2;
            this.lblHelyseg.Text = "Helység";
            this.lblHelyseg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIranyitoSzam
            // 
            this.lblIranyitoSzam.Location = new System.Drawing.Point(6, 25);
            this.lblIranyitoSzam.Name = "lblIranyitoSzam";
            this.lblIranyitoSzam.Size = new System.Drawing.Size(194, 26);
            this.lblIranyitoSzam.TabIndex = 1;
            this.lblIranyitoSzam.Text = "Irányítószám";
            this.lblIranyitoSzam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblButorokMaxSzama
            // 
            this.lblButorokMaxSzama.Location = new System.Drawing.Point(12, 235);
            this.lblButorokMaxSzama.Name = "lblButorokMaxSzama";
            this.lblButorokMaxSzama.Size = new System.Drawing.Size(200, 26);
            this.lblButorokMaxSzama.TabIndex = 3;
            this.lblButorokMaxSzama.Text = "Bútorok maximális száma";
            this.lblButorokMaxSzama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbRaktarSzam
            // 
            this.txbRaktarSzam.Location = new System.Drawing.Point(218, 12);
            this.txbRaktarSzam.Name = "txbRaktarSzam";
            this.txbRaktarSzam.ReadOnly = true;
            this.txbRaktarSzam.Size = new System.Drawing.Size(70, 26);
            this.txbRaktarSzam.TabIndex = 0;
            // 
            // txbRaktarNev
            // 
            this.txbRaktarNev.Location = new System.Drawing.Point(218, 44);
            this.txbRaktarNev.Name = "txbRaktarNev";
            this.txbRaktarNev.Size = new System.Drawing.Size(554, 26);
            this.txbRaktarNev.TabIndex = 1;
            // 
            // numButorokMaxSzama
            // 
            this.numButorokMaxSzama.Location = new System.Drawing.Point(218, 235);
            this.numButorokMaxSzama.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numButorokMaxSzama.Name = "numButorokMaxSzama";
            this.numButorokMaxSzama.Size = new System.Drawing.Size(120, 26);
            this.numButorokMaxSzama.TabIndex = 6;
            this.numButorokMaxSzama.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // chbVasarnap
            // 
            this.chbVasarnap.Location = new System.Drawing.Point(218, 267);
            this.chbVasarnap.Name = "chbVasarnap";
            this.chbVasarnap.Size = new System.Drawing.Size(250, 26);
            this.chbVasarnap.TabIndex = 7;
            this.chbVasarnap.Text = "Vasárnap is nyitva (X = igen)";
            this.chbVasarnap.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(466, 499);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 50);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnMegsem
            // 
            this.btnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMegsem.Location = new System.Drawing.Point(622, 499);
            this.btnMegsem.Name = "btnMegsem";
            this.btnMegsem.Size = new System.Drawing.Size(150, 50);
            this.btnMegsem.TabIndex = 9;
            this.btnMegsem.Text = "Mégsem";
            this.btnMegsem.UseVisualStyleBackColor = true;
            // 
            // txbHazSzam
            // 
            this.txbHazSzam.Location = new System.Drawing.Point(206, 121);
            this.txbHazSzam.Name = "txbHazSzam";
            this.txbHazSzam.Size = new System.Drawing.Size(548, 26);
            this.txbHazSzam.TabIndex = 5;
            // 
            // lblHazSzam
            // 
            this.lblHazSzam.Location = new System.Drawing.Point(6, 121);
            this.lblHazSzam.Name = "lblHazSzam";
            this.lblHazSzam.Size = new System.Drawing.Size(194, 26);
            this.lblHazSzam.TabIndex = 8;
            this.lblHazSzam.Text = "Házszám";
            this.lblHazSzam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RaktarKezelesFrm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnMegsem;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnMegsem);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chbVasarnap);
            this.Controls.Add(this.numButorokMaxSzama);
            this.Controls.Add(this.txbRaktarNev);
            this.Controls.Add(this.txbRaktarSzam);
            this.Controls.Add(this.lblButorokMaxSzama);
            this.Controls.Add(this.grbRaktarCim);
            this.Controls.Add(this.lblRaktarNev);
            this.Controls.Add(this.lblRaktarSzam);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RaktarKezelesFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bútorraktár kezelése";
            this.grbRaktarCim.ResumeLayout(false);
            this.grbRaktarCim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIranyitoSzam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numButorokMaxSzama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaktarSzam;
        private System.Windows.Forms.Label lblRaktarNev;
        private System.Windows.Forms.GroupBox grbRaktarCim;
        private System.Windows.Forms.TextBox txbUtca;
        private System.Windows.Forms.TextBox txbHelyseg;
        private System.Windows.Forms.NumericUpDown numIranyitoSzam;
        private System.Windows.Forms.Label lblUtca;
        private System.Windows.Forms.Label lblHelyseg;
        private System.Windows.Forms.Label lblIranyitoSzam;
        private System.Windows.Forms.Label lblButorokMaxSzama;
        private System.Windows.Forms.TextBox txbRaktarSzam;
        private System.Windows.Forms.TextBox txbRaktarNev;
        private System.Windows.Forms.NumericUpDown numButorokMaxSzama;
        private System.Windows.Forms.CheckBox chbVasarnap;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnMegsem;
        private System.Windows.Forms.TextBox txbHazSzam;
        private System.Windows.Forms.Label lblHazSzam;
    }
}