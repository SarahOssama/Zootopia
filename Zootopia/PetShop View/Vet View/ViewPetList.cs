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
    public partial class ViewPetList : Form
    {
        public ViewPetList()
        {
            InitializeComponent();
        }

        private void buttonCloseViewUtilities_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
