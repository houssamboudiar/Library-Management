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
    public partial class RendreOuvrage : UserControl
    {
        public RendreOuvrage()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            LibrarianClient librarianClient = new LibrarianClient("BasicHttpBinding_ILibrarian");
            if (idWork.Value != 0 && idBorrower.Value != 0)
            {

                Boolean b = librarianClient.returnWork(Convert.ToInt32(idWork.Value), Convert.ToInt32(idBorrower.Value));
                if (b)
                {
                    
                    MessageBox.Show("return work has been confirmed");
                    idWork.Value = 0;
                    idBorrower.Value = 0;
                }
                else
                {
                    MessageBox.Show("return work has not been confirmed");
                }
            }
            else
            {
                MessageBox.Show("unacceptable value");
            }
        }
    }
}
