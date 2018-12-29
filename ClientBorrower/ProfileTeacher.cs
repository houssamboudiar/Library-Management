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
    public partial class ProfileTeacher : UserControl
    {
        private Teacher teacher = null;

        public Teacher Teacher { get => teacher; set => teacher = value; }

        public ProfileTeacher()
        {
            InitializeComponent();
        }

        public void fillProfileEventHandler(Teacher teacher)
        {
            Teacher = teacher;
            lname.Text = teacher.Borrower.LastName;
            idc.Text = teacher.Borrower.CardID1.ToString();
            fname.Text = teacher.Borrower.FirstName;
            grade.Text = teacher.Grade;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            grade.Enabled = !grade.Enabled;
            lname.Enabled = !lname.Enabled;
            fname.Enabled = !fname.Enabled;
            idc.Enabled = !idc.Enabled;
            passw.Enabled = !passw.Enabled;
            usern.Enabled = !usern.Enabled;
            button1.Enabled = !button1.Enabled;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ClientClient clientService = new ClientClient("NetTcpBinding_IClient");
            string username = usern.Text;
            string password = passw.Text;

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

            if (clientService.authenticateUser(username, password) && username == teacher.Borrower.Account.UserName && password == teacher.Borrower.Account.PassWord)
            {
                MessageBox.Show(" Authentificated " + username + " !");
                string laname = lname.Text;
                string grad = grade.Text;
                int id;
                if (!int.TryParse(idc.Text, out id))
                {
                    MessageBox.Show("ID should be a Number");
                    return;
                }

                if (clientService.getBorrower(id) != null)
                {
                    if (clientService.getBorrower(id).CardID1 == teacher.Borrower.CardID1)
                    {
                        string fn = fname.Text;

                        foreach (var item in specialChar)
                        {
                            if (fn.Contains(item))
                            {
                                MessageBox.Show("First name Contains special char");
                                return;
                            }
                        }

                        if (clientService.modifyUserTeacher(username, password, id, fn, laname, grad))
                        {
                            MessageBox.Show("Edited successfully");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong !");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please make sure to use the right ID or contact the Library manager !");
                        return;
                    }
                }
                else
                {
                    string fn = fname.Text;

                    foreach (var item in specialChar)
                    {
                        if (fn.Contains(item))
                        {
                            MessageBox.Show("First name Contains special char");
                            return;
                        }
                    }
                    if (clientService.modifyUserTeacher(username, password, id, fn, laname, grad))
                    {
                        MessageBox.Show("Edited successfully");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Use your account :) !");
            }
        }
    }
}
