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
    public partial class UpdateVetPassword : Form
    {
        public string username;
        Controller controllerObj;
        public UpdateVetPassword(string name)
        {
            controllerObj = new Controller();
            InitializeComponent();
            label7.Visible = false;
            username = name;
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
            if(textBoxPassword.Text=="")
            {
                MessageBox.Show("Please enter new Password");
            }
            else
            {
                if (label7.Visible==true )
                {
                    MessageBox.Show("Invalid password" );

                }
                else
                {
                    int r = controllerObj.UpdateVetPassword(textBoxPassword.Text,username);
                    if (r == 0)
                    {
                        MessageBox.Show("There was a problem, please try again later");
                    }
                    else
                    {

                        MessageBox.Show("Password updated successfully");
                    }

                }

            }
        }
    }
}
