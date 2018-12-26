namespace ClientBorrower
{
    partial class LoginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.loginpasswordText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.loginuserNametext = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.idtextbox = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.usernametextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.idcardtextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.firstname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.signpassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.signpasswordc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCheckbox2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.button1);
            this.loginPanel.Controls.Add(this.loginpasswordText);
            this.loginPanel.Controls.Add(this.bunifuCustomLabel1);
            this.loginPanel.Controls.Add(this.bunifuCustomLabel4);
            this.loginPanel.Controls.Add(this.bunifuCustomLabel3);
            this.loginPanel.Controls.Add(this.loginuserNametext);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.loginPanel.ForeColor = System.Drawing.Color.White;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(302, 449);
            this.loginPanel.TabIndex = 0;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(17, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "*If you don\'t own an account you have\r\n to sign-up first";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(20, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginpasswordText
            // 
            this.loginpasswordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginpasswordText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginpasswordText.ForeColor = System.Drawing.Color.White;
            this.loginpasswordText.HintForeColor = System.Drawing.Color.White;
            this.loginpasswordText.HintText = "";
            this.loginpasswordText.isPassword = true;
            this.loginpasswordText.LineFocusedColor = System.Drawing.Color.Lavender;
            this.loginpasswordText.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.loginpasswordText.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.loginpasswordText.LineThickness = 4;
            this.loginpasswordText.Location = new System.Drawing.Point(20, 192);
            this.loginpasswordText.Margin = new System.Windows.Forms.Padding(4);
            this.loginpasswordText.Name = "loginpasswordText";
            this.loginpasswordText.Size = new System.Drawing.Size(246, 44);
            this.loginpasswordText.TabIndex = 9;
            this.loginpasswordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(16, 167);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(82, 21);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Password";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(16, 65);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(94, 21);
            this.bunifuCustomLabel4.TabIndex = 8;
            this.bunifuCustomLabel4.Text = "User Name";
            this.bunifuCustomLabel4.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(26, 10);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(90, 30);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Sign In";
            // 
            // loginuserNametext
            // 
            this.loginuserNametext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginuserNametext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginuserNametext.ForeColor = System.Drawing.Color.White;
            this.loginuserNametext.HintForeColor = System.Drawing.Color.White;
            this.loginuserNametext.HintText = "";
            this.loginuserNametext.isPassword = false;
            this.loginuserNametext.LineFocusedColor = System.Drawing.Color.Lavender;
            this.loginuserNametext.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.loginuserNametext.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.loginuserNametext.LineThickness = 3;
            this.loginuserNametext.Location = new System.Drawing.Point(20, 90);
            this.loginuserNametext.Margin = new System.Windows.Forms.Padding(4);
            this.loginuserNametext.Name = "loginuserNametext";
            this.loginuserNametext.Size = new System.Drawing.Size(246, 45);
            this.loginuserNametext.TabIndex = 3;
            this.loginuserNametext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginuserNametext.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(61, 10);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(100, 30);
            this.bunifuCustomLabel2.TabIndex = 11;
            this.bunifuCustomLabel2.Text = "Sign up";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(48, 264);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(69, 17);
            this.bunifuCustomLabel6.TabIndex = 13;
            this.bunifuCustomLabel6.Text = "Password";
            this.bunifuCustomLabel6.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
            // 
            // idtextbox
            // 
            this.idtextbox.AutoSize = true;
            this.idtextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.idtextbox.Location = new System.Drawing.Point(43, 118);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(97, 17);
            this.idtextbox.TabIndex = 13;
            this.idtextbox.Text = "Card Number";
            this.idtextbox.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(39, 53);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(77, 17);
            this.bunifuCustomLabel5.TabIndex = 13;
            this.bunifuCustomLabel5.Text = "User Name";
            this.bunifuCustomLabel5.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(43, 192);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(72, 17);
            this.bunifuCustomLabel8.TabIndex = 13;
            this.bunifuCustomLabel8.Text = "Full Name";
            this.bunifuCustomLabel8.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.button2.Location = new System.Drawing.Point(117, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // usernametextbox
            // 
            this.usernametextbox.BackColor = System.Drawing.SystemColors.Menu;
            this.usernametextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametextbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.usernametextbox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.usernametextbox.HintText = "";
            this.usernametextbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usernametextbox.isPassword = false;
            this.usernametextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.usernametextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.usernametextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.usernametextbox.LineThickness = 2;
            this.usernametextbox.Location = new System.Drawing.Point(42, 72);
            this.usernametextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(389, 37);
            this.usernametextbox.TabIndex = 14;
            this.usernametextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernametextbox.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged_1);
            // 
            // idcardtextbox
            // 
            this.idcardtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idcardtextbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idcardtextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.idcardtextbox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.idcardtextbox.HintText = "";
            this.idcardtextbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.idcardtextbox.isPassword = false;
            this.idcardtextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.idcardtextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.idcardtextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.idcardtextbox.LineThickness = 2;
            this.idcardtextbox.Location = new System.Drawing.Point(42, 139);
            this.idcardtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.idcardtextbox.Name = "idcardtextbox";
            this.idcardtextbox.Size = new System.Drawing.Size(389, 37);
            this.idcardtextbox.TabIndex = 14;
            this.idcardtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.idcardtextbox.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged_1);
            // 
            // firstname
            // 
            this.firstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.firstname.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.firstname.HintText = "Name";
            this.firstname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.firstname.isPassword = false;
            this.firstname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.firstname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.firstname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.firstname.LineThickness = 2;
            this.firstname.Location = new System.Drawing.Point(41, 212);
            this.firstname.Margin = new System.Windows.Forms.Padding(4);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(180, 37);
            this.firstname.TabIndex = 14;
            this.firstname.Text = "First Name";
            this.firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.firstname.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged_1);
            // 
            // signpassword
            // 
            this.signpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signpassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.signpassword.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.signpassword.HintText = "Password";
            this.signpassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.signpassword.isPassword = true;
            this.signpassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.signpassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.signpassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.signpassword.LineThickness = 2;
            this.signpassword.Location = new System.Drawing.Point(43, 285);
            this.signpassword.Margin = new System.Windows.Forms.Padding(4);
            this.signpassword.Name = "signpassword";
            this.signpassword.Size = new System.Drawing.Size(178, 32);
            this.signpassword.TabIndex = 14;
            this.signpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.signpassword.OnValueChanged += new System.EventHandler(this.signusernametext_OnValueChanged);
            // 
            // signpasswordc
            // 
            this.signpasswordc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signpasswordc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signpasswordc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.signpasswordc.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.signpasswordc.HintText = "Confirmation";
            this.signpasswordc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.signpasswordc.isPassword = true;
            this.signpasswordc.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.signpasswordc.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.signpasswordc.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.signpasswordc.LineThickness = 2;
            this.signpasswordc.Location = new System.Drawing.Point(254, 285);
            this.signpasswordc.Margin = new System.Windows.Forms.Padding(4);
            this.signpasswordc.Name = "signpasswordc";
            this.signpasswordc.Size = new System.Drawing.Size(178, 32);
            this.signpasswordc.TabIndex = 14;
            this.signpasswordc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.signpasswordc.OnValueChanged += new System.EventHandler(this.signusernametext_OnValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bunifuCheckbox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuCheckbox1);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.signpasswordc);
            this.panel1.Controls.Add(this.signpassword);
            this.panel1.Controls.Add(this.lastName);
            this.panel1.Controls.Add(this.firstname);
            this.panel1.Controls.Add(this.idcardtextbox);
            this.panel1.Controls.Add(this.usernametextbox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.bunifuCustomLabel8);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.idtextbox);
            this.panel1.Controls.Add(this.bunifuCustomLabel9);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(299, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 449);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(49, 339);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(91, 21);
            this.bunifuCustomLabel7.TabIndex = 15;
            this.bunifuCustomLabel7.Text = "User Type :";
            this.bunifuCustomLabel7.Click += new System.EventHandler(this.bunifuCustomLabel7_Click);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(251, 264);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(94, 17);
            this.bunifuCustomLabel9.TabIndex = 13;
            this.bunifuCustomLabel9.Text = "Confirmation";
            this.bunifuCustomLabel9.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(201, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "Student";
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = false;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(288, 341);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 75;
            this.bunifuCheckbox1.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // bunifuCheckbox2
            // 
            this.bunifuCheckbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox2.Checked = false;
            this.bunifuCheckbox2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox2.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox2.Location = new System.Drawing.Point(175, 341);
            this.bunifuCheckbox2.Name = "bunifuCheckbox2";
            this.bunifuCheckbox2.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox2.TabIndex = 75;
            this.bunifuCheckbox2.OnChange += new System.EventHandler(this.bunifuCheckbox2_OnChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(314, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 76;
            this.label3.Text = "Teacher";
            // 
            // lastName
            // 
            this.lastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.lastName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.lastName.HintText = "Last Name";
            this.lastName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lastName.isPassword = false;
            this.lastName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.lastName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.lastName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.lastName.LineThickness = 2;
            this.lastName.Location = new System.Drawing.Point(254, 212);
            this.lastName.Margin = new System.Windows.Forms.Padding(4);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(180, 37);
            this.lastName.TabIndex = 14;
            this.lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lastName.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged_1);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginPanel);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(787, 449);
            this.Load += new System.EventHandler(this.LoginControl_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox loginuserNametext;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox loginpasswordText;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel idtextbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usernametextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox idcardtextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox firstname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox signpassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox signpasswordc;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Panel loginPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lastName;
    }
}
