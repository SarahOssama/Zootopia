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
    public partial class AddUtilityToShop : Form
    {
        Controller ControllerObj;
        public string PSUsername = "";
        public AddUtilityToShop(string Username)
        {
            InitializeComponent();
            PSUsername = Username;

            ControllerObj = new Controller();
            DataTable dt = ControllerObj.SelectAllUtilityName();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "UName";

        }

        private void AddUtilityToShop_Load(object sender, EventArgs e)
        {

        }

        private void buttonCloseAddUtility_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonInsertUtility_Click(object sender, EventArgs e)
        {
            int Pshop__D = ControllerObj.SelectPetShopID_FromUsername(PSUsername);
            int Utility_Id = ControllerObj.GetUtilityId(comboBox1.Text);

            int result = ControllerObj.InsertUtilityToShop((int)numericUpDown1.Value, dateTimePicker1.Text,Pshop__D, Utility_Id);
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new Utility failed");
            }
            else
            {
                MessageBox.Show("The Utility is inserted successfully!");
            }

        }
    }
}
