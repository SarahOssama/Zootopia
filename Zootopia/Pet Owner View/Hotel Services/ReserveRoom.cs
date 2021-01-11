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
    public partial class ReserveRoom : Form
    {
        Controller controllerObj;
        public string OwnerUsername= "";
        public ReserveRoom(string Username)
        {
            InitializeComponent();
            OwnerUsername = Username;

            controllerObj = new Controller();
            DateTime ResetDate = DateTime.Now;            
            ArrdateTimePicker.MinDate = ResetDate;


            DataTable dt = controllerObj.SelectAllHotelName();
            ReserveRoomHotelNameComboBox.DataSource = dt;
            ReserveRoomHotelNameComboBox.DisplayMember = "HName";

            DataTable dt1 = controllerObj.SelectPetName(OwnerUsername);
            ReserveRoomPetNameComboBox.DataSource = dt1;
            ReserveRoomPetNameComboBox.DisplayMember = "PName";

          

        }

        private void ReserveRoom_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "yyyy-mm-dd";
        }

        private void ReserveRoomButton_Click(object sender, EventArgs e)
        {
            if (ReserveRoomHotelNameComboBox.Text == "" || ArrdateTimePicker.Text == "" || DepdateTimePicker.Text == "" || ReserveRoomPetNameComboBox.Text == "")
            {
                MessageBox.Show("There some missing inputs");
            }
            else
            {
                int  HotelID, PetID;
                HotelID = controllerObj.SelectHotelIDToHire(ReserveRoomHotelNameComboBox.Text);
                PetID = controllerObj.SelectPetIDToHire(OwnerUsername, ReserveRoomPetNameComboBox.Text);

                int result = controllerObj.InsertToVisitor(DepdateTimePicker.Text, ArrdateTimePicker.Text,PetID,HotelID);

                if (result == 0 )
                {
                    MessageBox.Show("Unfortunately You didn't Reserve a Room in Hotel" + ReserveRoomHotelNameComboBox.Text + " !");
                }
                else
                {
                    MessageBox.Show("Congratulations! You Reserved a Room in Hotel" + ReserveRoomHotelNameComboBox.Text);
                    int result2 = controllerObj.DecNumOFRoomsinHotel(ReserveRoomHotelNameComboBox.Text);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DepdateTimePicker_CloseUp(object sender, EventArgs e)
        {
            DateTime DepDate = Convert.ToDateTime(DepdateTimePicker.Text);
            DateTime ArrDate = Convert.ToDateTime(ArrdateTimePicker.Text);

            if (ArrDate > DepDate)
            {
                MessageBox.Show("The Departure Date Must Be after The Arrival Date");
            }

            DataTable qt = controllerObj.SelectHotelPrice(ReserveRoomHotelNameComboBox.Text);
            ViewRoomPriceTextBox.Text = qt.Rows[0][0].ToString();
        }

        private void DepdateTimePicker_Enter(object sender, EventArgs e)
        {
            //DateTime DepDate = Convert.ToDateTime(DepdateTimePicker.Text);
            DateTime ArrDate = Convert.ToDateTime(ArrdateTimePicker.Text);

            DepdateTimePicker.MinDate = ArrDate;
        }

        private void ArrdateTimePicker_CloseUp(object sender, EventArgs e)
        {
            DateTime DepDate = Convert.ToDateTime(DepdateTimePicker.Text);
            DateTime ArrDate = Convert.ToDateTime(ArrdateTimePicker.Text);
            DateTime ResetDate = DateTime.Now;


            if (ArrDate > DepDate)
            {
                MessageBox.Show("The Departure Date Must Be after The Arrival Date");
                DepdateTimePicker.MinDate = ArrDate;
            }

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReserveRoomHotelNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReserveRoomHotelNameComboBox.Text != "System.Data.DataRowView")
            {
                DataTable qt = controllerObj.SelectHotelPrice(ReserveRoomHotelNameComboBox.Text);
                ViewRoomPriceTextBox.Text = qt.Rows[0][0].ToString();
            }

        }

        private void ReserveRoomHotelNameComboBox_Click(object sender, EventArgs e)
        {
           
        }
    }
}
