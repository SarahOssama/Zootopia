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
    
    public partial class AdminView : Form
    {
        public int adminPass = 1234;
        public AdminView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Password");
            }
            else
            {
                StringBuilder err = new StringBuilder();
                Object pass = ValidationClass.isPositiveInteger(textBox1.Text, err);
                if(pass==null)
                {
                    MessageBox.Show("The Password is incorrect:  " + err.ToString());
                }

                else if (int.Parse(textBox1.Text) == adminPass)
                {
                    AdminControls ad = new AdminControls();
                    ad.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            SignUp s = new SignUp();
            s.Show();
        }
    }
}
