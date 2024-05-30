namespace LoLManager
{
    partial class Match
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Match));
            this.matchList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // matchList
            // 
            this.matchList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.matchList.FormattingEnabled = true;
            this.matchList.ItemHeight = 24;
            this.matchList.Location = new System.Drawing.Point(0, 0);
            this.matchList.Name = "matchList";
            this.matchList.Size = new System.Drawing.Size(364, 221);
            this.matchList.TabIndex = 0;
            // 
            // Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 221);
            this.Controls.Add(this.matchList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(380, 260);
            this.Name = "Match";
            this.Load += new System.EventHandler(this.Match_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox matchList;
    }
}