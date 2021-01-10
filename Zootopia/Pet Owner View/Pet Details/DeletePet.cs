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
    public partial class DeletePet : Form
    {
        Controller ControllerObj;
        public string username= "John";
        public DeletePet()
        {
            InitializeComponent();
            ControllerObj = new Controller();
            DataTable dt = ControllerObj.SelectPetName(username);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "PName";
        }

        private void buttonCloseDelete_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int owner_Id = ControllerObj.SelectOwnerId_FromUsername(username);

            int result = ControllerObj.DeletePet(comboBox1.Text, owner_Id);
            if (result == 0)
            {
                MessageBox.Show("Delete process Failed");
            }
            else
            {
                MessageBox.Show("The Pet is Deleted!");
            }
        }

        
    }
}
