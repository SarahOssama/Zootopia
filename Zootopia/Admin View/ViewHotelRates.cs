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
    public partial class ViewHotelRates : Form
    {
        Controller controllerObj;
        public ViewHotelRates()
        {
            controllerObj = new Controller();

            InitializeComponent();

            DataTable dt = controllerObj.SelectHotelRates();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "HName";
            comboBox1.ValueMember = "HName";
        }

        private void buttonCloseViewUtilities_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt= controllerObj.SelectHotelRates();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r=controllerObj.DeleteHotel(comboBox1.SelectedValue.ToString());
            if(r==0)
            {
                MessageBox.Show("something went wrong please repeat again later");
            }
            else
            {
                MessageBox.Show("Hotel deleted successfully");
                DataTable dt = controllerObj.SelectHotelRates();
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "HName";
                comboBox1.ValueMember = "HName";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminControls.ActiveForm.Close();
            Welcome.ActiveForm.Close();
        }
    }
}
