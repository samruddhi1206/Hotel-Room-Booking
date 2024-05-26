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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SAMRUDDHI\SQLEXPRESS01;Initial Catalog=HR_Database;Integrated Security=True");
        String type;
        public Main(String s)
        {
            InitializeComponent();
            type = s;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            CountUser();
            CountCategories();
            CountAdmin();
            if (type == "User")
            {
                button2.Hide();
                button10.Hide();
                button5.Hide();
            }
            else
            {
                button11.Hide();
            }
            timer1.Start();
            label5.Text = Class1.uname;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Rooms frm = new Rooms();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Categories frm = new Categories();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer frm = new Customer();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bookings frm = new Bookings();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Staff frm = new Staff();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Main frm = new Main();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Analytics frm = new Analytics();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Reports frm = new Reports();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            User frm = new User();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.label4.Text = dateTime.ToString();
        }
        private void CountUser()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from UserLogin Where UserType='User'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblUser.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
        private void CountAdmin()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from UserLogin Where UserType='Admin'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblAdmin.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
        private void CountCategories()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from Categories", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblCategories.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
       
        private void button11_Click(object sender, EventArgs e)
        {
            ReportForm1 frm = new ReportForm1();
            frm.Show();
        }

        
    }
}
