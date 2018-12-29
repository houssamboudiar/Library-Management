namespace ClientLibrarianWCF
{
    partial class Login
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginuserNametext = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginpasswordText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(274, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loginuserNametext
            // 
            this.loginuserNametext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginuserNametext.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.loginuserNametext.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.loginuserNametext.HintForeColor = System.Drawing.Color.Snow;
            this.loginuserNametext.HintText = "UserName";
            this.loginuserNametext.isPassword = false;
            this.loginuserNametext.LineFocusedColor = System.Drawing.Color.Blue;
            this.loginuserNametext.LineIdleColor = System.Drawing.Color.Gray;
            this.loginuserNametext.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.loginuserNametext.LineThickness = 3;
            this.loginuserNametext.Location = new System.Drawing.Point(142, 182);
            this.loginuserNametext.Margin = new System.Windows.Forms.Padding(4);
            this.loginuserNametext.Name = "loginuserNametext";
            this.loginuserNametext.Size = new System.Drawing.Size(349, 33);
            this.loginuserNametext.TabIndex = 6;
            this.loginuserNametext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // loginpasswordText
            // 
            this.loginpasswordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginpasswordText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.loginpasswordText.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.loginpasswordText.HintForeColor = System.Drawing.Color.Snow;
            this.loginpasswordText.HintText = "*****";
            this.loginpasswordText.isPassword = true;
            this.loginpasswordText.LineFocusedColor = System.Drawing.Color.Blue;
            this.loginpasswordText.LineIdleColor = System.Drawing.Color.Gray;
            this.loginpasswordText.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.loginpasswordText.LineThickness = 3;
            this.loginpasswordText.Location = new System.Drawing.Point(142, 235);
            this.loginpasswordText.Margin = new System.Windows.Forms.Padding(4);
            this.loginpasswordText.Name = "loginpasswordText";
            this.loginpasswordText.Size = new System.Drawing.Size(349, 33);
            this.loginpasswordText.TabIndex = 7;
            this.loginpasswordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.SystemColors.MenuText;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Login";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.SystemColors.Info;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.SystemColors.MenuText;
            this.bunifuThinButton21.Location = new System.Drawing.Point(238, 305);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton21.TabIndex = 8;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.loginpasswordText);
            this.Controls.Add(this.loginuserNametext);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(629, 414);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox loginuserNametext;
        private Bunifu.Framework.UI.BunifuMaterialTextbox loginpasswordText;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}
