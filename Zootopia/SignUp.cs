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
    public partial class SignUp : Form
    {
        Controller controllerObj;
        public SignUp()
        {
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (username_textbox.Text == "" || password_textbox.Text == "")
            {
                MessageBox.Show("Please enter username and password");
            }
            else
            {

                DataTable us = controllerObj.SelectUsername(username_textbox.Text);
                if (us == null)
                {
                    MessageBox.Show("Invalid username");

                }
                else
                {
                    string usern = us.Rows[0][0].ToString();

                    DataTable pass = controllerObj.SelectPasswordByUsername(usern);
                    string passString = pass.Rows[0][0].ToString();
                    if (passString == password_textbox.Text)
                    {

                        if (usern.StartsWith("OW-"))
                        {
                            PetOwnerView V = new PetOwnerView();
                            V.Show();
                        }
                        if (usern.StartsWith("PT-"))
                        {
                            PetShopOwnerView V = new PetShopOwnerView();
                            V.Show();
                        }
                        if (usern.StartsWith("HT-"))
                        {
                            HotelOwnerView V = new HotelOwnerView();
                            V.Show();
                        }
                        if (usern.StartsWith("VT-"))
                        {
                            VetView vet = new VetView();
                            vet.Show();
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password");
                    }
                   
                }

            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AdminLogInButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminView A = new AdminView();
            A.Show();
        }

        private void SignUpButtom_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateAccount a = new CreateAccount();
            a.Show();

        }
    }
}
