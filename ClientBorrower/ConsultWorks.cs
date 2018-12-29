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
using System.Globalization;

namespace ClientBorrower
{
    public partial class ConsultWorks : UserControl
    {
        private Borrower borrower = null;

        public Borrower Borrower { get => borrower; set => borrower = value; }

        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        List<Work> AllResults = new List<Work>();

        public ConsultWorks()
        {
            InitializeComponent();

            /*if (this.DesignMode == false)
            {
                ClientClient clientService = new ClientClient("NetTcpBinding_IClient");
                List<Work> Subjects = clientService.getAllWorks();
                AllResults.AddRange(Subjects);

                foreach (Work work in AllResults.Distinct().ToList())
                {
                    ListViewItem res = new ListViewItem(work.IdWork.ToString());
                    res.SubItems.Add(textInfo.ToTitleCase(work.Title));
                    res.SubItems.Add(textInfo.ToTitleCase(work.Type));
                    res.SubItems.Add(textInfo.ToTitleCase(work.Theme));
                    var tagsString = String.Join(", ", work.Tags.ToArray());
                    var writersString = String.Join(", ", work.Writers.ToArray());
                    res.SubItems.Add(textInfo.ToTitleCase(writersString));
                    res.SubItems.Add(textInfo.ToTitleCase(tagsString));
                    searchResults.Items.Add(res);
                }
            }*/
        }

        public void setBorrower(Borrower borrower)
        {
            Borrower = borrower;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ConsultWorks_Load(object sender, EventArgs e)
        {

        }

        private void titlebox_OnChange(object sender, EventArgs e)
        {

        }

        private void tagsbox_OnChange(object sender, EventArgs e)
        {

        }

        private void writersbox_OnChange(object sender, EventArgs e)
        {

        }

        private void subjectbox_OnChange(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientClient clientService = new ClientClient("NetTcpBinding_IClient");
            searchResults.Items.Clear();
            string searchquery = searchBar.Text.ToLower();
            List<Work> Result = new List<Work>();

            if (titlebox.Checked)
            {
                List<Work> titles = clientService.getByTitle(searchquery);
                Result.AddRange(titles);
            }

            if (tagsbox.Checked)
            {
                List<Work> Tags = clientService.getByTags(searchquery);
                Result.AddRange(Tags);
            }

            if (writersbox.Checked)
            {
                List<Work> Writers = clientService.getByWriter(searchquery);
                Result.AddRange(Writers);
            }

            if (subjectbox.Checked)
            {
                List<Work> Subjects = clientService.getByTheme(searchquery);
                Result.AddRange(Subjects);
            }

            if((Result.Count == 0) && (searchquery == "") && (titlebox.Checked == false) && (tagsbox.Checked == false) && (writersbox.Checked == false) && (subjectbox.Checked == false))
            {
                AllResults = clientService.getAllWorks();

                foreach (Work work in AllResults.Distinct().ToList())
                {
                    ListViewItem res = new ListViewItem(work.IdWork.ToString());
                    res.SubItems.Add(textInfo.ToTitleCase(work.Title));
                    res.SubItems.Add(textInfo.ToTitleCase(work.Type));
                    res.SubItems.Add(textInfo.ToTitleCase(work.Theme));
                    var tagsString = String.Join(", ", work.Tags.ToArray());
                    var writersString = String.Join(", ", work.Writers.ToArray());
                    res.SubItems.Add(textInfo.ToTitleCase(writersString));
                    res.SubItems.Add(textInfo.ToTitleCase(tagsString));
                    searchResults.Items.Add(res);
                }
            }

            foreach (Work work in Result.Distinct().ToList())
            {
                ListViewItem res = new ListViewItem(work.IdWork.ToString());
                res.SubItems.Add(textInfo.ToTitleCase(work.Title));
                res.SubItems.Add(textInfo.ToTitleCase(work.Type));
                res.SubItems.Add(textInfo.ToTitleCase(work.Theme));
                var tagsString = String.Join(", ", work.Tags.ToArray());
                var writersString = String.Join(", ", work.Writers.ToArray());
                res.SubItems.Add(textInfo.ToTitleCase(writersString));
                res.SubItems.Add(textInfo.ToTitleCase(tagsString));
                searchResults.Items.Add(res);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idwork;


            if (!int.TryParse(reserveID.Text, out idwork))
            {
                MessageBox.Show("ID should be a Number", "Warning");
                return;
            }

            ClientClient clientService = new ClientClient("NetTcpBinding_IClient");

            if (clientService.isBanned(Borrower.CardID1))
            {
                MessageBox.Show("Sorry you are banned ! \n You can't reserve more than 3 Works without Confirmation", "Warning");
                return;
            }

            if (clientService.isBorrowed(idwork))
            {
                MessageBox.Show("Sorry this Work is already Borrowed ! \n it will be returned after 15 days max", "Warning");
                return;
            }

            if (clientService.isReserved(idwork))
            {
                MessageBox.Show("Sorry this Work is reserved by other user ! \n Try again after 24 hours they might not grab it from the library", "Warning");
                DialogResult dialogResult = MessageBox.Show("Do you want to be added to a queue \nand get notified when that book get cleared", "Notification", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string email = emailbox.Text;
                    try
                    {
                        var addr = new System.Net.Mail.MailAddress(email);
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid Email !", "Warning");
                        return;
                    }

                    clientService.addList(idwork, Borrower.CardID1 , email);
                    MessageBox.Show("We will make sure to notify you ^^ !", "Success");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }

                return;
            }

            if(clientService.reserveWork( Borrower.CardID1 , idwork))
            {
                MessageBox.Show("Great you just reserved a book ! \n You just hve to confirm that by visiting the library tomorrow", "Warning");
            }
        }
    }
}
