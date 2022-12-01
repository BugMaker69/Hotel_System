using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace Hotel_System
{
   

    public partial class FormDashBoard : Form
    {
        
        public FormDashBoard()
        {
            InitializeComponent();
        }
        //SqlConnection conn = new SqlConnection();
        
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pnlSlide_Move(object sender, EventArgs e)
        {

        }

        private void MovePanel(Control btn)
        {
            pnlSlide.Top = btn.Top;
            pnlSlide.Height = btn.Height;
        }

        private void linkLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show
               ("Are you sure?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            MovePanel(btnBook);
            userControlBooking1.clear();
            userControlBooking1.Show();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            
        }

        private void btnCust_Click(object sender, EventArgs e)
        {
            MovePanel(btnCust);
            userControlBooking1.Hide();
            userControlClient1.Show();
            userControlRoom1.Hide();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            MovePanel(btnEmp);
            userControlBooking1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            MovePanel(btnRoom);
            userControlBooking1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
               ("Are you sure?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        private void DGVcust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_Enter(object sender, EventArgs e)
        {

        }

        private void userControlBooking1_Load(object sender, EventArgs e)
        {

        }
    }
}
