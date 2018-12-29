using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientBorrower.ClientServerLibraryClient;

namespace ClientBorrower
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        public event EventHandler LoggedIn;

        public void button1_Click(object sender, EventArgs e)
        {
            ClientClient clientService = new ClientClient("NetTcpBinding_IClient");
            string username = loginuserNametext.Text;
            string password = loginpasswordText.Text;

            if (username.Length <= 7)
            {
                MessageBox.Show("The username length should be greater than or equal to 8", "Warning");
                return;
            }

            if (password.Length <= 7)
            {
                MessageBox.Show("The password length should be greater than or equal to 8", "Warning");
                return;

            }

            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (username.Contains(item))
                {
                    MessageBox.Show("Contains username special char", "Warning");
                    return;
                }
            }

            foreach (var item in specialChar)
            {
                if (password.Contains(item))
                {
                    MessageBox.Show("Contains password special char", "Warning");
                    return;
                }
            }


            if (string.IsNullOrEmpty(username) | string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Provide User Name and Password !" , "Warning");
            }

            if(clientService.authenticateUser(username, password))
            {
                MessageBox.Show("Welcome "+ username +" !", "Sign-in");

                this.LoggedIn?.Invoke(username, e);
                loginuserNametext.Text = "";
                loginpasswordText.Text = "";
                usernametextbox.Text = "";
                idcardtextbox.Text = "";
                firstname.Text = "";
                signpassword.Text = "";
                signpasswordc.Text = "";
                lastName.Text = "";
                bunifuCheckbox2.Checked = false;
                bunifuCheckbox1.Checked = false;
            }
            else
            {
                MessageBox.Show("Please provide valide User Name and Password", "Warning");
            }
        }



        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void signusernametext_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientClient clientService = new ClientClient("NetTcpBinding_IClient");
            string specialChar = @"\|!#$%&/*()=?»«@£§€{}.-;'<>_,";

            string username = usernametextbox.Text;

            if (username.Length <= 7)
            {
                MessageBox.Show("The Username length should be greater than or equal to 8", "Warning");
                return;
            }

            foreach (var item in specialChar)
            {
                if (username.Contains(item))
                {
                    MessageBox.Show("Username Contains special char", "Warning");
                    return;
                }
            }

            if (clientService.getUser(username)!=null)
            {
                MessageBox.Show("Username already exists !", "Warning");
                return;
            }

            int id;
            if (!int.TryParse(idcardtextbox.Text, out id))
            {
                MessageBox.Show("ID should be a Number", "Warning");
                return;
            }

            if (clientService.getBorrower(id)!=null)
            {
                MessageBox.Show("Please make sure to use the right ID or contact the Library manager !", "Warning");
                return;
            }
            string fname = firstname.Text;
            string lname = lastName.Text;

            foreach (var item in specialChar)
            {
                if (fname.Contains(item))
                {
                    MessageBox.Show("First name Contains special char", "Warning");
                    return;
                }
            }

            foreach (var item in specialChar)
            {
                if (lname.Contains(item))
                {
                    MessageBox.Show("Last Name Contains special char", "Warning");
                    return;
                }
            }

            string password = signpassword.Text;
            if (password.Length <= 7)
            {
                MessageBox.Show("The password length should be greater than or equal to 8", "Warning");
                return;

            }

            foreach (var item in specialChar)
            {
                if (password.Contains(item))
                {
                    MessageBox.Show("Password Contains special char", "Warning");
                    return;
                }
            }

            string passwordc = signpasswordc.Text;

            if (!password.Equals(passwordc))
            {
                MessageBox.Show("Password does not match the confirmation", "Warning");
                return;
            }
            
            if (bunifuCheckbox2.Checked==false)
            {
                if(bunifuCheckbox1.Checked==false)
                {
                    MessageBox.Show("You must select a user type !", "Warning");
                    return;
                }
                else
                {
                    if(clientService.addUserTeacher(username,password,id,fname,lname,"Not Assigned"))
                    {
                        MessageBox.Show("Great you just registered ! you can Sign-in " + fname , "Sign-up");
                    }
                }
            }
            else
            {
                if(clientService.addUserStudent(username, password, id, fname, lname, "NotAssigned" , "NotAssigned"))
                {
                    MessageBox.Show("Great you just registered ! you can Sign-in " + fname, "Sign-up");
                }
            }
            loginuserNametext.Text = "";
            loginpasswordText.Text = "";
            usernametextbox.Text = "";
            idcardtextbox.Text = "";
            firstname.Text = "";
            signpassword.Text = "";
            signpasswordc.Text = "";
            lastName.Text = "";
            bunifuCheckbox2.Checked = false;
            bunifuCheckbox1.Checked = false;
        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            bunifuCheckbox1.Checked = false;
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            bunifuCheckbox2.Checked = false;
        }
    }
}
