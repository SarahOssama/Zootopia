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
    public partial class AddUtility : Form
    {
        Controller ControllerObj;
        public string PSUsername = "";

        public AddUtility(string Username)
        {
            InitializeComponent();
            PSUsername = Username;

            textBoxUtilityCategory.Visible = false;
            ControllerObj = new Controller();
            DataTable dt = ControllerObj.SelectUtilityCategory();
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "UCategory";

            
        }

        private void buttonCloseAddUtility_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInsertUtility_Click(object sender, EventArgs e)
        {
            string category;
            if (radioButton1.Checked == true)
                category = textBoxUtilityCategory.Text;
            else
                category = comboBox3.Text;

            int result = ControllerObj.InsertUtility(textBox1.Text, Int32.Parse(textBox2.Text), category);
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new Utility failed");
            }
            else
            {
                MessageBox.Show("The Utility is inserted successfully!");
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                textBoxUtilityCategory.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
