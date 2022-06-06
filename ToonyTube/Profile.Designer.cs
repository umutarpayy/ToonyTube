namespace ToonyTube
{
    partial class Profile
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Nav = new System.Windows.Forms.Panel();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Lists = new System.Windows.Forms.Button();
            this.btn_Statistics = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.lbl_header = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Cartoon = new System.Windows.Forms.Label();
            this.pnl_Action = new System.Windows.Forms.Panel();
            this.pnl_SciFi = new System.Windows.Forms.Panel();
            this.pnl_Horror = new System.Windows.Forms.Panel();
            this.pnl_Comedy = new System.Windows.Forms.Panel();
            this.pnl_Cartoon = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnl_Lists = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_FavoriteFilms = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_SelectPP = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.lbl_ProfilePicture = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnl_Lists.SuspendLayout();
            this.pnl_FavoriteFilms.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.pnl_Nav);
            this.panel1.Controls.Add(this.btn_Settings);
            this.panel1.Controls.Add(this.btn_Lists);
            this.panel1.Controls.Add(this.btn_Statistics);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // pnl_Nav
            // 
            this.pnl_Nav.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_Nav.Location = new System.Drawing.Point(0, 152);
            this.pnl_Nav.Name = "pnl_Nav";
            this.pnl_Nav.Size = new System.Drawing.Size(5, 70);
            this.pnl_Nav.TabIndex = 2;
            this.pnl_Nav.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Nav_Paint);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Settings.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_Settings.Image")));
            this.btn_Settings.Location = new System.Drawing.Point(0, 535);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(186, 42);
            this.btn_Settings.TabIndex = 1;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            this.btn_Settings.Leave += new System.EventHandler(this.btn_Settings_Leave);
            // 
            // btn_Lists
            // 
            this.btn_Lists.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Lists.FlatAppearance.BorderSize = 0;
            this.btn_Lists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lists.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Lists.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Lists.Image = ((System.Drawing.Image)(resources.GetObject("btn_Lists.Image")));
            this.btn_Lists.Location = new System.Drawing.Point(0, 186);
            this.btn_Lists.Name = "btn_Lists";
            this.btn_Lists.Size = new System.Drawing.Size(186, 42);
            this.btn_Lists.TabIndex = 1;
            this.btn_Lists.Text = "Lists        ";
            this.btn_Lists.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Lists.UseVisualStyleBackColor = true;
            this.btn_Lists.Click += new System.EventHandler(this.btn_Lists_Click);
            this.btn_Lists.Leave += new System.EventHandler(this.btn_Lists_Leave);
            // 
            // btn_Statistics
            // 
            this.btn_Statistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Statistics.FlatAppearance.BorderSize = 0;
            this.btn_Statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Statistics.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Statistics.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Statistics.Image = ((System.Drawing.Image)(resources.GetObject("btn_Statistics.Image")));
            this.btn_Statistics.Location = new System.Drawing.Point(0, 144);
            this.btn_Statistics.Name = "btn_Statistics";
            this.btn_Statistics.Size = new System.Drawing.Size(186, 42);
            this.btn_Statistics.TabIndex = 1;
            this.btn_Statistics.Text = "Statistics";
            this.btn_Statistics.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Statistics.UseVisualStyleBackColor = true;
            this.btn_Statistics.Click += new System.EventHandler(this.btn_Statistics_Click);
            this.btn_Statistics.Leave += new System.EventHandler(this.btn_Statistics_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ProfilePicture);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(49, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePicture.Image")));
            this.ProfilePicture.Location = new System.Drawing.Point(60, 22);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(63, 63);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicture.TabIndex = 0;
            this.ProfilePicture.TabStop = false;
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_header.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_header.Location = new System.Drawing.Point(215, 22);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(139, 32);
            this.lbl_header.TabIndex = 1;
            this.lbl_header.Text = "Statistics";
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(893, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(46, 43);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(211, 61);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(719, 499);
            this.tabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(711, 471);
            this.tabPage1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbl_Cartoon);
            this.panel3.Controls.Add(this.pnl_Action);
            this.panel3.Controls.Add(this.pnl_SciFi);
            this.panel3.Controls.Add(this.pnl_Horror);
            this.panel3.Controls.Add(this.pnl_Comedy);
            this.panel3.Controls.Add(this.pnl_Cartoon);
            this.panel3.Location = new System.Drawing.Point(42, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 369);
            this.panel3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(9, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sci-Fi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(9, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Action";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(9, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Horror";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(9, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comedy";
            // 
            // lbl_Cartoon
            // 
            this.lbl_Cartoon.AutoSize = true;
            this.lbl_Cartoon.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cartoon.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Cartoon.Location = new System.Drawing.Point(9, 58);
            this.lbl_Cartoon.Name = "lbl_Cartoon";
            this.lbl_Cartoon.Size = new System.Drawing.Size(95, 23);
            this.lbl_Cartoon.TabIndex = 1;
            this.lbl_Cartoon.Text = "Cartoon";
            // 
            // pnl_Action
            // 
            this.pnl_Action.BackColor = System.Drawing.Color.Plum;
            this.pnl_Action.Location = new System.Drawing.Point(110, 242);
            this.pnl_Action.Name = "pnl_Action";
            this.pnl_Action.Size = new System.Drawing.Size(0, 42);
            this.pnl_Action.TabIndex = 0;
            this.pnl_Action.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pnl_SciFi
            // 
            this.pnl_SciFi.BackColor = System.Drawing.Color.RosyBrown;
            this.pnl_SciFi.Location = new System.Drawing.Point(110, 194);
            this.pnl_SciFi.Name = "pnl_SciFi";
            this.pnl_SciFi.Size = new System.Drawing.Size(0, 42);
            this.pnl_SciFi.TabIndex = 0;
            this.pnl_SciFi.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pnl_Horror
            // 
            this.pnl_Horror.BackColor = System.Drawing.Color.Sienna;
            this.pnl_Horror.Location = new System.Drawing.Point(110, 146);
            this.pnl_Horror.Name = "pnl_Horror";
            this.pnl_Horror.Size = new System.Drawing.Size(0, 42);
            this.pnl_Horror.TabIndex = 0;
            this.pnl_Horror.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pnl_Comedy
            // 
            this.pnl_Comedy.BackColor = System.Drawing.Color.LightGreen;
            this.pnl_Comedy.Location = new System.Drawing.Point(110, 98);
            this.pnl_Comedy.Name = "pnl_Comedy";
            this.pnl_Comedy.Size = new System.Drawing.Size(0, 42);
            this.pnl_Comedy.TabIndex = 0;
            this.pnl_Comedy.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pnl_Cartoon
            // 
            this.pnl_Cartoon.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnl_Cartoon.Location = new System.Drawing.Point(110, 50);
            this.pnl_Cartoon.Name = "pnl_Cartoon";
            this.pnl_Cartoon.Size = new System.Drawing.Size(0, 42);
            this.pnl_Cartoon.TabIndex = 0;
            this.pnl_Cartoon.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.pnl_Lists);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(711, 471);
            this.tabPage2.TabIndex = 1;
            // 
            // pnl_Lists
            // 
            this.pnl_Lists.AutoScroll = true;
            this.pnl_Lists.Controls.Add(this.pnl_FavoriteFilms);
            this.pnl_Lists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Lists.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnl_Lists.Location = new System.Drawing.Point(3, 3);
            this.pnl_Lists.Name = "pnl_Lists";
            this.pnl_Lists.Size = new System.Drawing.Size(705, 465);
            this.pnl_Lists.TabIndex = 1;
            this.pnl_Lists.WrapContents = false;
            // 
            // pnl_FavoriteFilms
            // 
            this.pnl_FavoriteFilms.AutoScroll = true;
            this.pnl_FavoriteFilms.Controls.Add(this.label7);
            this.pnl_FavoriteFilms.Location = new System.Drawing.Point(3, 3);
            this.pnl_FavoriteFilms.Name = "pnl_FavoriteFilms";
            this.pnl_FavoriteFilms.Size = new System.Drawing.Size(670, 100);
            this.pnl_FavoriteFilms.TabIndex = 0;
            this.pnl_FavoriteFilms.WrapContents = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Favorite Films";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.btn_Save);
            this.tabPage3.Controls.Add(this.btn_SelectPP);
            this.tabPage3.Controls.Add(this.txt_Password);
            this.tabPage3.Controls.Add(this.txt_UserName);
            this.tabPage3.Controls.Add(this.lbl_ProfilePicture);
            this.tabPage3.Controls.Add(this.lbl_Password);
            this.tabPage3.Controls.Add(this.lbl_UserName);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(711, 471);
            this.tabPage3.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Save.Location = new System.Drawing.Point(439, 274);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(92, 31);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_SelectPP
            // 
            this.btn_SelectPP.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SelectPP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_SelectPP.Location = new System.Drawing.Point(300, 219);
            this.btn_SelectPP.Name = "btn_SelectPP";
            this.btn_SelectPP.Size = new System.Drawing.Size(231, 31);
            this.btn_SelectPP.TabIndex = 2;
            this.btn_SelectPP.Text = "Select An Image!";
            this.btn_SelectPP.UseVisualStyleBackColor = true;
            this.btn_SelectPP.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Password.Location = new System.Drawing.Point(247, 163);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PlaceholderText = "*****";
            this.txt_Password.Size = new System.Drawing.Size(284, 31);
            this.txt_Password.TabIndex = 1;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_UserName.Location = new System.Drawing.Point(261, 106);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.PlaceholderText = "Cool User Name";
            this.txt_UserName.Size = new System.Drawing.Size(270, 31);
            this.txt_UserName.TabIndex = 1;
            // 
            // lbl_ProfilePicture
            // 
            this.lbl_ProfilePicture.AutoSize = true;
            this.lbl_ProfilePicture.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ProfilePicture.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_ProfilePicture.Location = new System.Drawing.Point(118, 223);
            this.lbl_ProfilePicture.Name = "lbl_ProfilePicture";
            this.lbl_ProfilePicture.Size = new System.Drawing.Size(187, 23);
            this.lbl_ProfilePicture.TabIndex = 0;
            this.lbl_ProfilePicture.Text = "Profile Picture : ";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Password.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Password.Location = new System.Drawing.Point(118, 166);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(135, 23);
            this.lbl_Password.TabIndex = 0;
            this.lbl_Password.Text = "Password : ";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UserName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_UserName.Location = new System.Drawing.Point(118, 109);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(149, 23);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "User Name : ";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(211, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 33);
            this.panel4.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnl_Lists.ResumeLayout(false);
            this.pnl_FavoriteFilms.ResumeLayout(false);
            this.pnl_FavoriteFilms.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel pnl_Nav;
        private Button btn_Settings;
        private Button btn_Lists;
        private Button btn_Statistics;
        private Panel panel2;
        private Label label1;
        private PictureBox ProfilePicture;
        private Label lbl_header;
        private Button btn_Exit;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btn_SelectPP;
        private TextBox txt_Password;
        private TextBox txt_UserName;
        private Label lbl_ProfilePicture;
        private Label lbl_Password;
        private Label lbl_UserName;
        private Panel panel3;
        private Panel pnl_Cartoon;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbl_Cartoon;
        private Panel pnl_Action;
        private Panel pnl_SciFi;
        private Panel pnl_Horror;
        private Panel pnl_Comedy;
        private Button btn_Save;
        private FlowLayoutPanel pnl_Lists;
        private Panel panel4;
        private FlowLayoutPanel pnl_FavoriteFilms;
        private Label label7;
        private Button button1;
    }
}