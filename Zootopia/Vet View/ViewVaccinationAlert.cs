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
    public partial class ViewVaccinationAlert : Form
    {
        Controller controllerObj;
        public string name;
        public ViewVaccinationAlert(string username)
        {
            controllerObj = new Controller();
            InitializeComponent();
            name = username;

            DataTable d = controllerObj.SelectPetID(name);
            comboBox1.DataSource = d;
            comboBox1.DisplayMember = "Pet_ID";
            comboBox1.ValueMember = "Pet_ID";

           
        }

        private void buttonCloseViewUtilities_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           DataTable dt= controllerObj.ViewVaccinationAlert(name);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            VetView.ActiveForm.Close();
            Welcome.ActiveForm.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m=controllerObj.UpdateAlert(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(textBox1.Text));
            DataTable pname = controllerObj.SelectPetName(int.Parse(comboBox1.SelectedValue.ToString()));
            string pn = pname.Rows[0][0].ToString();
            DataTable vname = controllerObj.SelectVacName(int.Parse(textBox1.Text));
            string vn=vname.Rows[0][0].ToString();
            int r=controllerObj.UpdateNotification(pn, vn, int.Parse(comboBox1.SelectedValue.ToString()));
            if(r==0||m==0)
            {
                MessageBox.Show("There was an error please try again later");
            }
            else
            {
                MessageBox.Show("Pet owner is notified successfully ");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {

        }
    }
}
