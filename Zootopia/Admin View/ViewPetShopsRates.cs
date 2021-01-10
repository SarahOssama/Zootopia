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
    public partial class ViewPetShopsRates : Form
    {
        Controller controllerObj;
        public ViewPetShopsRates()
        {
            controllerObj = new Controller();
            InitializeComponent();
            DataTable dt = controllerObj.SelectPetShopNames();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Pshop_Name";
            comboBox1.ValueMember = "Pshop_Name";
        }

        private void buttonCloseViewUtilities_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = controllerObj.DeletePetShop(comboBox1.SelectedValue.ToString());
            if (r == 0)
            {
                MessageBox.Show("something went wrong please repeat again later");
            }
            else
            {
                MessageBox.Show("Petshop deleted successfully");
                DataTable dt = controllerObj.SelectPetShopNames();
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Pshop_Name";
                comboBox1.ValueMember = "Pshop_Name";
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
