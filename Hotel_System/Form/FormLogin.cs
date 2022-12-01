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
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }
        //SqlConnection conn = new SqlConnection();
        private void picShow_Click(object sender, EventArgs e)
        {
            picShow.Hide();
            txtboxPass.UseSystemPasswordChar = false;
            picHide.Show();
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            picHide.Hide();
            txtboxPass.UseSystemPasswordChar = true;
            picShow.Show();
        }

        private void picShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picShow, "Show Password");
        }

        private void picHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picShow, "Hide Password");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // bool check = false; 
            //this code inside bool instade of false 
            /*conn.IsValidNamePass(txtboxUsername.Text.Trim(), txtboxPass.Text.Trim()) */

            if (txtboxUsername.Text.Trim() == String.Empty || txtboxPass.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please fill out all fied!", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                FormDashBoard fd = new FormDashBoard();
                fd.Show();
                /* if(check)
                 {
                    FormDashBoard fd = new FormDashBoard();
                fd.Show();
                 }
                 else
                 {
                     //MessageBox.Show("Invalid Username or password", "Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }*/
            }
        }
    }
}