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
    public partial class CreatePetShop : Form
    {
        Controller controllerObj;
        public CreatePetShop()
        {
            controllerObj = new Controller();
            InitializeComponent();
            textBoxNewLocation.Visible = false;
            DataTable hl = controllerObj.SelectLocations();
            comboBox1.DataSource = hl;
            comboBox1.DisplayMember = "Location_Name";
            comboBox1.ValueMember = "Location_ID";
            label7.Visible = false;
            label8.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateAccount a = new CreateAccount();
            a.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (name_textbox.Text == ""  || phonenum_textbox.Text == "" || textBoxPassword.Text == "" || textBoxUserName.Text == "")
            {
                MessageBox.Show("There some missing inputs");
            }
            else
            {
                StringBuilder err = new StringBuilder();
                Object phone = ValidationClass.isPositiveInteger(phonenum_textbox.Text, err);
                if (phone == null)
                {
                    MessageBox.Show("Invalid phone number:  " + err.ToString());
                }
                else
                {  //el controller el mafroud yenafez order el insert hena
                    string usern = "PT-" + textBoxUserName.Text;
                    if (textBoxNewLocation.Text == "")
                    {
                        if (comboBox1.Text == "")
                        {
                            MessageBox.Show("There some missing inputs");

                        }
                        else
                        {
                            int l = controllerObj.InsertLogin(usern, textBoxPassword.Text);
                            int r = controllerObj.InsertPetShop(name_textbox.Text, int.Parse(phonenum_textbox.Text),usern, int.Parse(comboBox1.SelectedValue.ToString()));

                            if (r == 0)
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
                        DataTable locid = controllerObj.SelectLocID(textBoxNewLocation.Text);
                        if (locid == null)   //not already an existant location
                        {
                            
                            int r = controllerObj.InsertLocation(textBoxNewLocation.Text);
                            if (r == 0)
                            {
                                MessageBox.Show("An error has occured , please repeat");
                            }
                        }
                        int l = controllerObj.InsertLogin(usern, textBoxPassword.Text);
                        DataTable Lidt = controllerObj.SelectLocID(textBoxNewLocation.Text);
                        int lid = int.Parse(Lidt.Rows[0][0].ToString());
                        int r_l = controllerObj.InsertPetShop(name_textbox.Text, int.Parse(phonenum_textbox.Text), usern, lid);
                        if (r_l == 0)
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

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
