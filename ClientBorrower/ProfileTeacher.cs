using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientBorrower
{
    public partial class ProfileTeacher : UserControl
    {
        public ProfileTeacher()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Enabled = !bunifuMaterialTextbox1.Enabled;
            bunifuMaterialTextbox2.Enabled = !bunifuMaterialTextbox2.Enabled;
            bunifuMaterialTextbox3.Enabled = !bunifuMaterialTextbox3.Enabled;
            bunifuMaterialTextbox5.Enabled = !bunifuMaterialTextbox5.Enabled;
            bunifuMaterialTextbox6.Enabled = !bunifuMaterialTextbox6.Enabled;
            bunifuMaterialTextbox7.Enabled = !bunifuMaterialTextbox7.Enabled;
            bunifuMaterialTextbox8.Enabled = !bunifuMaterialTextbox8.Enabled;
            bunifuMaterialTextbox9.Enabled = !bunifuMaterialTextbox9.Enabled;
        }
    }
}
