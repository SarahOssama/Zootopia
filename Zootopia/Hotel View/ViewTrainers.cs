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
    public partial class ViewTrainers : Form
    {
        Controller controllerObj;
        public ViewTrainers()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void ButtonViewTrainer_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllTrainers();
            ViewTrainersDataGrid.DataSource = dt;
            ViewTrainersDataGrid.Refresh();
        }
    }
}
