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
            ClientClient clientService = new ClientClient("NetTcpBinding_IClient");
            if (user.Type == "Etudiant")
            {
                
                Student student = clientService.getStudentbyUser(user.UserName);
                profileStudentt1.Student = student;
                profileStudentt1.BringToFront();
            }
            else
            {
                //Teacher teacher = clientService.getTeacherByUser(user.UserName);
                //ProfileTeacher prflt = new ProfileTeacher(teacher);
                //prflt.BringToFront();
                username.Text = (string)sender + " : ";
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


        public static Account user;
        private void loggedIn(object sender, EventArgs e)
        {
            SidePanel.Height = profileButton.Height;
            SidePanel.Top = profileButton.Top;
            ClientClient clientService = new ClientClient("NetTcpBinding_IClient");
            user = clientService.getUser((string)sender);
            if ( user.Type == "Etudiant")
            {
                Student student = clientService.getStudentbyUser(user.UserName);
                profileStudentt1.fillProfileEventHandler(student);
                profileStudentt1.BringToFront();
                username.Text = (string)sender + " : " + student.Borrower.CardID1;
            }
            else
            {
                //profileTeacher1.BringToFront();
                //Teacher teacher = clientService.getTeacherByUser((string)sender);
                //username.Text = (string)sender + " : " + teacher.Borrower.CardID1;
                //this.fillprofile?.Invoke(user, e);
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
