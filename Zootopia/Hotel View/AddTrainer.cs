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

    public partial class AddTrainer : Form
    {
        Controller controllerObj;
        public string HotelUsername = "";

        public AddTrainer(string Username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            HotelUsername = Username;

            labelNumber.Visible = false;
            labelPrice.Visible = false;
            labelFname.Visible = false;
            labelLName.Visible = false;

        }

        private void buttonCloseAddTrainer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TrainerFNameTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (TrainerFNameTextBox.Text == "Enter First Name")
            {
                TrainerFNameTextBox.Text = "";
                TrainerFNameTextBox.ForeColor = Color.Black;
            }
        }

        private void TrainerFNameTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (TrainerFNameTextBox.Text == "")
            {
                TrainerFNameTextBox.Text = "Enter First Name";
                TrainerFNameTextBox.ForeColor = Color.Gray;

            }
        }

        private void TrainerLNameTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (TrainerLNameTextBox.Text == "Enter Last Name")
            {
                TrainerLNameTextBox.Text = "";
                TrainerLNameTextBox.ForeColor = Color.Black;
            }
        }

        private void TrainerLNameTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (TrainerLNameTextBox.Text == "")
            {
                TrainerLNameTextBox.Text = "Enter Last Name";
                TrainerLNameTextBox.ForeColor = Color.Gray;
            }
        }


        private void TrainerPriceTextBox_Leave(object sender, EventArgs e)
        {
            if (TrainerPriceTextBox.Text == "")
            {
                labelPrice.Show();

            }
            else
            {
                labelPrice.Visible = false;

                StringBuilder err = new StringBuilder();

                Object Pricecheck = ValidationClass.isPositiveInteger(TrainerPriceTextBox.Text, err);

                if (Pricecheck == null)
                {
                    MessageBox.Show("The Price must be positice " + err.ToString());

                }

            }
        }

        private void TrainerNumTextBox_Leave(object sender, EventArgs e)
        {
            if (TrainerNumTextBox.Text == "")
            {
                labelNumber.Show();

            }
            else
            {
                labelNumber.Visible = false;

                StringBuilder err = new StringBuilder();

                Object Pricecheck = ValidationClass.isPositiveInteger(TrainerNumTextBox.Text, err);

                if (Pricecheck == null)
                {
                    MessageBox.Show("The Number must be positice " + err.ToString());
                }


            }
        }

        private void TrainerFNameTextBox_Leave(object sender, EventArgs e)
        {
            if (TrainerFNameTextBox.Text == "Enter First Name")
            {
                labelFname.Show();

            }
            else
            {
                labelFname.Visible = false;

            }
        }

        private void TrainerLNameTextBox_Leave(object sender, EventArgs e)
        {
            if(TrainerLNameTextBox.Text == "Enter Last Name")
            {
                labelLName.Show();

            }
            else
            {
                labelLName.Visible = false;

            }
        }

        private void buttonInsertTrainer_Click(object sender, EventArgs e)
        {
            if (TrainerLNameTextBox.Text == "" || TrainerFNameTextBox.Text == "" || TrainerNumTextBox.Text == "" || TrainerPriceTextBox.Text=="")
            {
                MessageBox.Show("There some missing inputs");
            }
            else
            {
                int Hotel_ID=controllerObj.SelectHotelIDWithUserName(HotelUsername);
                int result = controllerObj.AddNewTrainer(TrainerFNameTextBox.Text, TrainerLNameTextBox.Text, Int32.Parse(TrainerNumTextBox.Text), Int32.Parse(TrainerPriceTextBox.Text), Hotel_ID);
                if (result == 0)
                {
                    MessageBox.Show("Unfortunately Trainer " + TrainerFNameTextBox.Text + " Was not Added! Please Change the Trainer Number!");
                }
                else
                {
                    MessageBox.Show("Congratulations! You Added Captain " + TrainerFNameTextBox.Text);
                }
            }
        }
    }
}
