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
    public partial class RateTrainer : Form
    {
        Controller ControllerObj;
        public string OUsername = "";
        public RateTrainer(string Username)
        {
            InitializeComponent();
            OUsername = Username;

            ControllerObj = new Controller();
            DataTable dt = ControllerObj.SelectPName_FromTrained(OUsername);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "PName";


        }

        private void buttonCloseDeletePet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRate_Click(object sender, EventArgs e)
        {
            int pet_Id = ControllerObj.SelectPetId_FromPetName(comboBox3.Text);
            int hotel_Id = ControllerObj.SelectHotelId_FromHotelName(comboBox2.Text);
            int Tnum = ControllerObj.SelectTnum_FRomTName(comboBox1.Text);

            int result1 = ControllerObj.UpdateTrainerRate(Tnum, hotel_Id);
            int result = ControllerObj.RateTrainer((double)numericUpDown1.Value, Tnum, hotel_Id, pet_Id);
            if (result == 0 && result1==0)
            {
                MessageBox.Show("Rating failed");
            }
            else
            {
                MessageBox.Show("Rated successfully!");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1 = ControllerObj.SelectHotelName_FromTrained(OUsername, comboBox3.Text);
            comboBox2.DataSource = dt1;
            comboBox2.DisplayMember = "HName";

            DataTable dt2 = ControllerObj.SelectTrainerName_FromTrained(OUsername, comboBox3.Text);
            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "FName";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
