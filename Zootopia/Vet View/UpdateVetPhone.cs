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
    public partial class UpdateVetPhone : Form
    {
        public string username;
        Controller controllerObj;
        public UpdateVetPhone(string name)
        {
            controllerObj = new Controller();
            InitializeComponent();
            label8.Visible = false;

            username = name;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 11)
            {
                label8.Show();
            }
            else if (textBox1.TextLength == 11)
            {
                label8.Visible = false;
            }
        }

        private void buttonCloseViewUtilities_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            VetView.ActiveForm.Close();
            Welcome.ActiveForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Please enter new Phone number");
                
            }
            else
            {
                StringBuilder err = new StringBuilder();
                Object phone = ValidationClass.isPositiveInteger(textBox1.Text, err);

                if (phone == null || label8.Visible==true)
                {
                    MessageBox.Show("Invalid phone number:  " + err.ToString());
                }
                else
                {
                    int r=controllerObj.UpdateVetPhone(int.Parse(textBox1.Text), username);
                    if (r == 0)
                    {
                        MessageBox.Show("There was a problem, please try again later");
                    }
                    else
                    {

                        MessageBox.Show("Phone number updated successfully");
                    }
                }
            }
            


        }
    }
}
