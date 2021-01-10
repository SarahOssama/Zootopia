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
    public partial class Utilities : Form
    {
        Controller ControllerObj;

        public Utilities()
        {
            InitializeComponent();
            ControllerObj = new Controller();
            DataTable dt = ControllerObj.SelectAllUtilityName();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "UName";

        }



        private void buttonCloseUtilities_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Utilities_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            int Pshop_Id = ControllerObj.GetPetShopId_FromShopName(comboBox1.Text);
            int Utility_Id = ControllerObj.GetUtilityId_FromUname(comboBox2.Text);

            int result  = ControllerObj.BuyUtility(Pshop_Id, Utility_Id, (int)numericUpDown1.Value);
            if (result == 0)
            {
                MessageBox.Show("The process of buying failed");
            }
            else
            {
                MessageBox.Show("Bought successfully!");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = ControllerObj.ViewAvilableUtility(comboBox2.Text, (int)numericUpDown1.Value);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            DataTable dt1 = ControllerObj.UtilityShopName(comboBox2.Text, (int)numericUpDown1.Value);
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "Pshop_Name";

        }
    }
}
