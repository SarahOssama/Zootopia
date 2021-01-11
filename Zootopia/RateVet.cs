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
    public partial class RateVet : Form
    {
        Controller ControllerObj ;
        public string username = "Sandy";
        public RateVet()
        {
            InitializeComponent();
            ControllerObj = new Controller();

        }

        private void buttonCloseDeletePet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRate_Click(object sender, EventArgs e)
        {
            int owner_Id = ControllerObj.SelectOwnerId_FromUsername(username);
            int VID = ControllerObj.SelectVetIDFromUserName(username);
            int result = ControllerObj.UpdateVetRate(VID);
            int result1  = ControllerObj.VetRate((double)numericUpDown1.Value, owner_Id);
            if (result == 0 && result1==0)
            {
                MessageBox.Show("Rating failed");
            }
            else
            {
                MessageBox.Show("Rated successfully!");
            }

        }
    }
}
