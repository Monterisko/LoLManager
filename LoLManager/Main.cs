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
    public partial class Main : Form
    {   
        public static List<Lane> list = new List<Lane>();
        public Main()
        {
            InitializeComponent();
            this.MinimumSize = new Size(500, this.Height);
            this.MaximumSize = new Size(int.MaxValue, 390);
        }

        private void AcceptButtton_Click(object sender, EventArgs e)
        {
            list.Clear();
            list.Add(top);
            list.Add(jungle);
            list.Add(mid);
            list.Add(bot);
            list.Add(supp);
            int counter = 0;
            double aver = 0.0;
            foreach (Lane lane in list)
            {
                if(lane.Capitain) 
                    counter++;
                if (lane.Rank == "BRONZE")
                    aver += 1;
                if (lane.Rank == "SILVER")
                    aver += 2;
                if (lane.Rank == "GOLD")
                    aver += 3;
            }
            if (counter == 1 || counter == 0)
                new Match(teamName.Text, aver/5).ShowDialog();
            else if (counter > 1)
                MessageBox.Show("Zbyt wielu kapitanów!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            if (keyData == Keys.Enter)
            {
                if (!acceptButtton.Focused)
                {
                    acceptButtton.PerformClick();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

       
    }
}
