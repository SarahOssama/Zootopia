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
    public partial class UpdateVetPhone : Form
    {
        public UpdateVetPhone()
        {
            InitializeComponent();
            label8.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 11)
            {
                label8.Show();
            }
            else if (textBox1.TextLength == 11)
            {
                label8.Visible = false;
            }
        }

        private void buttonCloseViewUtilities_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
