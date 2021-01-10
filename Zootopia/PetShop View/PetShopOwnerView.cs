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
    public partial class PetShopOwnerView : Form
    {
        public PetShopOwnerView()
        {
            InitializeComponent();
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
        private void PetShopOwnerView_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAddUtility_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddUtility());
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewUtilities());
        }

        private void buttonDeleteUtility_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeleteUtility());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateUtility());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddUtilityToShop());
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
