using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientLibrarianWCF.LibrarianServerLibrary;

namespace ClientLibrarianWCF
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public event EventHandler LoggedIn;
        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            LibrarianClient clientService = new LibrarianClient("BasicHttpBinding_ILibrarian");
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

            if (clientService.authenticateUser(username, password))
            {
                MessageBox.Show("Logged in" + username + "!");
                this.LoggedIn?.Invoke(username, e);
            }
            else
            {
                MessageBox.Show("Please provide valide User Name and Password");
            }
        }
    }
}
