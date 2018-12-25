using ClassLibrary1;
using IRemote;
using IRemote.Models;
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
            ILibrarian C = (ILibrarian)Activator.GetObject(typeof(ILibrarian), "tcp://localhost:1234/Obj");
            try
            {
                Work work = C.getById(Convert.ToInt32(idwork.Text.ToString()));
                this.Hide();
                EditWork editWork = new EditWork(work);
                editWork.Show();
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
