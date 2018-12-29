using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IRemoteWCF.Models;
using ClientLibrarianWCF.LibrarianServerLibrary;

namespace ClientLibrarianWCF
{
    public partial class RecupererOuvrage : UserControl
    {
        Work work;
        public RecupererOuvrage()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LibrarianClient librarianClient = new LibrarianClient("BasicHttpBinding_ILibrarian");
            if (idWork.Value != 0)
            {
                int idW = Convert.ToInt32(idWork.Text.ToString());
                this.work = librarianClient.getById(Convert.ToInt32(idWork.Value));
                if (work != null)
                {
                    title.Text = work.Title;
                    theme.Text = work.Theme;
                    writers.Text = String.Join(",", work.Writers.ToList());
                    tags.Text = String.Join(",", work.Tags.ToList());
                    if (work.Type == "Mémoires")
                    {
                        memoire.Checked = true;
                    }
                    else
                    {
                        if (work.Type == "Livre")
                        {
                            livre.Checked = true;
                        }
                        else
                        {
                            these.Checked = true;
                        }
                    }
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    label7.Visible = false;
                    idWork.Visible = false;
                    panel5.Visible = false;
                    button2.Visible = false;
                    button1.Visible = true;
                    title.Visible = true;
                    writers.Visible = true;
                    tags.Visible = true;
                    theme.Visible = true;
                    these.Visible = true;
                    memoire.Visible = true;
                    these.Visible = true;
                    livre.Visible = true;
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    panel4.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    
                }
                else
                {
                    MessageBox.Show("work was not find");
                }
            }
            else
            {
                MessageBox.Show("unacceptable value");
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibrarianClient librarianClient = new LibrarianClient("BasicHttpBinding_ILibrarian");
            String type;
            if (memoire.Checked)
            {
                type = "Mémoires";
            }
            else
            {
                if (livre.Checked)
                {
                    type = "Livre";
                }
                else
                {
                    type = "Thèses";
                }
            }
            Boolean b = librarianClient.EditWork(work.IdWork, tags.Text.Split(',').ToList(), writers.Text.Split(',').ToList(), title.Text.ToString(), theme.Text.ToString(), type);
            if (b)
            {
                MessageBox.Show("work has been  modified");
                idWork.Value = 0;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                label7.Visible = true;
                idWork.Visible = true;
                panel5.Visible = true;
                button2.Visible = true;
                button1.Visible = false;
                title.Visible = false;
                writers.Visible = false;
                tags.Visible = false;
                theme.Visible = false;
                these.Visible = false;
                memoire.Visible = false;
                these.Visible = false;
                livre.Visible = false;
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }
            else
            {
                MessageBox.Show("work has not been  modified");
            }
            
        }
    }
}
