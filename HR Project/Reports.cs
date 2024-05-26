using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HR_Project
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        private void CategoryReport_Click(object sender, EventArgs e)
        {
            ReportForm1 frm = new ReportForm1();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)  // Bookings Report Button
        {
            ReportForm2 frm = new ReportForm2();
            frm.Show();
        }

        private void StaffReport_Click(object sender, EventArgs e)
        {
            ReportForm3 frm = new ReportForm3();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportForm5 frm = new ReportForm5();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateWise_Bookings frm = new DateWise_Bookings();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BillingForm frm = new BillingForm();
            frm.Show();
        }

       

    }
}
