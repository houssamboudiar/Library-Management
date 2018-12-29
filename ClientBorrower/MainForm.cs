using ClientBorrower.ClientServerLibraryClient;
using ClientBorrower.Properties;
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
        public Account user;



        public MainForm()
        {
            InitializeComponent();
            gradient.GradientBottomLeft = Color.FromArgb(47, 128, 237);
            gradient.GradientBottomRight = Color.FromArgb(55, 217, 191);
            gradient.GradientTopRight = Color.FromArgb(55, 217, 191);
            gradient.GradientTopLeft = Color.FromArgb(55, 217, 191);
            welcome.Visible = false;
            username.Visible = false;
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
            gradient.GradientBottomLeft = Color.FromArgb(47, 128, 237);
            gradient.GradientBottomRight = Color.FromArgb(55, 217, 191);
            gradient.GradientTopRight = Color.FromArgb(55, 217, 191);
            gradient.GradientTopLeft = Color.FromArgb(55, 217, 191);
            welcome.Visible = false;
            username.Visible = false;
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
                profileStudentt1.fillProfileEventHandler(student);
                gradient.GradientBottomLeft = Color.FromArgb(32, 87, 101);
                gradient.GradientBottomRight = Color.FromArgb(32, 87, 101);
                gradient.GradientTopRight = Color.FromArgb(32, 87, 101);
                gradient.GradientTopLeft = Color.FromArgb(32, 87, 101);
                welcome.Visible = true;
                username.Visible = true;
                profileStudentt1.BringToFront();
            }
            else
            {
                Teacher teacher = clientService.getTeacherByUser(user.UserName);
                profileTeacher1.fillProfileEventHandler(teacher);
                gradient.GradientBottomLeft = Color.FromArgb(32, 87, 101);
                gradient.GradientBottomRight = Color.FromArgb(32, 87, 101);
                gradient.GradientTopRight = Color.FromArgb(32, 87, 101);
                gradient.GradientTopLeft = Color.FromArgb(32, 87, 101);
                welcome.Visible = true;
                username.Visible = true;
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
            ClientClient clientService = new ClientClient("NetTcpBinding_IClient");

            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            gradient.GradientBottomLeft = Color.FromArgb(32, 87, 101);
            gradient.GradientBottomRight = Color.FromArgb(32, 87, 101);
            gradient.GradientTopRight = Color.FromArgb(32, 87, 101);
            gradient.GradientTopLeft = Color.FromArgb(32, 87, 101);
            welcome.Visible = true;
            username.Visible = true;
            if (user.Type == "Etudiant")
            {
                Borrower Borrowerr = clientService.getStudentbyUser(user.UserName).Borrower;
                consultWorks1.setBorrower(Borrowerr);
            }
            else
            {
                Borrower Borrowerr = clientService.getTeacherByUser(user.UserName).Borrower;
                consultWorks1.setBorrower(Borrowerr);
            }

            consultWorks1.BringToFront();
            
        }

        private void consultWorks1_Load(object sender, EventArgs e)
        {

        }


        private void loggedIn(object sender, EventArgs e)
        {

            ClientClient clientService = new ClientClient("NetTcpBinding_IClient");
            user = clientService.getUser((string)sender);
            if ( user.Type == "Etudiant")
            {
                Student student = clientService.getStudentbyUser(user.UserName);
                profileStudentt1.fillProfileEventHandler(student);
                username.Text = (string)sender+" : "+student.Borrower.CardID1;

                if (string.IsNullOrEmpty(student.Specialty) | string.IsNullOrEmpty(student.Level))
                {
                   MessageBox.Show("Please fill your profile !", "Warning");
                    SidePanel.Height = profileButton.Height;
                    SidePanel.Top = profileButton.Top;
                    gradient.GradientBottomLeft = Color.FromArgb(32, 87, 101);
                    gradient.GradientBottomRight = Color.FromArgb(32, 87, 101);
                    gradient.GradientTopRight = Color.FromArgb(32, 87, 101);
                    gradient.GradientTopLeft = Color.FromArgb(32, 87, 101);
                    welcome.Visible = true;
                    username.Visible = true;
                    profileStudentt1.BringToFront();
                }
                else
                {
                    SidePanel.Height = button1.Height;
                    SidePanel.Top = button1.Top;
                    gradient.GradientBottomLeft = Color.FromArgb(32, 87, 101);
                    gradient.GradientBottomRight = Color.FromArgb(32, 87, 101);
                    gradient.GradientTopRight = Color.FromArgb(32, 87, 101);
                    gradient.GradientTopLeft = Color.FromArgb(32, 87, 101);
                    welcome.Visible = true;
                    username.Visible = true;

                    if (user.Type == "Etudiant")
                    {
                        Borrower Borrowerr = clientService.getStudentbyUser(user.UserName).Borrower;
                        consultWorks1.setBorrower(Borrowerr);
                    }
                    else
                    {
                        Borrower Borrowerr = clientService.getTeacherByUser(user.UserName).Borrower;
                        consultWorks1.setBorrower(Borrowerr);
                    }

                    consultWorks1.BringToFront();
                }
            }
            else
            {
                Teacher teacher = clientService.getTeacherByUser(user.UserName);
                profileTeacher1.fillProfileEventHandler(teacher);
                username.Text = (string)sender + " : " + teacher.Borrower.CardID1;

                if (string.IsNullOrEmpty(teacher.Grade))
                {
                    SidePanel.Height = profileButton.Height;
                    SidePanel.Top = profileButton.Top;
                    gradient.GradientBottomLeft = Color.FromArgb(32, 87, 101);
                    gradient.GradientBottomRight = Color.FromArgb(32, 87, 101);
                    gradient.GradientTopRight = Color.FromArgb(32, 87, 101);
                    gradient.GradientTopLeft = Color.FromArgb(32, 87, 101);
                    welcome.Visible = true;
                    username.Visible = true;
                    profileTeacher1.BringToFront();
                    MessageBox.Show("Please fill your profile !", "Warning");
                }
                else
                {
                    SidePanel.Height = button1.Height;
                    SidePanel.Top = button1.Top;
                    gradient.GradientBottomLeft = Color.FromArgb(32, 87, 101);
                    gradient.GradientBottomRight = Color.FromArgb(32, 87, 101);
                    gradient.GradientTopRight = Color.FromArgb(32, 87, 101);
                    gradient.GradientTopLeft = Color.FromArgb(32, 87, 101);
                    welcome.Visible = true;
                    username.Visible = true;

                    if (user.Type == "Etudiant")
                    {
                        Borrower Borrowerr = clientService.getStudentbyUser(user.UserName).Borrower;
                        consultWorks1.setBorrower(Borrowerr);
                    }
                    else
                    {
                        Borrower Borrowerr = clientService.getTeacherByUser(user.UserName).Borrower;
                        consultWorks1.setBorrower(Borrowerr);
                    }

                    consultWorks1.BringToFront();
                }

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
            gradient.GradientBottomLeft = Color.FromArgb(47, 128, 237);
            gradient.GradientBottomRight = Color.FromArgb(55, 217, 191);
            gradient.GradientTopRight = Color.FromArgb(55, 217, 191);
            gradient.GradientTopLeft = Color.FromArgb(55, 217, 191);
            welcome.Visible = false;
            username.Visible = false;
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





        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Close();

        }

        private void nofknhover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }

        private void wtf(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }

        private void consultWorks1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
