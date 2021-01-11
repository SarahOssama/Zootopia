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
    public partial class UpdatePet : Form
    {
        Controller ControllerObj;
        public string OUsername = "John";
        public UpdatePet(string Username)
        {
            InitializeComponent();
            OUsername = Username;

            ControllerObj = new Controller();
            DataTable dt = ControllerObj.SelectPetName(OUsername);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "PName";

        }

        private void buttonCloseUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int owner_Id = ControllerObj.SelectOwnerId_FromUsername(OUsername);
            int result = ControllerObj.UpdatePet(comboBox1.Text, textBox1.Text, comboBox2.Text, owner_Id);
            if (result == 0)
            {
                MessageBox.Show("Update process Failed");
            }
            else
            {
                MessageBox.Show("The Pet is Updated!");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdatePet_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
