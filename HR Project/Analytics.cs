using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HR_Project
{
    public partial class Analytics : Form
    {
        public Analytics()
        {
            InitializeComponent();
        }
        //Connection String
        SqlConnection con = new SqlConnection(@"Data Source=SAMRUDDHI\SQLEXPRESS01;Initial Catalog=HR_Database;Integrated Security=True");

        private void Analytics_Load(object sender, EventArgs e)
        {
            CountRooms();
            TotalAmount();
            CountBookedRooms();
            CountAvailableRooms();
        }
        private void CountRooms()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from Rooms", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblRoom.Text = dt.Rows[0][0].ToString() + " Rooms";
            con.Close();
        }
        private void CountBookedRooms()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from Rooms Where Status='Booked'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblbooked.Text = dt.Rows[0][0].ToString() + " Rooms";
            con.Close();
        }
        private void TotalAmount()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select sum(Amount) from Booking", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblAmt.Text = "Rs."+dt.Rows[0][0].ToString();
            con.Close();
        }
        private void CountAvailableRooms()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from Rooms Where Status='Available'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblAvaRoom.Text = dt.Rows[0][0].ToString() + " Rooms";
            con.Close();
        }

        private void lblRoom_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
