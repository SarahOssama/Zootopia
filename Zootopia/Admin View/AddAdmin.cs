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

   
    public partial class AddAdmin : Form
    {
        Controller controllerObj;
        public AddAdmin()
        {
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void buttonCloseViewUtilities_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Please insert Admin password");
            }
            else
            {
                //DataTable us = controllerObj.SelectUsername(username_textbox.Text);
                //if (us == null)
                //{
                //    MessageBox.Show("Invalid username");

                //}
                DataTable adp = controllerObj.SelectAdminPass(textBox1.Text);
                if (adp == null)
                {
                    int r = controllerObj.InsertAdminPass(textBox1.Text);
                    if(r==0)
                    {
                    MessageBox.Show("Something went wrong");
                    }
                    else 
                    {
                    MessageBox.Show("New admin is added");
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
