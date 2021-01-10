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
    public partial class UpdateVetUsername : Form
    {
        public string username;
        Controller controllerObj;
        public UpdateVetUsername(string name)
        {
            controllerObj = new Controller();
            InitializeComponent();
            username = name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            VetView.ActiveForm.Close();
            Welcome.ActiveForm.Close();
        }

        private void buttonCloseViewUtilities_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter new Username");
            }
            else
            {
                string newusrn= "VT-"+textBox1.Text;
                DataTable d = controllerObj.selectUsernames(textBox1.Text);
                if (d == null)
                {
                    int r = controllerObj.UpdateVetUsername(newusrn, username);
                    if (r == 0)
                    {
                        MessageBox.Show("There was a problem, please try again later");
                    }
                    else
                    {

                        MessageBox.Show("Username updated successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Username already exists, please choose another");
                }
            }
        }
    }
}
