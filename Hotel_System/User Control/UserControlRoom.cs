using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System.User_Control
{
    public partial class UserControlRoom : UserControl
    {
        public UserControlRoom()
        {
            InitializeComponent();
        }

        private void DGVcust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGVRooms.Rows.Add("VIP", "1", "2500");
            DGVRooms.Rows.Add("VIP", "2", "5000");
            DGVRooms.Rows.Add("Single", "1", "500");
            DGVRooms.Rows.Add("Family Suiet", "2", "2000");
            DGVRooms.Rows.Add("Family Suiet", "4", "4000");
            DGVRooms.Rows.Add("Family Suiet", "6", "6000");
            DGVRooms.Rows.Add("Standart", "2", "2000");
            DGVRooms.Rows.Add("Standart", "4", "4000");
            DGVRooms.Rows.Add("Standart", "6", "6000");

        }
    }
}
