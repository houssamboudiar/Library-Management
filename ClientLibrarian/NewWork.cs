using ClassLibrary1;
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
    public partial class NewWork : Form
    {
        public NewWork()
        {
            InitializeComponent();
            
            //Console.WriteLine("Client : Cannel Enregistre...");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void tags_Click(object sender, EventArgs e)
        {

        }

        private void type_Click(object sender, EventArgs e)
        {

        }

        private void theme_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ILibrarian C = (ILibrarian)Activator.GetObject(typeof(ILibrarian), "tcp://localhost:1234/Obj");
            string type;
            if (memoire.Checked)
            {
                type = "memoire";
            }
            else
            {
                if (these.Checked)
                {
                    type = "these";
                }
                else
                {
                    type = "livre";
                }
            }

            Boolean b = C.AddWork(tags.Text.Split(',').ToList(), writers.Text.Split(',').ToList(), title.Text.ToString(), theme.Text.ToString(),type);
            if (b)
            {
                MessageBox.Show("successfull");
            }
            else
            {
                MessageBox.Show("failed");
            }
            
        }
    }
}
