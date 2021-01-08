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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            SignUp s = new SignUp();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonPetOwner.Checked == true)
            {
                CreatePetOwner o = new CreatePetOwner();
                o.Show();
            }
            if (radioButtonPetShopOwner.Checked == true)
            {
                CreatePetShop V = new CreatePetShop();
                V.Show();
            }
            if (radioButtonHotelOwner.Checked == true)
            {
                CreateHotel V = new CreateHotel();
                V.Show();
            }
            if (VetRadioButton.Checked == true)
            {
                CreateVet vet = new CreateVet();
                vet.Show();
            }
            this.Close();
        }
    }
}
