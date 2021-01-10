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
    public partial class ViewUtilities : Form
    {
        Controller ControllerObj;
        public string Username = "Lollipop";
        public ViewUtilities()
        {
            InitializeComponent();
            ControllerObj = new Controller();
        }

        private void buttonCloseView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonviewUtilities_Click(object sender, EventArgs e)
        {
            

            DataTable dt = ControllerObj.ViewListOfUtilities(Username);
            ViewUtilitiesDataGrid.DataSource = dt;
            ViewUtilitiesDataGrid.Refresh();

        }

        private void ViewUtilitiesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewUtilities_Load(object sender, EventArgs e)
        {

        }
    }
}
