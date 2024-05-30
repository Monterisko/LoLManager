namespace LoLManager
{
    partial class Main
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.teamName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.acceptButtton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.supp = new LoLManager.Lane();
            this.bot = new LoLManager.Lane();
            this.mid = new LoLManager.Lane();
            this.jungle = new LoLManager.Lane();
            this.top = new LoLManager.Lane();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(0, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 130);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szczegóły";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.teamName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 25);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel2.Size = new System.Drawing.Size(456, 86);
            this.panel2.TabIndex = 6;
            // 
            // teamName
            // 
            this.teamName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamName.Location = new System.Drawing.Point(10, 24);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(436, 29);
            this.teamName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa drużyny:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.acceptButtton);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(459, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 86);
            this.panel1.TabIndex = 5;
            // 
            // acceptButtton
            // 
            this.acceptButtton.Dock = System.Windows.Forms.DockStyle.Top;
            this.acceptButtton.Location = new System.Drawing.Point(0, 0);
            this.acceptButtton.Name = "acceptButtton";
            this.acceptButtton.Size = new System.Drawing.Size(211, 34);
            this.acceptButtton.TabIndex = 1;
            this.acceptButtton.Text = "Akceptuj";
            this.acceptButtton.UseVisualStyleBackColor = true;
            this.acceptButtton.Click += new System.EventHandler(this.AcceptButtton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(0, 40);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(211, 35);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Wyjdź";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "/Bartosz Siedlecki, 29.05.2024/";
            // 
            // supp
            // 
            this.supp.Dock = System.Windows.Forms.DockStyle.Top;
            this.supp.Location = new System.Drawing.Point(0, 168);
            this.supp.MinimumSize = new System.Drawing.Size(480, 40);
            this.supp.Name = "supp";
            this.supp.Picture = global::LoLManager.Properties.Resources.Support;
            this.supp.Size = new System.Drawing.Size(673, 40);
            this.supp.TabIndex = 6;
            // 
            // bot
            // 
            this.bot.Dock = System.Windows.Forms.DockStyle.Top;
            this.bot.Location = new System.Drawing.Point(0, 124);
            this.bot.MinimumSize = new System.Drawing.Size(480, 40);
            this.bot.Name = "bot";
            this.bot.Picture = global::LoLManager.Properties.Resources.Bottom;
            this.bot.Size = new System.Drawing.Size(673, 44);
            this.bot.TabIndex = 4;
            // 
            // mid
            // 
            this.mid.Dock = System.Windows.Forms.DockStyle.Top;
            this.mid.Location = new System.Drawing.Point(0, 84);
            this.mid.MinimumSize = new System.Drawing.Size(480, 40);
            this.mid.Name = "mid";
            this.mid.Picture = global::LoLManager.Properties.Resources.Middle;
            this.mid.Size = new System.Drawing.Size(673, 40);
            this.mid.TabIndex = 3;
            // 
            // jungle
            // 
            this.jungle.Dock = System.Windows.Forms.DockStyle.Top;
            this.jungle.Location = new System.Drawing.Point(0, 40);
            this.jungle.MinimumSize = new System.Drawing.Size(480, 40);
            this.jungle.Name = "jungle";
            this.jungle.Picture = global::LoLManager.Properties.Resources.Jungle;
            this.jungle.Size = new System.Drawing.Size(673, 44);
            this.jungle.TabIndex = 2;
            // 
            // top
            // 
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.MinimumSize = new System.Drawing.Size(480, 40);
            this.top.Name = "top";
            this.top.Picture = global::LoLManager.Properties.Resources.Top;
            this.top.Size = new System.Drawing.Size(673, 40);
            this.top.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 351);
            this.Controls.Add(this.supp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bot);
            this.Controls.Add(this.mid);
            this.Controls.Add(this.jungle);
            this.Controls.Add(this.top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Menedżer Drużyn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private Lane bot;
        private Lane mid;
        private Lane jungle;
        private Lane top;
        private Lane supp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button acceptButtton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox teamName;
        private System.Windows.Forms.Label label1;

    }
}

