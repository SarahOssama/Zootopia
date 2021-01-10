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
    public partial class ViewVetsRates : Form
    {
        Controller controllerObj;
        public ViewVetsRates()
        {
            controllerObj = new Controller();
            InitializeComponent();
            DataTable dt = controllerObj.SelectVetsRates();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Vet_Name";
            comboBox1.ValueMember = "Vet_Name";
        }

        private void buttonCloseViewUtilities_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectVetsRates();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = controllerObj.DeleteVet(comboBox1.SelectedValue.ToString());
            if (r == 0)
            {
                MessageBox.Show("something went wrong please repeat again later");
            }
            else
            {
                MessageBox.Show("Vet deleted successfully");
                DataTable dt = controllerObj.SelectVetsRates();
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Vet_Name";
                comboBox1.ValueMember = "Vet_Name";
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
