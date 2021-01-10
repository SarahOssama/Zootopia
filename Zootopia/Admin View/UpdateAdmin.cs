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
    public partial class UpdateAdmin : Form
    {
        Controller controllerObj;
        public UpdateAdmin()
        {
            controllerObj = new Controller();
            InitializeComponent();
            DataTable dt = controllerObj.SelectAllAdmins();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Pass_Admin";
            comboBox1.ValueMember = "Pass_Admin";
        }

        private void buttonCloseViewUtilities_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue.ToString()==""||textBox1.Text=="")
            {
                MessageBox.Show("Please choose the password you want to update and its new value ");
            }
            else
            {
                DataTable adp = controllerObj.SelectAdminPass(textBox1.Text);
                if (adp == null)
                {


                    int r = controllerObj.UpdateAdminPass(comboBox1.SelectedValue.ToString(), textBox1.Text);
                    if (r == 0)
                    {
                        MessageBox.Show("Something went wrong");
                    }
                    else
                    {
                        DataTable dt = controllerObj.SelectAllAdmins();
                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "Pass_Admin";
                        comboBox1.ValueMember = "Pass_Admin";
                        MessageBox.Show("Password is updated");
                    }
                }
                else
                {
                    MessageBox.Show("This password already exists");
                }
            }
        }
    }
}
