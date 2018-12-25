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
            this.AddWork = new System.Windows.Forms.Button();
            this.EditWork = new System.Windows.Forms.Button();
            this.DeleteWork = new System.Windows.Forms.Button();
            this.ConfirmBooking = new System.Windows.Forms.Button();
            this.ReturnWork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddWork
            // 
            this.AddWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWork.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AddWork.Location = new System.Drawing.Point(160, 94);
            this.AddWork.Name = "AddWork";
            this.AddWork.Size = new System.Drawing.Size(156, 34);
            this.AddWork.TabIndex = 0;
            this.AddWork.Text = "New Work";
            this.AddWork.UseVisualStyleBackColor = true;
            this.AddWork.Click += new System.EventHandler(this.AddWork_Click);
            // 
            // EditWork
            // 
            this.EditWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditWork.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.EditWork.Location = new System.Drawing.Point(245, 148);
            this.EditWork.Name = "EditWork";
            this.EditWork.Size = new System.Drawing.Size(156, 34);
            this.EditWork.TabIndex = 1;
            this.EditWork.Text = "Edit Work";
            this.EditWork.UseVisualStyleBackColor = true;
            this.EditWork.Click += new System.EventHandler(this.EditWork_Click);
            // 
            // DeleteWork
            // 
            this.DeleteWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteWork.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DeleteWork.Location = new System.Drawing.Point(326, 207);
            this.DeleteWork.Name = "DeleteWork";
            this.DeleteWork.Size = new System.Drawing.Size(156, 34);
            this.DeleteWork.TabIndex = 2;
            this.DeleteWork.Text = "Delete Work";
            this.DeleteWork.UseVisualStyleBackColor = true;
            this.DeleteWork.Click += new System.EventHandler(this.DeleteWork_Click);
            // 
            // ConfirmBooking
            // 
            this.ConfirmBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBooking.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ConfirmBooking.Location = new System.Drawing.Point(407, 260);
            this.ConfirmBooking.Name = "ConfirmBooking";
            this.ConfirmBooking.Size = new System.Drawing.Size(156, 34);
            this.ConfirmBooking.TabIndex = 3;
            this.ConfirmBooking.Text = "Confirm Booking";
            this.ConfirmBooking.UseVisualStyleBackColor = true;
            this.ConfirmBooking.Click += new System.EventHandler(this.ConfirmBooking_Click);
            // 
            // ReturnWork
            // 
            this.ReturnWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnWork.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ReturnWork.Location = new System.Drawing.Point(486, 313);
            this.ReturnWork.Name = "ReturnWork";
            this.ReturnWork.Size = new System.Drawing.Size(156, 34);
            this.ReturnWork.TabIndex = 4;
            this.ReturnWork.Text = "Return Work";
            this.ReturnWork.UseVisualStyleBackColor = true;
            this.ReturnWork.Click += new System.EventHandler(this.ReturnWork_Click);
            // 
            // ProfilLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnWork);
            this.Controls.Add(this.ConfirmBooking);
            this.Controls.Add(this.DeleteWork);
            this.Controls.Add(this.EditWork);
            this.Controls.Add(this.AddWork);
            this.Name = "ProfilLibrarian";
            this.Text = "ProfilLibrarian";
            this.Load += new System.EventHandler(this.ProfilLibrarian_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddWork;
        private System.Windows.Forms.Button EditWork;
        private System.Windows.Forms.Button DeleteWork;
        private System.Windows.Forms.Button ConfirmBooking;
        private System.Windows.Forms.Button ReturnWork;
    }
}