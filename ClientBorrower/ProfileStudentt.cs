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
    public partial class ProfileStudentt : UserControl
    {
        private Student student = null;

        public Student Student { get => student; set => student = value; }

        public ProfileStudentt()
        {
            InitializeComponent();
        }


        public void fillProfileEventHandler(Student student)
        {
            Student = student;
            lname.Text = student.Borrower.LastName;
            Specialty.Text = student.Specialty;
            cardid.Text = student.Borrower.CardID1.ToString();
            fname.Text = student.Borrower.FirstName;
            level.Text = student.Level;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lname.Enabled = !lname.Enabled;
            Specialty.Enabled = !Specialty.Enabled;
            //cardid.Enabled = !cardid.Enabled;
            fname.Enabled = !fname.Enabled;
            level.Enabled = !level.Enabled;
            bunifuMaterialTextbox8.Enabled = !bunifuMaterialTextbox8.Enabled;
            bunifuMaterialTextbox9.Enabled = !bunifuMaterialTextbox9.Enabled;
            button1.Enabled = !button1.Enabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientClient clientService = new ClientClient("NetTcpBinding_IClient");
            //clientService.getStudent
            string username = bunifuMaterialTextbox9.Text;
            string password = bunifuMaterialTextbox8.Text;

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

            if (clientService.authenticateUser(username, password) && username == student.Borrower.Account.UserName && password == student.Borrower.Account.PassWord)
            {
                MessageBox.Show(" Authentificated " + username + " !");
                string laname =lname.Text;
                string spec = Specialty.Text;
                int id;
                if (!int.TryParse(cardid.Text, out id))
                {
                    MessageBox.Show("ID should be a Number");
                    return;
                }

                if (clientService.getBorrower(id) != null)
                {
                    if (clientService.getBorrower(id).CardID1 == student.Borrower.CardID1)
                    {
                        string fn = fname.Text;
                        string lev = level.Text;

                        foreach (var item in specialChar)
                        {
                            if (fn.Contains(item))
                            {
                                MessageBox.Show("First name Contains special char");
                                return;
                            }
                        }

                        foreach (var item in specialChar)
                        {
                            if (lev.Contains(item))
                            {
                                MessageBox.Show("Last Name Contains special char");
                                return;
                            }
                        }
                        clientService.modifyUserStudent(username, password, id, fn, laname, spec, lev);
                        MessageBox.Show("Edited successfully");
                        return;
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
                    string lev = level.Text;

                    foreach (var item in specialChar)
                    {
                        if (fn.Contains(item))
                        {
                            MessageBox.Show("First name Contains special char");
                            return;
                        }
                    }

                    foreach (var item in specialChar)
                    {
                        if (lev.Contains(item))
                        {
                            MessageBox.Show("Last Name Contains special char");
                            return;
                        }
                    }
                    clientService.modifyUserStudent(username, password, id, fn, laname, spec, lev);
                    MessageBox.Show("Edited successfully");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please provide valide User Name and Password");
            }
        }
    }
}
