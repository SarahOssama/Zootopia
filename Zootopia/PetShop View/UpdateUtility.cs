using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zootopia
{
    public partial class UpdateUtility : Form
    {
        Controller ControllerObj;
        public string PSUsername = "";

        public UpdateUtility(string Username)
        {
            InitializeComponent();
            PSUsername = Username;

            ControllerObj = new Controller();
            DataTable dt = ControllerObj.SelectUtilityName(PSUsername);
            comboBoxUname.DataSource = dt;
            comboBoxUname.DisplayMember = "UName";
        }

        private void buttonCloseUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int result = ControllerObj.UpdateUtility(comboBox1.Text, textBox1.Text, comboBoxUname.Text);
            if (result == 0)
            {
                MessageBox.Show("Update process Failed");
            }
            else
            {
                MessageBox.Show("The Utility is Updated!");
            }



        }
    }
}
