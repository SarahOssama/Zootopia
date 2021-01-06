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
            if (RatesSubMenuPanel.Visible == true)
            {
                RatesSubMenuPanel.Visible = false;
            }
            else if (RatesSubMenuPanel.Visible == false)
            {
                RatesSubMenuPanel.Visible = true;
            }
        }
    }
}
