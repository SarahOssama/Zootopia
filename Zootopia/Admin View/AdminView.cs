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
        //public int adminPass = 1234;
        Controller controllerObj;
        
        public AdminView()
        {
            controllerObj = new Controller();
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
                //StringBuilder err = new StringBuilder();
                //Object pass = ValidationClass.isPositiveInteger(textBox1.Text, err);
                //if(pass==null)
                //{
                //    MessageBox.Show("The Password is incorrect:  " + err.ToString());
                //}

                //else 
                //{
                    DataTable adp = controllerObj.SelectAdminPass(textBox1.Text);
                    if (adp == null)
                    {
                        MessageBox.Show("Enter correct password");
                    }
                    else
                    {
                        AdminControls ad = new AdminControls();
                        ad.Show();
                        this.Close();
                    }
                //}
               
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
