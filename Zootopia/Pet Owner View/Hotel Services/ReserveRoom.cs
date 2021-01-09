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
    public partial class ReserveRoom : Form
    {
        Controller controllerObj;
        public ReserveRoom()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectAllHotelName();
            ReserveRoomHotelNameComboBox.DataSource = dt;
            ReserveRoomHotelNameComboBox.DisplayMember = "HName";
        }

        private void ReserveRoom_Load(object sender, EventArgs e)
        {

        }

        private void ReserveRoomButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReserveRoomHotelNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
