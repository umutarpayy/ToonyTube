using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToonyTube
{
    public partial class Film : Form
    {
        public Film()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Panel panel1 = new Panel();
            Panel panel = new Panel();
            Label label = new Label();
            label.Text = "umutarpayyyyyyy";
            
            panel.Controls.Add(label);
            label.Font = new Font("Verdana", 14);
            label.Dock = DockStyle.Top;
            pnl_Comments.Controls.Add(panel);
            panel.Width = 670;
            panel.BackColor = Color.Red;
        }
    }
}
