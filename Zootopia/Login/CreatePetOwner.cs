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
    public partial class CreatePetOwner : Form
    {
        public CreatePetOwner()
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

        private void CreatePetOwner_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""|| textBox2.Text==""|| textBox3.Text==""|| textBoxPassword.Text==""|| textBoxUserName.Text=="")
            {
                MessageBox.Show("There some missing inputs");
            }
            else
            {
                StringBuilder err = new StringBuilder();
                Object phone = ValidationClass.isPositiveInteger(textBox3.Text, err);
                if (phone == null)
                {
                    MessageBox.Show("Invalid phone number:  " + err.ToString());
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBoxNewLocation.Visible = true;
            }
            
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if(textBoxPassword.TextLength>8)
            {
                label7.Show();
            }
            else if(textBoxPassword.TextLength<=8)
            {
                label7.Visible = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.TextLength < 11)
            {
                label8.Show();
            }
            else if (textBox3.TextLength == 11)
            {
                label8.Visible = false;
            }
        }
    }
}
