namespace ClientLibrarian
{
    partial class ProfilLibrarian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilLibrarian));
            this.AddWork = new System.Windows.Forms.Button();
            this.EditWork = new System.Windows.Forms.Button();
            this.DeleteWork = new System.Windows.Forms.Button();
            this.ConfirmBooking = new System.Windows.Forms.Button();
            this.ReturnWork = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.index = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.login1 = new ClientLibrarianWCF.Login();
            this.recupererOuvrage1 = new ClientLibrarianWCF.RecupererOuvrage();
            this.rendreOuvrage1 = new ClientLibrarianWCF.RendreOuvrage();
            this.supprimerOuvrage1 = new ClientLibrarianWCF.SupprimerOuvrage();
            this.confirmerReservation1 = new ClientLibrarianWCF.ConfirmerReservation();
            this.ajouterOuvrage1 = new ClientLibrarianWCF.AjouterOuvrage();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddWork
            // 
            this.AddWork.Enabled = false;
            this.AddWork.FlatAppearance.BorderSize = 0;
            this.AddWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddWork.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWork.ForeColor = System.Drawing.SystemColors.Info;
            this.AddWork.Image = ((System.Drawing.Image)(resources.GetObject("AddWork.Image")));
            this.AddWork.Location = new System.Drawing.Point(12, 60);
            this.AddWork.Name = "AddWork";
            this.AddWork.Size = new System.Drawing.Size(187, 39);
            this.AddWork.TabIndex = 0;
            this.AddWork.Text = "New Work";
            this.AddWork.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddWork.UseVisualStyleBackColor = true;
            this.AddWork.Click += new System.EventHandler(this.AddWork_Click);
            // 
            // EditWork
            // 
            this.EditWork.Enabled = false;
            this.EditWork.FlatAppearance.BorderSize = 0;
            this.EditWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditWork.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditWork.ForeColor = System.Drawing.SystemColors.Info;
            this.EditWork.Image = ((System.Drawing.Image)(resources.GetObject("EditWork.Image")));
            this.EditWork.Location = new System.Drawing.Point(12, 105);
            this.EditWork.Name = "EditWork";
            this.EditWork.Size = new System.Drawing.Size(187, 39);
            this.EditWork.TabIndex = 1;
            this.EditWork.Text = "Edit Work";
            this.EditWork.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditWork.UseVisualStyleBackColor = true;
            this.EditWork.Click += new System.EventHandler(this.EditWork_Click);
            // 
            // DeleteWork
            // 
            this.DeleteWork.Enabled = false;
            this.DeleteWork.FlatAppearance.BorderSize = 0;
            this.DeleteWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteWork.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteWork.ForeColor = System.Drawing.SystemColors.Info;
            this.DeleteWork.Image = ((System.Drawing.Image)(resources.GetObject("DeleteWork.Image")));
            this.DeleteWork.Location = new System.Drawing.Point(12, 150);
            this.DeleteWork.Name = "DeleteWork";
            this.DeleteWork.Size = new System.Drawing.Size(187, 39);
            this.DeleteWork.TabIndex = 2;
            this.DeleteWork.Text = "Delete Work";
            this.DeleteWork.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteWork.UseVisualStyleBackColor = true;
            this.DeleteWork.Click += new System.EventHandler(this.DeleteWork_Click);
            // 
            // ConfirmBooking
            // 
            this.ConfirmBooking.Enabled = false;
            this.ConfirmBooking.FlatAppearance.BorderSize = 0;
            this.ConfirmBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmBooking.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBooking.ForeColor = System.Drawing.SystemColors.Info;
            this.ConfirmBooking.Image = ((System.Drawing.Image)(resources.GetObject("ConfirmBooking.Image")));
            this.ConfirmBooking.Location = new System.Drawing.Point(12, 195);
            this.ConfirmBooking.Name = "ConfirmBooking";
            this.ConfirmBooking.Size = new System.Drawing.Size(187, 39);
            this.ConfirmBooking.TabIndex = 3;
            this.ConfirmBooking.Text = "Confirm Booking";
            this.ConfirmBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ConfirmBooking.UseVisualStyleBackColor = true;
            this.ConfirmBooking.Click += new System.EventHandler(this.ConfirmBooking_Click);
            // 
            // ReturnWork
            // 
            this.ReturnWork.Enabled = false;
            this.ReturnWork.FlatAppearance.BorderSize = 0;
            this.ReturnWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnWork.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnWork.ForeColor = System.Drawing.SystemColors.Info;
            this.ReturnWork.Image = ((System.Drawing.Image)(resources.GetObject("ReturnWork.Image")));
            this.ReturnWork.Location = new System.Drawing.Point(12, 240);
            this.ReturnWork.Name = "ReturnWork";
            this.ReturnWork.Size = new System.Drawing.Size(187, 39);
            this.ReturnWork.TabIndex = 4;
            this.ReturnWork.Text = "Return Work";
            this.ReturnWork.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReturnWork.UseVisualStyleBackColor = true;
            this.ReturnWork.Click += new System.EventHandler(this.ReturnWork_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.index);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AddWork);
            this.panel1.Controls.Add(this.ReturnWork);
            this.panel1.Controls.Add(this.EditWork);
            this.panel1.Controls.Add(this.ConfirmBooking);
            this.panel1.Controls.Add(this.DeleteWork);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 450);
            this.panel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(12, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "    Login";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // index
            // 
            this.index.BackColor = System.Drawing.SystemColors.MenuText;
            this.index.Location = new System.Drawing.Point(0, 60);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(13, 39);
            this.index.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "  Logout";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(202, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 19);
            this.panel2.TabIndex = 6;
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.login1.Location = new System.Drawing.Point(202, 19);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(598, 431);
            this.login1.TabIndex = 13;
            this.login1.LoggedIn += new System.EventHandler(this.Loggedin);
            this.login1.Load += new System.EventHandler(this.login1_Load);
            // 
            // recupererOuvrage1
            // 
            this.recupererOuvrage1.Location = new System.Drawing.Point(202, 22);
            this.recupererOuvrage1.Name = "recupererOuvrage1";
            this.recupererOuvrage1.Size = new System.Drawing.Size(598, 427);
            this.recupererOuvrage1.TabIndex = 12;
            // 
            // rendreOuvrage1
            // 
            this.rendreOuvrage1.Location = new System.Drawing.Point(202, 25);
            this.rendreOuvrage1.Name = "rendreOuvrage1";
            this.rendreOuvrage1.Size = new System.Drawing.Size(598, 425);
            this.rendreOuvrage1.TabIndex = 8;
            // 
            // supprimerOuvrage1
            // 
            this.supprimerOuvrage1.AccessibleDescription = "";
            this.supprimerOuvrage1.Location = new System.Drawing.Point(205, 25);
            this.supprimerOuvrage1.Name = "supprimerOuvrage1";
            this.supprimerOuvrage1.Size = new System.Drawing.Size(591, 419);
            this.supprimerOuvrage1.TabIndex = 11;
            this.supprimerOuvrage1.Tag = "";
            this.supprimerOuvrage1.Load += new System.EventHandler(this.supprimerOuvrage1_Load);
            // 
            // confirmerReservation1
            // 
            this.confirmerReservation1.Location = new System.Drawing.Point(205, 25);
            this.confirmerReservation1.Name = "confirmerReservation1";
            this.confirmerReservation1.Size = new System.Drawing.Size(588, 422);
            this.confirmerReservation1.TabIndex = 9;
            this.confirmerReservation1.Load += new System.EventHandler(this.confirmerReservation1_Load);
            // 
            // ajouterOuvrage1
            // 
            this.ajouterOuvrage1.Location = new System.Drawing.Point(202, 22);
            this.ajouterOuvrage1.Name = "ajouterOuvrage1";
            this.ajouterOuvrage1.Size = new System.Drawing.Size(598, 422);
            this.ajouterOuvrage1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.WindowText;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(574, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 19);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.WindowText;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(544, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 19);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ProfilLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.recupererOuvrage1);
            this.Controls.Add(this.rendreOuvrage1);
            this.Controls.Add(this.supprimerOuvrage1);
            this.Controls.Add(this.confirmerReservation1);
            this.Controls.Add(this.ajouterOuvrage1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfilLibrarian";
            this.Text = "ProfilLibrarian";
            this.Load += new System.EventHandler(this.ProfilLibrarian_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddWork;
        private System.Windows.Forms.Button EditWork;
        private System.Windows.Forms.Button DeleteWork;
        private System.Windows.Forms.Button ConfirmBooking;
        private System.Windows.Forms.Button ReturnWork;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel index;
        private System.Windows.Forms.Panel panel2;
        private ClientLibrarianWCF.AjouterOuvrage ajouterOuvrage1;
        private ClientLibrarianWCF.RendreOuvrage rendreOuvrage1;
        private ClientLibrarianWCF.ConfirmerReservation confirmerReservation1;
        private ClientLibrarianWCF.SupprimerOuvrage supprimerOuvrage1;
        private ClientLibrarianWCF.RecupererOuvrage recupererOuvrage1;
        private System.Windows.Forms.Button button2;
        private ClientLibrarianWCF.Login login1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}