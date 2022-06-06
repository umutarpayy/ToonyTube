namespace ToonyTube
{
    
    public partial class Profile : Form
    {
        
        public Profile()
        {
            InitializeComponent();
            pnl_Nav.Height = btn_Statistics.Height;
            pnl_Nav.Top = btn_Statistics.Top;
            pnl_Nav.Left = btn_Statistics.Left;
            btn_Statistics.BackColor = Color.FromArgb(46, 51, 73);
            
        }

        private void pnl_Nav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            pnl_Nav.Height = btn_Statistics.Height;
            pnl_Nav.Top = btn_Statistics.Top;
            pnl_Nav.Left = btn_Statistics.Left;
            btn_Statistics.BackColor = Color.FromArgb(46, 51, 73);
            tabControl.SelectTab(0);
            lbl_header.Text = "Statistics";

        }

        private void btn_Lists_Click(object sender, EventArgs e)
        {
            pnl_Nav.Height = btn_Lists.Height;
            pnl_Nav.Top = btn_Lists.Top;
            pnl_Nav.Left = btn_Lists.Left;
            btn_Lists.BackColor = Color.FromArgb(46, 51, 73);
            tabControl.SelectTab(1);
            lbl_header.Text = "Lists";
        }

        private void btn_Statistics_Leave(object sender, EventArgs e)
        {
            btn_Statistics.BackColor = Color.LightSlateGray;
        }

        private void btn_Lists_Leave(object sender, EventArgs e)
        {
            btn_Lists.BackColor = Color.LightSlateGray;
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            pnl_Nav.Height = btn_Settings.Height;
            pnl_Nav.Top = btn_Settings.Top;
            pnl_Nav.Left = btn_Settings.Left;
            btn_Settings.BackColor = Color.FromArgb(46, 51, 73);
            tabControl.SelectTab(2);
            lbl_header.Text = "Settings";
        }

        private void btn_Settings_Leave(object sender, EventArgs e)
        {
            btn_Settings.BackColor = Color.LightSlateGray;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txt_UserName.Text = ofd.FileName;
                ProfilePicture.Image = new Bitmap(ofd.FileName);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
int i = 0;
        int j = 0;
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Panel panel1 = new Panel();
            Panel panel = new Panel();
            Label label = new Label();
            label.Text = i.ToString();
            i++;
            panel.Controls.Add(label);
            label.Font = new Font("Verdana", 14);
            label.Dock = DockStyle.Top;
            pnl_Lists.Controls.Add(panel);
            panel.Width = 670;
            
            if (j < 1)
            {
                pnl_FavoriteFilms.Controls.Add(panel1);
                panel1.Dock = DockStyle.Top;
                panel1.Height = 70;
                panel1.Width = 40;
                
                j++;
            }
            else
            {
                PictureBox pc = new PictureBox();
                pnl_FavoriteFilms.Controls.Add(pc);
                pc.Dock = DockStyle.Left;
            }
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            
            login.Show();
            
        }
    }
}