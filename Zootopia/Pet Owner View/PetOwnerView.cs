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
    public partial class PetOwnerView : Form
    {
        public PetOwnerView()
        {
            InitializeComponent();
        }

        private void hideSubMenu()
        {
            if (panelPetDetailsSubMenu.Visible == true)
                panelPetDetailsSubMenu.Visible = false;

            if (panelSearchSubMenu.Visible == true)
                panelSearchSubMenu.Visible = false;

            if (panelHotelServicesSubMenu.Visible == true)
                panelHotelServicesSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel SubMenu )
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        {
            ShowSubMenu(panelPetDetailsSubMenu);
        }

        private void buttonInsertPet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InsertPet());
            //code
            hideSubMenu();
        }

        private void buttonUpdatePet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdatePet());
            //code
            hideSubMenu();
        }

        private void buttonDeletePet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeletePet());
            //code
            hideSubMenu();
        }

        private Form activeForm  = null;
        private void OpenChildForm(Form childForm)
        {
            //.Visible = false;
            //panelSubChildDown.Visible = false;
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
      


            #region SearchSubMenu
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSearchSubMenu);
        }

        private void ButtonHotelSearch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HotelSearch());
            //code
            hideSubMenu();
        }

        private void ButtonPetShopSearch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PetShopSearch());
            //code
            hideSubMenu();
        }

        private void ButtonVetSearch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new VetSearch());
            //code
            hideSubMenu();
        }
        #endregion

        #region HotelServicesSubMenu

        private void ButtonHotelServices_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelHotelServicesSubMenu);
        }

        private void ButtonTrainer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReserveTrainer());
            //code
            hideSubMenu();
        }

        private void ButtonReserve_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReserveRoom());
            //code
            hideSubMenu();
        }
        #endregion

        private void buttonMatting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MatingPet());
            //code
            hideSubMenu();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(panelPetShopServices);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Utilities ());
            //code
            hideSubMenu();
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
