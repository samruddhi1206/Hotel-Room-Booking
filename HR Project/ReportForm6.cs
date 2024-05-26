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
    public partial class DateWise_Bookings : Form
    {
        public DateWise_Bookings()
        {
            InitializeComponent();
        }

        private void DateWise_Bookings_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDataSource DateWise_Booking = new ReportDataSource("DataSet1", DateWise());
            reportViewer1.LocalReport.ReportPath = @"C:\Users\samru\OneDrive\Desktop\HR Project - Copy\HR Project\Reports\Report6.rdlc";
            reportViewer1.LocalReport.DataSources.Add(DateWise_Booking);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", DateWise()));
            reportViewer1.RefreshReport();
        }
        private DataTable DateWise()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=SAMRUDDHI\SQLEXPRESS01;Initial Catalog=HR_Database;Integrated Security=True");
            con.Open();
           
            SqlCommand cmd = new SqlCommand("SELECT * FROM Booking where Date_In BETWEEN '"+dateTimePicker1.Text+"'and '"+ dateTimePicker2.Text+"' order by Date_In asc",con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
    }
}
