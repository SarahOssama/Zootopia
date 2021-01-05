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

    }
}
