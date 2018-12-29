using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLibrarian
{
    public partial class ProfilLibrarian : Form
    {
        public ProfilLibrarian()
        {
            InitializeComponent();

            index.Height = button2.Height;
            index.Top = button2.Top;
            login1.BringToFront();
            AddWork.Enabled = false;
            EditWork.Enabled = false;
            DeleteWork.Enabled = false;
            ConfirmBooking.Enabled = false;
            ReturnWork.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void AddWork_Click(object sender, EventArgs e)
        {
            index.Height = AddWork.Height;
            index.Top = AddWork.Top;
            ajouterOuvrage1.BringToFront();
        }

        private void EditWork_Click(object sender, EventArgs e)
        {
            index.Height = EditWork.Height;
            index.Top = EditWork.Top;
            recupererOuvrage1.BringToFront();
            
        }

        private void DeleteWork_Click(object sender, EventArgs e)
        {
            index.Height = DeleteWork.Height;
            index.Top = DeleteWork.Top;
            supprimerOuvrage1.BringToFront();
        }

        private void ConfirmBooking_Click(object sender, EventArgs e)
        {
            index.Height = ConfirmBooking.Height;
            index.Top = ConfirmBooking.Top;
            confirmerReservation1.BringToFront();
        }

        private void ReturnWork_Click(object sender, EventArgs e)
        {
            index.Height = ReturnWork.Height;
            index.Top = ReturnWork.Top;
            rendreOuvrage1.BringToFront();
        }

        private void ProfilLibrarian_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            index.Height = button2.Height;
            index.Top = button2.Top;
            login1.BringToFront();
            AddWork.Enabled = false;
            EditWork.Enabled = false;
            DeleteWork.Enabled = false;
            ConfirmBooking.Enabled = false;
            ReturnWork.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = true;
        }


        private void get_Work1_Load(object sender, EventArgs e)
        {

        }

        private void confirmerReservation1_Load(object sender, EventArgs e)
        {

        }

        private void supprimerOuvrage1_Load(object sender, EventArgs e)
        {

        }

        private void get_Work1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        

        private void login1_Load(object sender, EventArgs e)
        {

        }

        private void Loggedin(object sender, EventArgs e)
        {
            AddWork.Enabled = true;
            EditWork.Enabled = true;
            DeleteWork.Enabled = true;
            ConfirmBooking.Enabled = true;
            ReturnWork.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
