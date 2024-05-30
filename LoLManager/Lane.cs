using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoLManager
{
    public partial class Lane : UserControl
    {
        public Lane()
        {
            InitializeComponent();
        }

        public Image Picture
        {
            get { return lanePicture.Image; }
            set { lanePicture.Image = value; }
        }
        
        public string Username
        {
            get { return username.Text; }
        }

        public string Rank
        {
            get { return ranks.Text; }
        }

        public bool Capitain
        {
            get { return capitanCheck.Checked; }
        }

        public override string ToString()
        {
            if (Capitain)
            {
                return $"* {Username} ({Rank})"; 
            }
            return $"{Username} ({Rank})";
        }
        private void Lane_Load(object sender, EventArgs e)
        {
            ranks.SelectedIndex = 0;
            username.Select();
        }
    }
}
