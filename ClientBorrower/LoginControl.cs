using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientBorrower.ClientServerLibraryService;

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

        private void button1_Click(object sender, EventArgs e)
        {
            ClientClient clientService = new ClientClient("NetTcpBinding_IClient");
            string username = loginuserNametext.Text;
            string password = loginpasswordText.Text;
            clientService.authenticateUser(username , password);
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
            string username = usernametextbox.Text;
            string id = idcardtextbox.Text;
            string fname = firstname.Text;
            string lname = lastName.Text;
            string password = signpassword.Text;
            string passwordc = signpasswordc.Text;
            string type = "Etudiant";
            if (bunifuCheckbox1.Checked && !bunifuCheckbox2.Checked)
            {
                type = "Etudiant";
            }
            else
            {
                type = "Enseignant";
            }

            //clientService.addUserStudent();
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
