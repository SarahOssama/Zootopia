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
    public partial class UpdateVetLocation : Form
    {
        Controller controllerObj;
        public string username;
        public UpdateVetLocation(string name)
        {
            controllerObj = new Controller();
            InitializeComponent();
            textBoxNewLocation.Visible = false;
            username = name;

            DataTable dt = controllerObj.SelectLocations();
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "Location_ID";
            comboBox1.DisplayMember = "Location_Name";
        }

        private void buttonCloseViewUtilities_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBoxNewLocation.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminControls.ActiveForm.Close();
            Welcome.ActiveForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxNewLocation.Text == "")
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Please enter a new location");

                }
                else
                {
                    int r = controllerObj.UpdateVetLocation(int.Parse(comboBox1.SelectedValue.ToString()), username);

                    if (r == 0)
                    {
                        MessageBox.Show("There was a problem, please try again later");
                    }
                    else
                    {
                        MessageBox.Show("Location updated successfully");
                    }

                }
            }
            else
            {
                DataTable old = controllerObj.SelectLocID(textBoxNewLocation.Text);
                if (old == null)
                {
                    int r = controllerObj.InsertLocation(textBoxNewLocation.Text);
                    if (r == 0)
                    {
                        MessageBox.Show("An error has occured , please repeat");
                    }

                    DataTable Lid = controllerObj.SelectLocID(textBoxNewLocation.Text);
                    int id = int.Parse(Lid.Rows[0][0].ToString());

                    int r2 = controllerObj.UpdateVetLocation(id, username);
                    if (r2 == 0)
                    {
                        MessageBox.Show("There was a problem, please try again later");
                    }
                    else
                    {
                        MessageBox.Show("Location updated successfully");
                    }

                }
                else
                {
                    int l = int.Parse(old.Rows[0][0].ToString());
                    int r2 = controllerObj.UpdateVetLocation(l, username);
                    if (r2 == 0)
                    {
                        MessageBox.Show("There was a problem, please try again later");
                    }
                    else
                    {
                        MessageBox.Show("Location updated successfully");
                    }
                }
            }
        }
    }
}
