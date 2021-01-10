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
    }
}
