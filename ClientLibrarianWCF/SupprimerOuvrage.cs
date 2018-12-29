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
    public partial class SupprimerOuvrage : UserControl
    {
        public SupprimerOuvrage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibrarianClient librarianClient = new LibrarianClient("BasicHttpBinding_ILibrarian");
          
            if(idWork.Value != 0)
            {
                int idW = Convert.ToInt32(idWork.Text.ToString());
                Boolean b = librarianClient.DeleteWork(Convert.ToInt32(idWork.Value));
                if (b)
                {
                    MessageBox.Show("work was deleted");
                    idWork.Value = 0;
                }
                else
                {
                    MessageBox.Show("work was not deleted");
                }
            }
            else
            {
                MessageBox.Show("unacceptable value");
            }
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
