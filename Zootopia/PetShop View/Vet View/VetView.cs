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
    public partial class VetView : Form
    {
        public VetView()
        {
            InitializeComponent();
            panel2.Visible = false;


        }
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.Show();

        }
        

        



        private void buttonSettings_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ViewPetList());
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewVaccinationAlert());
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }

        private void buttonRates_Click_1(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
            }
            else if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }

        private void buttonHotel_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateVetName());
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateVetPhone());
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateVetLocation());
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateVetPassword());
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }
    }
}
