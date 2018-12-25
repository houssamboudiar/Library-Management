using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLibrarian
{
    public partial class ProfilLibrarian : Form
    {
        /*public ProfilLibrarian()
        {
            InitializeComponent();
            TcpChannel cnl = new TcpChannel();
            ChannelServices.RegisterChannel(cnl, false);
        }*/

        private void AddWork_Click(object sender, EventArgs e)
        {
            NewWork newWork = new NewWork();
            newWork.Show();
        }

        private void EditWork_Click(object sender, EventArgs e)
        {
            GetWork getWork = new GetWork();
            getWork.Show();
        }

        private void DeleteWork_Click(object sender, EventArgs e)
        {
            DeleteWork deleteWork = new DeleteWork();
            deleteWork.Show();
        }

        private void ConfirmBooking_Click(object sender, EventArgs e)
        {

        }

        private void ReturnWork_Click(object sender, EventArgs e)
        {

        }

        private void ProfilLibrarian_Load(object sender, EventArgs e)
        {

        }
    }
}
