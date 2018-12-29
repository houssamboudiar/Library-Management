using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientLibrarianWCF.LibrarianServerLibrary;

namespace ClientLibrarianWCF
{
    public partial class AjouterOuvrage : UserControl
    {
        public AjouterOuvrage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibrarianClient clientLibrarian = new LibrarianClient("BasicHttpBinding_ILibrarian");
            string type;
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
            
            Boolean b = clientLibrarian.AddWork(tags.Text.Split(',').ToList(), writers.Text.Split(',').ToList(), title.Text.ToString(), theme.Text.ToString(), type);
            if (b)
            {
                MessageBox.Show("the work has been added");
            }
            else
            {
                MessageBox.Show("the book has not been added");
            }
        }
    }
}
