
namespace ProbaModulzaro2
{
    partial class FrmSzures
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
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.lblSzures = new System.Windows.Forms.Label();
            this.numSzures = new System.Windows.Forms.NumericUpDown();
            this.lsbAdatok = new System.Windows.Forms.ListBox();
            this.btnBezaras = new System.Windows.Forms.Button();
            this.btnSzures = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSzures)).BeginInit();
            this.SuspendLayout();
            // 
            // rdb1
            // 
            this.rdb1.Checked = true;
            this.rdb1.Location = new System.Drawing.Point(12, 12);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(250, 26);
            this.rdb1.TabIndex = 0;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "x <= Futott Km";
            this.rdb1.UseVisualStyleBackColor = true;
            this.rdb1.CheckedChanged += new System.EventHandler(this.rdb1_CheckedChanged);
            // 
            // rdb2
            // 
            this.rdb2.Location = new System.Drawing.Point(12, 44);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(250, 26);
            this.rdb2.TabIndex = 1;
            this.rdb2.Text = "x >= Szállítható utasok száma";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // lblSzures
            // 
            this.lblSzures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSzures.Location = new System.Drawing.Point(12, 73);
            this.lblSzures.Name = "lblSzures";
            this.lblSzures.Size = new System.Drawing.Size(250, 26);
            this.lblSzures.TabIndex = 2;
            this.lblSzures.Text = "Vizsgálandó érték";
            this.lblSzures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numSzures
            // 
            this.numSzures.Location = new System.Drawing.Point(268, 73);
            this.numSzures.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSzures.Name = "numSzures";
            this.numSzures.Size = new System.Drawing.Size(150, 26);
            this.numSzures.TabIndex = 3;
            // 
            // lsbAdatok
            // 
            this.lsbAdatok.FormattingEnabled = true;
            this.lsbAdatok.ItemHeight = 20;
            this.lsbAdatok.Location = new System.Drawing.Point(12, 102);
            this.lsbAdatok.Name = "lsbAdatok";
            this.lsbAdatok.Size = new System.Drawing.Size(760, 404);
            this.lsbAdatok.TabIndex = 4;
            // 
            // btnBezaras
            // 
            this.btnBezaras.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBezaras.Location = new System.Drawing.Point(572, 509);
            this.btnBezaras.Name = "btnBezaras";
            this.btnBezaras.Size = new System.Drawing.Size(200, 40);
            this.btnBezaras.TabIndex = 5;
            this.btnBezaras.Text = "Bezárás";
            this.btnBezaras.UseVisualStyleBackColor = true;
            // 
            // btnSzures
            // 
            this.btnSzures.Location = new System.Drawing.Point(424, 56);
            this.btnSzures.Name = "btnSzures";
            this.btnSzures.Size = new System.Drawing.Size(200, 40);
            this.btnSzures.TabIndex = 6;
            this.btnSzures.Text = "Szűrés";
            this.btnSzures.UseVisualStyleBackColor = true;
            this.btnSzures.Click += new System.EventHandler(this.btnSzures_Click);
            // 
            // FrmSzures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSzures);
            this.Controls.Add(this.btnBezaras);
            this.Controls.Add(this.lsbAdatok);
            this.Controls.Add(this.numSzures);
            this.Controls.Add(this.lblSzures);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.rdb1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSzures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szűrés";
            ((System.ComponentModel.ISupportInitialize)(this.numSzures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.Label lblSzures;
        private System.Windows.Forms.NumericUpDown numSzures;
        private System.Windows.Forms.ListBox lsbAdatok;
        private System.Windows.Forms.Button btnBezaras;
        private System.Windows.Forms.Button btnSzures;
    }
}