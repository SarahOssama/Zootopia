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
    public partial class CreateHotel : Form
    {
        public CreateHotel()
        {
            InitializeComponent();
            textBoxNewLocation.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateAccount a = new CreateAccount();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" ||textBoxPrice.Text==""|| textBoxNbOfRooms.Text == "" || textBoxPassword.Text == "" || textBoxUserName.Text == "")
            {
                MessageBox.Show("There some missing inputs");
            }
            else
            {
                StringBuilder err = new StringBuilder();
                StringBuilder err1 = new StringBuilder();
                Object nbOfRooms = ValidationClass.isPositiveInteger(textBoxNbOfRooms.Text, err);
                Object phone = ValidationClass.isPositiveInteger(textBox2.Text, err);
                Object price= ValidationClass.isPositiveFloat(textBoxPrice.Text, err1);

                if (nbOfRooms == null || phone==null)
                {
                    MessageBox.Show("Invalid phone number or number of rooms:  " + err.ToString());
                }
                else if(price==null)
                {
                    MessageBox.Show("Invalid price:  " + err1.ToString());
                }
                else
                {  //el controller el mafroud yenafez order el insert hena

                    MessageBox.Show("Your Username is: " + textBoxUserName.Text + " Your Password is: " + textBoxPassword.Text);
                    this.Close();
                    SignUp s = new SignUp();
                    s.Show();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength < 11)
            {
                label8.Show();
            }
            else if (textBox2.TextLength == 11)
            {
                label8.Visible = false;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.TextLength > 8)
            {
                label7.Show();
            }
            else if (textBoxPassword.TextLength <= 8)
            {
                label7.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBoxNewLocation.Visible = true;
            }
        }
    }
}
