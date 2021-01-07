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
    public partial class InsertPet : Form
    {
        public InsertPet()
        {
            InitializeComponent();
        }

        private void buttonCloseInsert_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
