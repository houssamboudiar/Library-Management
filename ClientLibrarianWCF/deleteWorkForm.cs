using IRemoteWCF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLibrarianWCF
{
    public partial class deleteWorkForm : Form
    {
        public deleteWorkForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ManageWorksClient manageWorks = new ManageWorksClient("NetTcpBinding_IManageWorks");
            try
            {
                int id = Convert.ToInt32(idwork.Text.ToString());
                
                /*if (manageWorks.DeleteWork(id))
                {
                    MessageBox.Show("successful");
                }
                else
                {
                    MessageBox.Show("failed");
                }*/
            }
            catch(Exception ex)
            {
                MessageBox.Show("invalide" +ex );
            }
            

        }

        private void idwork_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
