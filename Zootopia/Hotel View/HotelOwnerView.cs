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
    public partial class HotelOwnerView : Form
    {
        public HotelOwnerView()
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddTrainerButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddTrainer());
        }

        private void ViewTrainerButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewTrainers());
        }

        private void DeleteTrainerButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeleteTrainer());
        }

        private void ViewRoomButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewRooms());
        }
    }
}
