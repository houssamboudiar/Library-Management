namespace ClientBorrower
{
    partial class ConsultWorks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultWorks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchResults = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Writers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.subjectbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.writersbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.tagsbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.titlebox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.reserveID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.searchBar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.emailbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.emailbox);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.searchResults);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.subjectbox);
            this.panel1.Controls.Add(this.writersbox);
            this.panel1.Controls.Add(this.tagsbox);
            this.panel1.Controls.Add(this.titlebox);
            this.panel1.Controls.Add(this.reserveID);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.searchBar);
            this.panel1.Controls.Add(this.bunifuCustomLabel10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 471);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(677, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 53);
            this.button2.TabIndex = 79;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(677, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 51);
            this.button1.TabIndex = 78;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchResults
            // 
            this.searchResults.BackColor = System.Drawing.Color.LightSteelBlue;
            this.searchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Title,
            this.Type,
            this.Subject,
            this.Writers,
            this.Tags});
            this.searchResults.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResults.ForeColor = System.Drawing.SystemColors.MenuText;
            this.searchResults.FullRowSelect = true;
            this.searchResults.GridLines = true;
            this.searchResults.HoverSelection = true;
            this.searchResults.Location = new System.Drawing.Point(-3, 190);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(787, 281);
            this.searchResults.TabIndex = 77;
            this.searchResults.UseCompatibleStateImageBehavior = false;
            this.searchResults.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 69;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 145;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 109;
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            this.Subject.Width = 165;
            // 
            // Writers
            // 
            this.Writers.Text = "Writers";
            this.Writers.Width = 132;
            // 
            // Tags
            // 
            this.Tags.Text = "Tags";
            this.Tags.Width = 174;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(588, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(508, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "Writers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(361, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 34);
            this.label5.TabIndex = 74;
            this.label5.Text = "* to reserve your desired book\r\n you have just to submit the ID ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(389, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(446, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Tags";
            // 
            // subjectbox
            // 
            this.subjectbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.subjectbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.subjectbox.Checked = false;
            this.subjectbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.subjectbox.ForeColor = System.Drawing.Color.White;
            this.subjectbox.Location = new System.Drawing.Point(567, 40);
            this.subjectbox.Name = "subjectbox";
            this.subjectbox.Size = new System.Drawing.Size(20, 20);
            this.subjectbox.TabIndex = 72;
            this.subjectbox.OnChange += new System.EventHandler(this.subjectbox_OnChange);
            // 
            // writersbox
            // 
            this.writersbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.writersbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.writersbox.Checked = false;
            this.writersbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.writersbox.ForeColor = System.Drawing.Color.White;
            this.writersbox.Location = new System.Drawing.Point(487, 40);
            this.writersbox.Name = "writersbox";
            this.writersbox.Size = new System.Drawing.Size(20, 20);
            this.writersbox.TabIndex = 71;
            this.writersbox.OnChange += new System.EventHandler(this.writersbox_OnChange);
            // 
            // tagsbox
            // 
            this.tagsbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.tagsbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.tagsbox.Checked = false;
            this.tagsbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.tagsbox.ForeColor = System.Drawing.Color.White;
            this.tagsbox.Location = new System.Drawing.Point(425, 40);
            this.tagsbox.Name = "tagsbox";
            this.tagsbox.Size = new System.Drawing.Size(20, 20);
            this.tagsbox.TabIndex = 70;
            this.tagsbox.OnChange += new System.EventHandler(this.tagsbox_OnChange);
            // 
            // titlebox
            // 
            this.titlebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.titlebox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.titlebox.Checked = false;
            this.titlebox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.titlebox.ForeColor = System.Drawing.Color.White;
            this.titlebox.Location = new System.Drawing.Point(368, 40);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(20, 20);
            this.titlebox.TabIndex = 69;
            this.titlebox.OnChange += new System.EventHandler(this.titlebox_OnChange);
            // 
            // reserveID
            // 
            this.reserveID.BackColor = System.Drawing.SystemColors.Menu;
            this.reserveID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reserveID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(11)))), ((int)(((byte)(31)))));
            this.reserveID.HintForeColor = System.Drawing.Color.Black;
            this.reserveID.HintText = "";
            this.reserveID.isPassword = false;
            this.reserveID.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.reserveID.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.reserveID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.reserveID.LineThickness = 2;
            this.reserveID.Location = new System.Drawing.Point(132, 86);
            this.reserveID.Margin = new System.Windows.Forms.Padding(4);
            this.reserveID.Name = "reserveID";
            this.reserveID.Size = new System.Drawing.Size(202, 29);
            this.reserveID.TabIndex = 68;
            this.reserveID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(22, 91);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(97, 27);
            this.bunifuCustomLabel1.TabIndex = 67;
            this.bunifuCustomLabel1.Text = "Reserve:";
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.SystemColors.Menu;
            this.searchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(11)))), ((int)(((byte)(31)))));
            this.searchBar.HintForeColor = System.Drawing.Color.Black;
            this.searchBar.HintText = "";
            this.searchBar.isPassword = false;
            this.searchBar.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.searchBar.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.searchBar.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.searchBar.LineThickness = 2;
            this.searchBar.Location = new System.Drawing.Point(132, 30);
            this.searchBar.Margin = new System.Windows.Forms.Padding(4);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(202, 34);
            this.searchBar.TabIndex = 68;
            this.searchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(22, 40);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(92, 27);
            this.bunifuCustomLabel10.TabIndex = 67;
            this.bunifuCustomLabel10.Text = "Search :";
            // 
            // emailbox
            // 
            this.emailbox.BackColor = System.Drawing.SystemColors.Menu;
            this.emailbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(11)))), ((int)(((byte)(31)))));
            this.emailbox.HintForeColor = System.Drawing.Color.Black;
            this.emailbox.HintText = "";
            this.emailbox.isPassword = false;
            this.emailbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.emailbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.emailbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.emailbox.LineThickness = 2;
            this.emailbox.Location = new System.Drawing.Point(132, 137);
            this.emailbox.Margin = new System.Windows.Forms.Padding(4);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(202, 29);
            this.emailbox.TabIndex = 81;
            this.emailbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(22, 142);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(73, 27);
            this.bunifuCustomLabel2.TabIndex = 80;
            this.bunifuCustomLabel2.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(361, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 34);
            this.label6.TabIndex = 82;
            this.label6.Text = "*to get added to the Queue submit your \r\nemail then reserve a book\r\n";
            // 
            // ConsultWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ConsultWorks";
            this.Size = new System.Drawing.Size(787, 471);
            this.Load += new System.EventHandler(this.ConsultWorks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView searchResults;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCheckbox subjectbox;
        private Bunifu.Framework.UI.BunifuCheckbox writersbox;
        private Bunifu.Framework.UI.BunifuCheckbox tagsbox;
        private Bunifu.Framework.UI.BunifuCheckbox titlebox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchBar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox reserveID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader Writers;
        private System.Windows.Forms.ColumnHeader Tags;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Label label6;
    }
}
