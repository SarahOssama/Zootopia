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
    public partial class ViewRooms : Form
    {
        Controller controllerObj;
        public string HotelUsername = "";
        public ViewRooms(string Username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            HotelUsername = Username;


        }

        private void ButtonViewRooms_Click(object sender, EventArgs e)
        {
            DataTable qt = controllerObj.SelectNumberOfRoomsinHotel(HotelUsername);
            RoomNumTextBox.Text = qt.Rows[0][0].ToString();

            DataTable qt2 = controllerObj.SelectHotelPriceInHotel(HotelUsername);
            RoomPriceTextBox.Text = qt2.Rows[0][0].ToString();
        }
    }
}
