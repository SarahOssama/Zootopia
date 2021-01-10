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
    public partial class DeleteTrainer : Form
    {
        Controller controllerObj;
        public string HotelUsername = "Makan";

        public DeleteTrainer()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt2 = controllerObj.SelectTrainerNameWithUserName(HotelUsername);
            DeleteTrainerNameComboBox.DataSource = dt2;
            DeleteTrainerNameComboBox.DisplayMember = "FName";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int r = controllerObj.DeleteTrainer(DeleteTrainerNameComboBox.Text, HotelUsername);
            if (r == 0)
            {
                MessageBox.Show("Something went wrong");
            }
            else
            {
                MessageBox.Show("You Deleted Captain " + DeleteTrainerNameComboBox.Text);

            }
        }
    }
}
