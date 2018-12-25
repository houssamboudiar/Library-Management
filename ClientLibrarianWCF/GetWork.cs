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

namespace ClientLibrarian
{
    public partial class GetWork : Form
    {
        public GetWork()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ConsultWorksClient consultWorks = new ConsultWorksClient("NetTcpBinding_IConsultWorks");
            try
            {
                /*Work work = consultWorks.getById(Convert.ToInt32(idwork.Text.ToString()));
                this.Hide();
                EditWork editWork = new EditWork(work);
                editWork.Show();*/
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("failed");
            }

        }

        private void GetWork_Load(object sender, EventArgs e)
        {

        }
    }
}
