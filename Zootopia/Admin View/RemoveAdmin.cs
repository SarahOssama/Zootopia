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
    public partial class RemoveAdmin : Form
    {
        Controller controllerObj;
        public RemoveAdmin()
        {
            controllerObj = new Controller();
            InitializeComponent();
            DataTable dt = controllerObj.SelectAllAdmins();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Pass_Admin";
            comboBox1.ValueMember= "Pass_Admin";
        }

        private void buttonCloseViewUtilities_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminControls.ActiveForm.Close();
            Welcome.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue.ToString()=="")
            {
                MessageBox.Show("Please enter the password you want to remove");
            }
            else
            {
                DataTable pd = controllerObj.SelectAllAdmins();
                if (pd.Rows.Count == 1)
                {
                    MessageBox.Show("Can't remove .. there is only one admin");
                }
                else 
                {
                    int r = controllerObj.DeleteAdminPass(comboBox1.SelectedValue.ToString());
                    if (r==0)
                    {
                        MessageBox.Show("Something went wrong");
                    }
                    else 
                    {
                        DataTable dt = controllerObj.SelectAllAdmins();
                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "Pass_Admin";
                        comboBox1.ValueMember = "Pass_Admin";

                        MessageBox.Show("This admin is removed");
                    }
                }
            }
        }
    }
}
