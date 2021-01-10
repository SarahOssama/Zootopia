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
    public partial class ReserveTrainer : Form
    {
        Controller controllerObj;
        public string OwnerUsername= "Habiba";
        public ReserveTrainer()
        {
            InitializeComponent();
            controllerObj = new Controller();

            DataTable dt1 = controllerObj.SelectAllHotelName();
            ReserveTrainerHotelNameComboBox.DataSource = dt1;
            ReserveTrainerHotelNameComboBox.DisplayMember = "HName";

        }

        private void buttonCloseUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TRateSearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TrainerOSearchButton_Click(object sender, EventArgs e)
        {
            if (ReserveTrainerHotelNameComboBox.Text == "" || TPriceSearchComboBox.Text == "" || TRateSearchComboBox.Text == "")
            {
                MessageBox.Show("There some missing inputs");
            }
            else
            {
                int TPriceUp, TPriceDown, TRateUp, TRateDown;
                switch (TPriceSearchComboBox.SelectedIndex)
                {
                    case 0:
                        TPriceUp = 300;
                        TPriceDown = 200;
                        break;

                    case 1:
                        TPriceUp = 400;
                        TPriceDown = 300;
                        break;

                    case 2:
                        TPriceUp = 500;
                        TPriceDown = 400;
                        break;

                    case 3:
                        TPriceUp = 600;
                        TPriceDown = 500;
                        break;

                    case 4:
                        TPriceUp = 700;
                        TPriceDown = 600;
                        break;

                    default:
                        TPriceUp = 700;
                        TPriceDown = 200;
                        break;
                }
                switch (TRateSearchComboBox.SelectedIndex)
                {
                    case 0:
                        TRateUp = 2;
                        TRateDown = 1;
                        break;

                    case 1:
                        TRateUp = 3;
                        TRateDown = 2;
                        break;

                    case 2:
                        TRateUp = 4;
                        TRateDown = 3;
                        break;

                    case 3:
                        TRateUp = 5;
                        TRateDown = 4;
                        break;

                    default:
                        TRateUp = 5;
                        TRateDown = 1;
                        break;
                }
                DataTable dt = controllerObj.SelectTrainerInHotel(ReserveTrainerHotelNameComboBox.Text, TPriceUp, TPriceDown, TRateUp, TRateDown);
                
                DataTable dt2 = controllerObj.SelectTrainerName(ReserveTrainerHotelNameComboBox.Text);
                TNameComboBox.DataSource = dt2;
                TNameComboBox.DisplayMember = "FName";

                DataTable dt3 = controllerObj.SelectPetNametoTrain(OwnerUsername);
                PNameComboBox.DataSource = dt3;
                PNameComboBox.DisplayMember = "PName";

                if (dt == null)
                {
                    MessageBox.Show("No Hotels available with these filters");
                }
                else
                {

                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();

                    
                }
            }
        }

        private void TPriceSearchComboBox_TextChange(object sender, EventArgs e)
        {
            if (TPriceSearchComboBox.SelectedIndex > -1)
            {
               // labelPriceRange.Visible = false;
            }
            else
            {
                //labelPriceRange.Show();
            }
        }



        private void TRateSearchComboBox_TextChange(object sender, EventArgs e)
        {
            if (TRateSearchComboBox.SelectedIndex > -1)
            {
                //labelRateRange.Visible = false;
            }
            else
            {
                //labelRateRange.Show();
            }
        }

        private void TRateRangeComboBox_Click(object sender, MouseEventArgs e)
        {
            if (TRateSearchComboBox.SelectedIndex > -1)
            {
                //labelRateRange.Visible = false;
            }
            else
            {
                //labelRateRange.Show();
            }
        }

        private void TPriceRangeComboBox_Click(object sender, MouseEventArgs e)
        {
            if (TPriceSearchComboBox.SelectedIndex > -1)
            {
                //labelPriceRange.Visible = false;
            }
            else
            {
                //labelPriceRange.Show();
            }
        }

        private void TrainerOHireButton_Click(object sender, EventArgs e)
        {
            if (ReserveTrainerHotelNameComboBox.Text == "" || TNameComboBox.Text == "" || PNameComboBox.Text == "")
            {
                MessageBox.Show("There some missing inputs");
            }
            else
            {
                int Tnum, HotelID, PetID;
                Tnum = controllerObj.SelectTrainerNumberToHire(ReserveTrainerHotelNameComboBox.Text, TNameComboBox.Text);
                HotelID = controllerObj.SelectHotelIDToHire(ReserveTrainerHotelNameComboBox.Text);
                PetID = controllerObj.SelectPetIDToHire(OwnerUsername, PNameComboBox.Text);

                int result = controllerObj.HireTrainer(Tnum,HotelID,PetID);
                if (result == 0)
                {
                    MessageBox.Show("Congratulations! You Hired Captain "+ TNameComboBox.Text );
                }
                else
                {
                    MessageBox.Show("Unfortunately Trainer" + TNameComboBox.Text + "Was not Hired !");
                }
            }
        }
    }
}
