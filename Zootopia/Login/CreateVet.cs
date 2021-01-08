﻿using System;
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
    public partial class CreateVet : Form
    {
        public CreateVet()
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
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBoxPassword.Text == "" || textBoxUserName.Text == "")
            {
                MessageBox.Show("There some missing inputs");
            }
            else
            {
                StringBuilder err = new StringBuilder();
                StringBuilder err2 = new StringBuilder();
                Object phone = ValidationClass.isPositiveInteger(textBox2.Text, err);
                Object price = ValidationClass.isPositiveFloat(textBox3.Text, err2);

                if (phone == null )
                {
                    MessageBox.Show("Invalid phone number  " + err.ToString());
                }
                else if(price == null)
                {
                    MessageBox.Show("Invalid price  " + err2.ToString());
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
       
       

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBoxNewLocation.Visible = true;
            }

        }

        private void textBoxPassword_TextChanged_1(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.TextLength<11)
            {
                label8.Show();
            }
            else if(textBox2.TextLength==11)
            {
                label8.Visible = false;
            }
        }
    }
}
