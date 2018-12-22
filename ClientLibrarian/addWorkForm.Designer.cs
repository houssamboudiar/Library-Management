namespace ClientLibrarian
{
    partial class addWorkForm
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.tas = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.writ = new System.Windows.Forms.Label();
            this.memoire = new System.Windows.Forms.RadioButton();
            this.these = new System.Windows.Forms.RadioButton();
            this.livre = new System.Windows.Forms.RadioButton();
            this.title = new System.Windows.Forms.TextBox();
            this.writers = new System.Windows.Forms.TextBox();
            this.theme = new System.Windows.Forms.TextBox();
            this.tags = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tit
            // 
            this.tit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tit.Location = new System.Drawing.Point(267, 80);
            this.tit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tit.Name = "tit";
            this.tit.Size = new System.Drawing.Size(150, 28);
            this.tit.TabIndex = 0;
            this.tit.Text = "Title";
            this.tit.Click += new System.EventHandler(this.title_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // t
            // 
            this.t.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.t.Location = new System.Drawing.Point(267, 136);
            this.t.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(150, 28);
            this.t.TabIndex = 2;
            this.t.Text = "Theme";
            this.t.Click += new System.EventHandler(this.theme_Click);
            // 
            // tas
            // 
            this.tas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tas.Location = new System.Drawing.Point(267, 170);
            this.tas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tas.Name = "tas";
            this.tas.Size = new System.Drawing.Size(150, 28);
            this.tas.TabIndex = 3;
            this.tas.Text = "Tags";
            this.tas.Click += new System.EventHandler(this.tags_Click);
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.type.Location = new System.Drawing.Point(267, 199);
            this.type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(150, 28);
            this.type.TabIndex = 4;
            this.type.Text = "Type";
            this.type.Click += new System.EventHandler(this.type_Click);
            // 
            // writ
            // 
            this.writ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writ.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.writ.Location = new System.Drawing.Point(267, 108);
            this.writ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.writ.Name = "writ";
            this.writ.Size = new System.Drawing.Size(150, 28);
            this.writ.TabIndex = 5;
            this.writ.Text = "Writers";
            // 
            // memoire
            // 
            this.memoire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoire.Location = new System.Drawing.Point(480, 199);
            this.memoire.Margin = new System.Windows.Forms.Padding(4);
            this.memoire.Name = "memoire";
            this.memoire.Size = new System.Drawing.Size(156, 28);
            this.memoire.TabIndex = 6;
            this.memoire.TabStop = true;
            this.memoire.Text = "Mémoire";
            this.memoire.UseVisualStyleBackColor = true;
            // 
            // these
            // 
            this.these.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.these.Location = new System.Drawing.Point(480, 235);
            this.these.Margin = new System.Windows.Forms.Padding(4);
            this.these.Name = "these";
            this.these.Size = new System.Drawing.Size(156, 28);
            this.these.TabIndex = 7;
            this.these.TabStop = true;
            this.these.Text = "Thèse";
            this.these.UseVisualStyleBackColor = true;
            // 
            // livre
            // 
            this.livre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livre.Location = new System.Drawing.Point(480, 271);
            this.livre.Margin = new System.Windows.Forms.Padding(4);
            this.livre.Name = "livre";
            this.livre.Size = new System.Drawing.Size(156, 28);
            this.livre.TabIndex = 8;
            this.livre.TabStop = true;
            this.livre.Text = "Livre";
            this.livre.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(480, 86);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(293, 22);
            this.title.TabIndex = 9;
            // 
            // writers
            // 
            this.writers.Location = new System.Drawing.Point(480, 114);
            this.writers.Name = "writers";
            this.writers.Size = new System.Drawing.Size(293, 22);
            this.writers.TabIndex = 10;
            // 
            // theme
            // 
            this.theme.Location = new System.Drawing.Point(480, 142);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(293, 22);
            this.theme.TabIndex = 11;
            // 
            // tags
            // 
            this.tags.Location = new System.Drawing.Point(480, 170);
            this.tags.Name = "tags";
            this.tags.Size = new System.Drawing.Size(293, 22);
            this.tags.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "New Work";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add Work";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(480, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tags);
            this.Controls.Add(this.theme);
            this.Controls.Add(this.writers);
            this.Controls.Add(this.title);
            this.Controls.Add(this.livre);
            this.Controls.Add(this.these);
            this.Controls.Add(this.memoire);
            this.Controls.Add(this.writ);
            this.Controls.Add(this.type);
            this.Controls.Add(this.tas);
            this.Controls.Add(this.t);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "add Work";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label tas;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label writ;
        private System.Windows.Forms.RadioButton memoire;
        private System.Windows.Forms.RadioButton these;
        private System.Windows.Forms.RadioButton livre;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox writers;
        private System.Windows.Forms.TextBox theme;
        private System.Windows.Forms.TextBox tags;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

