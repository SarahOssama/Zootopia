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
    public partial class DeleteUtility : Form
    {
        Controller ControllerObj;
        public string PSUsername= "";
        public DeleteUtility(string Username)
        {
            InitializeComponent();
            PSUsername = Username;
            ControllerObj = new Controller();
            DataTable dt = ControllerObj.SelectUtilityName(PSUsername);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "UName";

        }

        private void buttonCloseViewUtilities_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeleteUtility_Click(object sender, EventArgs e)
        {
           
           int result= ControllerObj.DeleteUtility(comboBox2.Text, PSUsername );

            if (result == 0)
            {
                MessageBox.Show("Delete process Failed");
            }
            else
            {
                MessageBox.Show("The Utility is Deleted!");
            }


        }
    }
}
