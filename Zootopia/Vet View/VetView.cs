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
        public string myname;
        
        public VetView( string name)
        {
            InitializeComponent();
            panel2.Visible = false;
            
            myname = name;

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

        private void VetView_Load(object sender, EventArgs e)
        {
            
        }




        private void buttonSettings_Click_1(object sender, EventArgs e)
        {
           
            OpenChildForm(new ViewPetList(myname));
                       
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewVaccinationAlert(myname));
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
            OpenChildForm(new UpdateVetName(myname));
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateVetPhone(myname));
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateVetLocation(myname));
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateVetPassword(myname));
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }

        private void VetView_LocationChanged(object sender, EventArgs e)
        {
            //this.Location = new Point(150, 100);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateVetUsername(myname));
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }
    }
}
