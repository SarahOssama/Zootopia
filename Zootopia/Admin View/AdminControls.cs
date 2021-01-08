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
    public partial class AdminControls : Form
    {
        public AdminControls()
        {
            InitializeComponent();
            SettingsSubMenuPanel.Visible = false;
            RatesSubMenuPanel.Visible = false;

            
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
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if(SettingsSubMenuPanel.Visible==true)
            {
                SettingsSubMenuPanel.Visible = false;
            }

           else if (SettingsSubMenuPanel.Visible == false)
            {
                SettingsSubMenuPanel.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(RatesSubMenuPanel.Visible==true)
            {
                RatesSubMenuPanel.Visible = false;
            }
            else if (RatesSubMenuPanel.Visible == false)
            {
                RatesSubMenuPanel.Visible = true;
            }
        }

        private void buttonSettings_Click_1(object sender, EventArgs e)
        {
            if (RatesSubMenuPanel.Visible == true)
            {
                RatesSubMenuPanel.Visible = false;
            }

            if (SettingsSubMenuPanel.Visible == true)
            {
                SettingsSubMenuPanel.Visible = false;
            }

            else if (SettingsSubMenuPanel.Visible == false)
            {
                SettingsSubMenuPanel.Visible = true;
            }
        }

        private void buttonRates_Click(object sender, EventArgs e)
        {
            if (SettingsSubMenuPanel.Visible == true)
            {
                SettingsSubMenuPanel.Visible = false;
            }
            if (RatesSubMenuPanel.Visible == true)
            {
                RatesSubMenuPanel.Visible = false;
            }
            else if (RatesSubMenuPanel.Visible == false)
            {
                RatesSubMenuPanel.Visible = true;
            }

        }

        private void AdminControls_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateAdmin());

            if (SettingsSubMenuPanel.Visible == true)
            {
                SettingsSubMenuPanel.Visible = false;
            }
        }

        private void buttonHotel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewHotelRates());
            if (RatesSubMenuPanel.Visible == true)
            {
                RatesSubMenuPanel.Visible = false;
            }
        }

        private void buttonPS_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewPetShopsRates());
            if (RatesSubMenuPanel.Visible == true)
            {
                RatesSubMenuPanel.Visible = false;
            }
        }

        private void buttonVet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewVetsRates());
            if (RatesSubMenuPanel.Visible == true)
            {
                RatesSubMenuPanel.Visible = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddAdmin());

            if (SettingsSubMenuPanel.Visible == true)
            {
                SettingsSubMenuPanel.Visible = false;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RemoveAdmin());

            if (SettingsSubMenuPanel.Visible == true)
            {
                SettingsSubMenuPanel.Visible = false;
            }
        }
    }
}
