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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            gbox_Login.Visible = true;
            btn_Sign.Text = "Sign Up";
            gbox_Login.Text = "Sign Up";
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            gbox_Login.Visible = true;
            btn_Sign.Text = "Sign In";
            gbox_Login.Text = "Sign In";
        }

        private void btn_ToonyTube_Click(object sender, EventArgs e)
        {
            gbox_Login.Visible = false;
        }

        private void btn_Sign_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
    }
}
