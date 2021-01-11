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
    public partial class MatingPet : Form
    {
        Controller ControllerObj;
        public string username = "Habiba";
        public MatingPet(string Username)
        {
            InitializeComponent();
           
            
            comboBox3.Visible = false;

            ControllerObj = new Controller();
            DataTable dt = ControllerObj.SelectPetType();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "PType";
            
            DataTable dt2 = ControllerObj.SelectLocations();
            comboBox3.DataSource = dt2;
            comboBox3.DisplayMember = "Location_Name";



        }

        private void MattingPet_Load(object sender, EventArgs e)
        {

        }

        private void buttonCloseInsert_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearchForPetToMate_Click(object sender, EventArgs e)
        {
            string type;
            
                type = comboBox1.Text;

            if (radioButton3.Checked==false)
            {
                DataTable dt = ControllerObj.SearchForPetToMateWithoutLocation(type, username);
                if (dt == null)
                    MessageBox.Show("There's no Pets with these specifiction!");
                else
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                }
            }
            else
            {
                DataTable dt = ControllerObj.SearchForPetToMateWithLocation (type, comboBox3.Text, username);
                if (dt == null)
                    MessageBox.Show("There's no Pets in this Location!");
                else
                { 
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
                comboBox3.Visible = true;
        }
    }
}
