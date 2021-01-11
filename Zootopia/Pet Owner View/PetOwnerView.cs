﻿using System;
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
        Controller controllerObj;
        public string username;
        public PetOwnerView(string name)
        {
            controllerObj = new Controller();
            InitializeComponent();
            button7.Visible = false;
            textBox1.Visible = false;
            username = name;
            DataTable dt = controllerObj.Selectmessage(username);
            if (dt != null)
            {
                button7.Visible = true;
            }
        }

        private void hideSubMenu()
        {
            if (panelPetDetailsSubMenu.Visible == true)
                panelPetDetailsSubMenu.Visible = false;

            if (panelSearchSubMenu.Visible == true)
                panelSearchSubMenu.Visible = false;

            if (panelHotelServicesSubMenu.Visible == true)
                panelHotelServicesSubMenu.Visible = false;

            if (panelRatesubPanel.Visible==true)
                panelRatesubPanel.Visible = false;

            
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
            panelSubChildUP.Visible = false;
            panelSubChildDown.Visible = false;
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
        private Form activeSubForm = null;
        private void OpenSubChildForm(Form childForm)
        {
            panelSubChildUP.Visible = true;
            panelSubChildDown.Visible = true;
            if (activeSubForm != null)
                activeSubForm.Close();
            activeSubForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelSubChildUP.Controls.Add(childForm);
            panelSubChildUP.Tag = childForm;
            childForm.Show();

        }

        private Form activeSubFormDown = null;
        private void OpenSubChildFormDown(Form childForm)
        {
            panelSubChildUP.Visible = true;
            panelSubChildDown.Visible = true;
            if (activeSubFormDown != null)
                activeSubFormDown.Close();
            activeSubFormDown = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelSubChildDown.Controls.Add(childForm);
            panelSubChildDown.Tag = childForm;
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
            OpenSubChildForm(new ReserveTrainer());
            //code
           // hideSubMenu();
        }

        private void ButtonReserve_Click(object sender, EventArgs e)
        {
            OpenSubChildFormDown(new ReserveRoom());
            //code
           // hideSubMenu();
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

        private void panelSubChildUP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelPetShopServices_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelRatesubPanel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
           OpenChildForm(new RateVet());
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RateHotel());
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RateTrainer());
            hideSubMenu();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == false)
            {
                DataTable md = controllerObj.Selectmessage(username);
                string message = md.Rows[0][0].ToString();
                textBox1.Visible = true;
                textBox1.Text = message;
                int r = controllerObj.UpdateNotified(username);
            }
            else
            {
                button7.Visible = false;
                textBox1.Visible = false;
            }

        }
    }
}
