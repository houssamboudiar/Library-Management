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
                MessageBox.Show("The username length should be greater than or equal to 8");
                return;
            }

            if (password.Length <= 7)
            {
                MessageBox.Show("The password length should be greater than or equal to 8");
                return;

            }

            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (username.Contains(item))
                {
                    MessageBox.Show("Contains username special char");
                    return;
                }
            }

            foreach (var item in specialChar)
            {
                if (password.Contains(item))
                {
                    MessageBox.Show("Contains password special char");
                    return;
                }
            }


            if (string.IsNullOrEmpty(username) | string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Provide User Name and Password !");
            }

            if(clientService.authenticateUser(username, password))
            {
                MessageBox.Show("Logged in "+ username +" !");

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
                MessageBox.Show("Please provide valide User Name and Password");
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
                MessageBox.Show("The Username length should be greater than or equal to 8");
                return;
            }

            foreach (var item in specialChar)
            {
                if (username.Contains(item))
                {
                    MessageBox.Show("Username Contains special char");
                    return;
                }
            }

            int id;
            if (!int.TryParse(idcardtextbox.Text, out id))
            {
                MessageBox.Show("ID should be a Number");
                return;
            }

            string fname = firstname.Text;
            string lname = lastName.Text;

            foreach (var item in specialChar)
            {
                if (fname.Contains(item))
                {
                    MessageBox.Show("First name Contains special char");
                    return;
                }
            }

            foreach (var item in specialChar)
            {
                if (lname.Contains(item))
                {
                    MessageBox.Show("Last Name Contains special char");
                    return;
                }
            }

            string password = signpassword.Text;
            if (password.Length <= 7)
            {
                MessageBox.Show("The password length should be greater than or equal to 8");
                return;

            }

            foreach (var item in specialChar)
            {
                if (password.Contains(item))
                {
                    MessageBox.Show("Password Contains special char");
                    return;
                }
            }

            string passwordc = signpasswordc.Text;

            if (!password.Equals(passwordc))
            {
                MessageBox.Show("Password does not match the confirmation");
                return;
            }
            
            if (bunifuCheckbox2.Checked==false)
            {
                if(bunifuCheckbox1.Checked==false)
                {
                    MessageBox.Show("You must select a user type !");
                    return;
                }
                else
                {
                    if(clientService.addUserTeacher(username,password,id,fname,lname,"Not Assigned"))
                    {
                        MessageBox.Show("Great you just registered ! you can Sign-in " + fname);
                    }
                }
            }
            else
            {
                if(clientService.addUserStudent(username, password, id, fname, lname, "NotAssigned" , "NotAssigned"))
                {
                    MessageBox.Show("Great you just registered ! you can Sign-in " + fname);
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
