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
    public partial class ViewPetList : Form
    {
        Controller controllerObj;
        public string CurrentUser;
        public string Name;
        public ViewPetList(string username)
        {
            controllerObj = new Controller();
            InitializeComponent();
            Name = username;
        }

        private void buttonCloseViewUtilities_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ViewPetList(Name);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            VetView.ActiveForm.Close();
            Welcome.ActiveForm.Close();
            
        }

        private void ViewPetList_Load(object sender, EventArgs e)
        {
            
        }

        private void ViewPetList_LocationChanged(object sender, EventArgs e)
        {
            this.Location = new Point(100, 200);
        }
    }
}
