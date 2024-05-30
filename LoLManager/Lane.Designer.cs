namespace LoLManager
{
    partial class Lane
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.capitanCheck = new System.Windows.Forms.CheckBox();
            this.lanePicture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ranks = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lanePicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.capitanCheck);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(568, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(105, 40);
            this.panel1.MinimumSize = new System.Drawing.Size(105, 40);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(105, 40);
            this.panel1.TabIndex = 0;
            // 
            // capitanCheck
            // 
            this.capitanCheck.AutoSize = true;
            this.capitanCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.capitanCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.capitanCheck.Location = new System.Drawing.Point(5, 0);
            this.capitanCheck.MaximumSize = new System.Drawing.Size(0, 40);
            this.capitanCheck.MinimumSize = new System.Drawing.Size(0, 40);
            this.capitanCheck.Name = "capitanCheck";
            this.capitanCheck.Size = new System.Drawing.Size(100, 40);
            this.capitanCheck.TabIndex = 0;
            this.capitanCheck.Text = "kapitan?";
            this.capitanCheck.UseVisualStyleBackColor = true;
            // 
            // lanePicture
            // 
            this.lanePicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.lanePicture.Location = new System.Drawing.Point(0, 0);
            this.lanePicture.Name = "lanePicture";
            this.lanePicture.Size = new System.Drawing.Size(40, 40);
            this.lanePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lanePicture.TabIndex = 0;
            this.lanePicture.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lanePicture);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 40);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.username);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(40, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panel4.Size = new System.Drawing.Size(408, 40);
            this.panel4.TabIndex = 3;
            // 
            // username
            // 
            this.username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.username.Location = new System.Drawing.Point(5, 5);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(398, 29);
            this.username.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ranks);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(448, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel3.Size = new System.Drawing.Size(120, 40);
            this.panel3.TabIndex = 2;
            // 
            // ranks
            // 
            this.ranks.Dock = System.Windows.Forms.DockStyle.Top;
            this.ranks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ranks.FormattingEnabled = true;
            this.ranks.Items.AddRange(new object[] {
            "UNRANK",
            "BRONZE",
            "SILVER",
            "GOLD"});
            this.ranks.Location = new System.Drawing.Point(0, 5);
            this.ranks.MaximumSize = new System.Drawing.Size(120, 0);
            this.ranks.MinimumSize = new System.Drawing.Size(120, 0);
            this.ranks.Name = "ranks";
            this.ranks.Size = new System.Drawing.Size(120, 32);
            this.ranks.TabIndex = 0;
            // 
            // Lane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(480, 40);
            this.Name = "Lane";
            this.Size = new System.Drawing.Size(673, 40);
            this.Load += new System.EventHandler(this.Lane_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lanePicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox lanePicture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox capitanCheck;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox ranks;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox username;
    }
}
