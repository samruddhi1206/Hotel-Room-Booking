using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace HR_Project
{
    public partial class BillingForm : Form
    {
        public BillingForm()
        {
            InitializeComponent();
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {

        }
        private DataTable GenerateBill()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=SAMRUDDHI\SQLEXPRESS01;Initial Catalog=HR_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Booking.Booking_ID, Customer.Name, Booking.Date_In, Booking.Date_Out, Booking.Duration, Booking.Amount FROM Booking INNER JOIN Customer ON Booking.Customer_ID = Customer.Customer_ID where Booking_ID = '" + Convert.ToInt32(textBox1.Text) + "'", con);


            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDataSource Bill = new ReportDataSource("DataSet1", GenerateBill());
            reportViewer1.LocalReport.ReportPath = @"C:\Users\samru\OneDrive\Desktop\HR Project - Copy\HR Project\Reports\Report7.rdlc";
            reportViewer1.LocalReport.DataSources.Add(Bill);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", GenerateBill()));
            reportViewer1.RefreshReport();
        }
    }
}
