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
    public partial class RateHotel : Form
    {
        Controller ControllerObj;
        public string OUsername = "";

        public RateHotel(string Username)
        {
            InitializeComponent();
            OUsername = Username;

            ControllerObj = new Controller();
            DataTable dt = ControllerObj.SelectPnameFromVisit(OUsername);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "PName";



        }

        private void RateHotel_Load(object sender, EventArgs e)
        {

        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1 = ControllerObj.SelectHNameFromVisit(OUsername, comboBox3.Text);
            comboBox2.DataSource = dt1;
            comboBox2.DisplayMember = "HName";

        }

        private void buttonRate_Click(object sender, EventArgs e)
        {
            int pet_Id = ControllerObj.SelectPetId_FromPetName(comboBox3.Text);
            int hotel_Id = ControllerObj.SelectHotelId_FromHotelName(comboBox2.Text);
            int result = ControllerObj.RateHotel(pet_Id, hotel_Id, (double)numericUpDown1.Value);
            int result1 = ControllerObj.UpdateHotelRate(comboBox2.Text);

            if (result == 0 && result1==0)
            {
                MessageBox.Show("Rating failed");
            }
            else
            {
                MessageBox.Show("Rated successfully!");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCloseDeletePet_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
