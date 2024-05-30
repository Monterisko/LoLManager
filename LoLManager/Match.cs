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
    public partial class Match : Form
    {
        public Match(string teamName, double average)
        {
            InitializeComponent();
            this.Text = teamName + ": " + average.ToString("F02");
        }

        private void Match_Load(object sender, EventArgs e)
        {
            foreach(Lane lane in Main.list){
                matchList.Items.Add(lane.ToString());
            }
        }
    }
}
