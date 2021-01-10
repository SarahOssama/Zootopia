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
        Controller controllerObj;
        public CreateHotel()
        {
            controllerObj = new Controller();
            InitializeComponent();
            DataTable hl = controllerObj.SelectLocations();
            comboBox1.DataSource = hl;
            comboBox1.DisplayMember = "Location_Name";
            comboBox1.ValueMember = "Location_ID";
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
            if (name_textbox.Text == "" || phonenum_textbox.Text == "" ||textBoxPrice.Text==""|| textBoxNbOfRooms.Text == "" || textBoxPassword.Text == "" || textBoxUserName.Text == "")
            {
                MessageBox.Show("There some missing inputs");
            }
            else
            {
                StringBuilder err = new StringBuilder();
                StringBuilder err1 = new StringBuilder();
                Object nbOfRooms = ValidationClass.isPositiveInteger(textBoxNbOfRooms.Text, err);
                Object phone = ValidationClass.isPositiveInteger(phonenum_textbox.Text, err);
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

                    if(textBoxNewLocation.Text=="")
                    {
                        if(comboBox1.Text=="")
                        {
                            MessageBox.Show("There some missing inputs");

                        }
                        else
                        {
                           
                        int r=controllerObj.InsertHotel(name_textbox.Text,int.Parse(phonenum_textbox.Text),int.Parse(textBoxNbOfRooms.Text),float.Parse(textBoxPrice.Text),textBoxUserName.Text,int.Parse(comboBox1.SelectedValue.ToString()));
                       
                        if (r==0)
                            {
                                MessageBox.Show("An error has occured , please repeat");
                            }
                            else
                            {
                                MessageBox.Show("Your Username is: " + textBoxUserName.Text + " Your Password is: " + textBoxPassword.Text);
                                this.Close();
                                SignUp s = new SignUp();
                                s.Show();
                            }
                        
                        }
                    }
                    else 
                    {
                        int r=controllerObj.InsertLocation(textBoxNewLocation.Text);
                        if (r == 0)
                        {
                            MessageBox.Show("An error has occured , please repeat");
                        }
           
                      int Lid =controllerObj.SelectLocID(textBoxNewLocation.Text);
                       int r_l= controllerObj.InsertHotel(name_textbox.Text, int.Parse(phonenum_textbox.Text), int.Parse(textBoxNbOfRooms.Text), float.Parse(textBoxPrice.Text), textBoxUserName.Text, Lid);
                        if(r_l==0)
                        {
                            MessageBox.Show("An error has occured , please repeat");
                        }
                        else
                        {
                            MessageBox.Show("Your Username is: " + textBoxUserName.Text + " Your Password is: " + textBoxPassword.Text);
                            this.Close();
                            SignUp s = new SignUp();
                            s.Show();
                        }
                    }

                    
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (phonenum_textbox.TextLength < 11)
            {
                label8.Show();
            }
            else if (phonenum_textbox.TextLength == 11)
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

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
