
namespace ProbaModulzaro2
{
    partial class FrmRendezes
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
            this.btnBezaras = new System.Windows.Forms.Button();
            this.lsbAdatok = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBezaras
            // 
            this.btnBezaras.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBezaras.Location = new System.Drawing.Point(796, 677);
            this.btnBezaras.Name = "btnBezaras";
            this.btnBezaras.Size = new System.Drawing.Size(200, 40);
            this.btnBezaras.TabIndex = 1;
            this.btnBezaras.Text = "Bezárás";
            this.btnBezaras.UseVisualStyleBackColor = true;
            // 
            // lsbAdatok
            // 
            this.lsbAdatok.FormattingEnabled = true;
            this.lsbAdatok.ItemHeight = 20;
            this.lsbAdatok.Location = new System.Drawing.Point(12, 12);
            this.lsbAdatok.Name = "lsbAdatok";
            this.lsbAdatok.Size = new System.Drawing.Size(984, 644);
            this.lsbAdatok.TabIndex = 2;
            // 
            // FrmRendezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBezaras;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lsbAdatok);
            this.Controls.Add(this.btnBezaras);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRendezes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rendezés  Gyártó neve és Azonosító szerint";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBezaras;
        private System.Windows.Forms.ListBox lsbAdatok;
    }
}