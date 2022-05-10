namespace ProbaModulzaro
{
    partial class MegjelenitesekFrm
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
            this.lsvAdatok = new System.Windows.Forms.ListView();
            this.btnBezar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvAdatok
            // 
            this.lsvAdatok.GridLines = true;
            this.lsvAdatok.HideSelection = false;
            this.lsvAdatok.Location = new System.Drawing.Point(12, 12);
            this.lsvAdatok.Name = "lsvAdatok";
            this.lsvAdatok.Size = new System.Drawing.Size(984, 649);
            this.lsvAdatok.TabIndex = 0;
            this.lsvAdatok.UseCompatibleStateImageBehavior = false;
            this.lsvAdatok.View = System.Windows.Forms.View.Details;
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(846, 667);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(150, 50);
            this.btnBezar.TabIndex = 1;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            // 
            // MegjelenitesekFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.lsvAdatok);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MegjelenitesekFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Megjelenítések";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvAdatok;
        private System.Windows.Forms.Button btnBezar;
    }
}