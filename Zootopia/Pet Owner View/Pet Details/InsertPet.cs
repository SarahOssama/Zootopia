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
    public partial class InsertPet : Form
    {
        Controller ControllerObj;
        public string username = "John";

        public InsertPet()
        {
            InitializeComponent();
            ControllerObj = new Controller();
        }

        private void buttonCloseInsert_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            int owner_Id = ControllerObj.SelectOwnerId_FromUsername(username);

            int result = ControllerObj.InserPet(textBoxName.Text, comboBoxGender.Text, Int32.Parse(textBoxAge.Text), textBoxType.Text, textBoxBreed.Text, owner_Id);
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new pet failed");
            }
            else
            {
                MessageBox.Show("The pet is inserted successfully!");
            }

        }
    }
}
