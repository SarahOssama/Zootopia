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
    public partial class UpdateVetName : Form
    {
        public string username;
        Controller controllerObj;
        public UpdateVetName(string user)
        {
            controllerObj = new Controller();
            InitializeComponent();
            username = user;
        }

        private void buttonCloseViewUtilities_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter new name");
            }
            else
            {
                int r = controllerObj.UpdateVetName(textBox1.Text, username);
                if (r == 0)
                {
                    MessageBox.Show("There was a problem, please try again later");
                }
                else
                {
                    MessageBox.Show("Name updated successfully");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            VetView.ActiveForm.Close();
            Welcome.ActiveForm.Close();
        }
    }
}
