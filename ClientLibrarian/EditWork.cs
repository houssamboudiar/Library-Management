using IRemote.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLibrarian
{
    public partial class EditWork : Form
    {
        private Work work;

        public EditWork(Work work)
        {
            InitializeComponent();
            this.work = work;
            title.Text = work.Title;
            writers.Text = String.Join(",",work.Writers);
            tags.Text = String.Join(",", work.Tags);
            theme.Text = work.Theme;
            if(work.Type == "memoire")
            {
                memoire.Checked = true;
            }
            else
            {
                if(work.Type == "these")
                {
                    these.Checked = true;
                }
                else
                {
                    livre.Checked = true;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EditWork_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
