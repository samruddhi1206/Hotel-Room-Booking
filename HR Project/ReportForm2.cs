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
    public partial class ReportForm2 : Form
    {
        public ReportForm2()
        {
            InitializeComponent();
        }

        private void ReportForm2_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();

            ReportDataSource Booking = new ReportDataSource("DataSet1", BookingsDetails());
            reportViewer1.LocalReport.ReportPath = @"C:\Users\samru\OneDrive\Desktop\HR Project\HR Project\Reports\Report2.rdlc";
            reportViewer1.LocalReport.DataSources.Add(Booking);
            reportViewer1.RefreshReport();
        }
        private DataTable BookingsDetails()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=SAMRUDDHI\SQLEXPRESS01;Initial Catalog=HR_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Booking", con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
       
    }
}
