using IRemote;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLibrarian
{
    public partial class deleteWorkForm : Form
    {
        public deleteWorkForm()
        {
            InitializeComponent();
            TcpChannel cnl = new TcpChannel();
            ChannelServices.RegisterChannel(cnl, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            IManageWorks C = (IManageWorks)Activator.GetObject(typeof(IManageWorks), "tcp://localhost:1234/Obj");
            try
            {
                int id = Convert.ToInt32(idwork.Text.ToString());
                
                if (C.DeleteWork(id))
                {
                    MessageBox.Show("successful");
                }
                else
                {
                    MessageBox.Show("failed");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("invalide" +ex );
            }
            

        }
    }
}
