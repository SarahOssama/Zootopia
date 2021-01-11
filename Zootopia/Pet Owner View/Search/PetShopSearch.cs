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
    public partial class PetShopSearch : Form
    {
        Controller controllerObj;
        public string OUsername = "";
        public PetShopSearch(string Username)
        {
            InitializeComponent();
            OUsername = Username;

            labelPriceRange.Visible = false;
            labelRateRange.Visible = false;


            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectLocations();
            PSLocationSearchComboBox.DataSource = dt;
            PSLocationSearchComboBox.DisplayMember = "Location_Name";
        }

        private void buttonCloseUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void buttonSearchForPetShop_Click(object sender, EventArgs e)
        {
            if (PSLocationSearchComboBox.Text == "" )
            {
                MessageBox.Show("There some missing inputs");
            }
            else
            {
               
                DataTable dt = controllerObj.SearchPetShop(PSLocationSearchComboBox.Text);
                if (dt == null)
                {
                    MessageBox.Show("No Pet Shops available with these filters");
                }
                else
                {

                    PetshopSearchDataGrid.DataSource = dt;
                    PetshopSearchDataGrid.Refresh();
                }
            }
            }

    }
}
