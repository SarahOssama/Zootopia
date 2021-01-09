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
    public partial class HotelSearch : Form
    {
        Controller controllerObj;
        public HotelSearch()
        {
            InitializeComponent();

            labelPriceRange.Visible = false;
            labelRateRange.Visible = false;


            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectLocations();
            HLocationSearchComboBox.DataSource = dt;
            HLocationSearchComboBox.DisplayMember = "Location_Name";
        }

        private void buttonCloseUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearchForHotel_Click(object sender, EventArgs e)
        {
            if (HLocationSearchComboBox.Text == "" || HPriceSearchComboBox.Text == "" || HRateSearchComboBox.Text == "" )
            {
                MessageBox.Show("There some missing inputs");
            }
            else
            {
                int HPriceUp, HPriceDown, HRateUp, HRateDown;
                switch (HPriceSearchComboBox.SelectedIndex)
                {
                    case 0:
                        HPriceUp = 1000;
                        HPriceDown = 500;
                        break;

                    case 1:
                        HPriceUp = 1500;
                        HPriceDown = 1000;
                        break;

                    case 2:
                        HPriceUp = 2000;
                        HPriceDown = 1500;
                        break;

                    case 3:
                        HPriceUp = 2500;
                        HPriceDown = 2000;
                        break;

                    default:
                        HPriceUp = 2500;
                        HPriceDown = 500;
                        break;
                }
                switch (HRateSearchComboBox.SelectedIndex)
                {
                    case 0:
                        HRateUp = 2;
                        HRateDown = 1;
                        break;

                    case 1:
                        HRateUp = 3;
                        HRateDown = 2;
                        break;

                    case 2:
                        HRateUp = 4;
                        HRateDown = 3;
                        break;

                    case 3:
                        HRateUp = 5;
                        HRateDown = 4;
                        break;

                    default:
                        HRateUp = 5;
                        HRateDown = 1;
                        break;
                }
                DataTable dt = controllerObj.SearchHotel(HLocationSearchComboBox.Text,HPriceUp,HPriceDown,HRateUp,HRateDown);
                if (dt == null)
                {
                    MessageBox.Show("No Hotels available with these filters");
                }
                else
                {

                    HotelSearchDataGrid.DataSource = dt;
                    HotelSearchDataGrid.Refresh();
                }
            }
                
        }

        private void HPriceSearchComboBox_TextChange(object sender, EventArgs e)
        {
            if (HPriceSearchComboBox.SelectedIndex > -1)
            {                
                labelPriceRange.Visible = false;
            }
            else 
            {
                labelPriceRange.Show();
            }
        }

       

        private void HRateSearchComboBox_TextChanged(object sender, EventArgs e)
        {
            if (HRateSearchComboBox.SelectedIndex > -1)
            {
                labelRateRange.Visible = false;
            }
            else
            {
                labelRateRange.Show();
            }
        }

        private void RateRangeComboBox_Click(object sender, MouseEventArgs e)
        {
            if (HRateSearchComboBox.SelectedIndex > -1)
            {
                labelRateRange.Visible = false;
            }
            else
            {
                labelRateRange.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
