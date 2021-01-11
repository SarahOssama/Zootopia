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
    public partial class VetSearch : Form
    {
        Controller controllerObj;
        public string OUsername = "";
        public VetSearch(string Username)
        {
            InitializeComponent();
            OUsername = Username;

            labelPriceRange.Visible = false;
            labelRateRange.Visible = false;

            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectLocations();
            VLocationSearchComboBox.DataSource = dt;
            VLocationSearchComboBox.DisplayMember = "Location_Name";
        }

        private void buttonCloseVetSearch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearchForVet_Click(object sender, EventArgs e)
        {
            if (VLocationSearchComboBox.Text == "" || VPriceSearchComboBox.Text == "" || VRateSearchComboBox.Text == "")
            {
                MessageBox.Show("There some missing inputs");
            }
            else
            {
                int VPriceUp, VPriceDown, VRateUp, VRateDown;
                switch (VPriceSearchComboBox.SelectedIndex)
                {
                    case 0:
                        VPriceUp = 200;
                        VPriceDown = 100;
                        break;

                    case 1:
                        VPriceUp = 300;
                        VPriceDown = 200;
                        break;

                    case 2:
                        VPriceUp = 400;
                        VPriceDown = 300;
                        break;

                    case 3:
                        VPriceUp = 500;
                        VPriceDown = 400;
                        break;

                    default:
                        VPriceUp = 500;
                        VPriceDown = 100;
                        break;
                }
                switch (VRateSearchComboBox.SelectedIndex)
                {
                    case 0:
                        VRateUp = 2;
                        VRateDown = 1;
                        break;

                    case 1:
                        VRateUp = 3;
                        VRateDown = 2;
                        break;

                    case 2:
                        VRateUp = 4;
                        VRateDown = 3;
                        break;

                    case 3:
                        VRateUp = 5;
                        VRateDown = 4;
                        break;

                    default:
                        VRateUp = 5;
                        VRateDown = 1;
                        break;
                }
                DataTable dt = controllerObj.SearchVet(VLocationSearchComboBox.Text, VPriceUp, VPriceDown, VRateUp, VRateDown);
                if (dt == null)
                {
                    MessageBox.Show("No Vets available with these filters");
                }
                else
                {

                    VetSearchDataGrid.DataSource = dt;
                    VetSearchDataGrid.Refresh();
                }
            }
        }

        private void VPriceSearchComboBox_TextChange(object sender, EventArgs e)
        {
            if (VPriceSearchComboBox.SelectedIndex > -1)
            {
                labelPriceRange.Visible = false;
            }
            else
            {
                labelPriceRange.Show();
            }
        }



        private void VRateSearchComboBox_TextChange(object sender, EventArgs e)
        {
            if (VRateSearchComboBox.SelectedIndex > -1)
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
            if (VRateSearchComboBox.SelectedIndex > -1)
            {
                labelRateRange.Visible = false;
            }
            else
            {
                labelRateRange.Show();
            }
        }

        private void PriceRangeComboBox_Click(object sender, MouseEventArgs e)
        {
            if (VPriceSearchComboBox.SelectedIndex > -1)
            {
                labelPriceRange.Visible = false;
            }
            else
            {
                labelPriceRange.Show();
            }
        }
    }
}
