using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using System.Data.SqlClient;

namespace Hotel_System.User_Control
{
    public partial class UserControlBooking : UserControl
    {

        public UserControlBooking()
        {
            InitializeComponent();
        }


        double cost;
     
        



        //SqlConnection conn = new SqlConnection();

        public void clear()
        {
            txtUser.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtCity.Clear();

            tabControl1.SelectedTab = tabReserv;
        }
        private void tabView_Enter(object sender, EventArgs e)
        {
            Search.Clear();
        }
        private void tabView_Leave(object sender, EventArgs e)
        {
            Search.Clear();
        }

        private void DGVcust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //code for disply from database
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //here is the code for submit after connect the database :)
            
            DGVcust.Rows.Add(txtUser.Text, txtName.Text, comRoom.Text, dateIn.Value, dateOut.Value);

            clear();
            MessageBox.Show("The Date Added Successfully..");

        }

        private void DGVcust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = DGVcust.Rows[e.RowIndex];
                txtUser.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                comRoom.Text = row.Cells[2].Value.ToString();
                dateIn.Text = row.Cells[3].Value.ToString();
                dateOut.Text = row.Cells[4].Value.ToString();
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            //disply from database
        }

        private void tabReserv_Leave(object sender, EventArgs e)
        {
            clear();
        }


        private void comRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comRoom.SelectedIndex == 0)
            {

                 cost = 2000;
                lblCost.Text = cost.ToString();
                panel1.Show();
            }

            if (comRoom.SelectedIndex == 1)
            {
                panel1.Hide();
                 cost = 500;
                lblCost.Text = cost.ToString();
            }

            if (comRoom.SelectedIndex == 2)
            {
                cost = 1500;
                lblCost.Text = cost.ToString();
               
                panel1.Show();
            }

            if (comRoom.SelectedIndex == 3)
            {
                cost = 5000;
                lblCost.Text = cost.ToString();
               
                panel1.Show();
                numInd.Maximum = 2;
            }
    
        }

      

     

        public void dateOut_ValueChanged(object sender, EventArgs e)
        {
            
           string durationStay = Math.Round((dateOut.Value - dateIn.Value).TotalDays).ToString();
            durationlabl.Text = durationStay;

   



        }



        private void durationlabl_TextChanged(object sender, EventArgs e)
        {

            double totalcost = (double.Parse(durationlabl.Text) * cost);
            lblCost.Text = totalcost.ToString()+" L.E";



        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            tabReserv.Show();
        }

        private void tabReserv_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void uploadphoto_FileOk(object sender, CancelEventArgs e)
        {
          
        }

    

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtName.Text,new Font("Tahoma",16),Brushes.Blue,10,10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void uploadphoto_Click(object sender, EventArgs e)
        {
            string chosenfile = "";
            uploadphoto.InitialDirectory = "C:";
            uploadphoto.Title = "choose photo";
            uploadphoto.FileName = "";
            uploadphoto.Filter = "JPEG|*jpg";
            if (uploadphoto.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("cancelled");
            }
            else
            {

                chosenfile = uploadphoto.FileName;
                pictureBox1.Image = Image.FromFile(chosenfile);
            }
        }
    }
}
