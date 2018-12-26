using ClientBorrower.ClientServerLibraryClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientBorrower
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SidePanel.Height = loginButton.Height;
            SidePanel.Top = loginButton.Top;
            loginControl1.BringToFront();
            button3.Enabled = false;
            profileButton.Enabled = false;
            button1.Enabled = false;


        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = loginButton.Height;
            SidePanel.Top = loginButton.Top;
            loginControl1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = profileButton.Height;

            SidePanel.Top = profileButton.Top;
            String usertype = "Student";
            if(usertype == "Student")
            {
                profileStudent1.BringToFront();
            }
            else
            {
                profileTeacher1.BringToFront();
            }
        }

        private void profile1_Load(object sender, EventArgs e)
        {

        }

        private void loginControl1_Load(object sender, EventArgs e)
        {

        }

        private void loginControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            consultWorks1.BringToFront();
            
        }

        private void consultWorks1_Load(object sender, EventArgs e)
        {

        }

        private void loggedIn(object sender, EventArgs e)
        {
            username.Text = (string)sender;
            SidePanel.Height = profileButton.Height;
            SidePanel.Top = profileButton.Top;
            String usertype = "Student";
            if (usertype == "Student")
            {
                profileStudent1.BringToFront();
            }
            else
            {
                profileTeacher1.BringToFront();
            }
            loginButton.Enabled = false;
            button3.Enabled = true;
            profileButton.Enabled = true;
            button1.Enabled = true;
            }

        private void button3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientClient clientService = new ClientClient("NetTcpBinding_IClient");
            clientService.signout();
            username.Text = "Learner";
            SidePanel.Height = loginButton.Height;
            SidePanel.Top = loginButton.Top;
            loginControl1.BringToFront();
            button3.Enabled = false;
            profileButton.Enabled = false;
            button1.Enabled = false;

        }

        private void loginControl1_Load_2(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
