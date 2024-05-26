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
    public partial class ReportForm1 : Form
    {
        public ReportForm1()
        {
            InitializeComponent();
        }

        private void ReportForm1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

            ReportDataSource Categories = new ReportDataSource("DataSet1", CategoriesDetails());
            reportViewer1.LocalReport.ReportPath = @"C:\Users\samru\OneDrive\Desktop\HR Project\HR Project\Reports\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(Categories);
            reportViewer1.RefreshReport();
        }
        private DataTable CategoriesDetails()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=SAMRUDDHI\SQLEXPRESS01;Initial Catalog=HR_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Categories", con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
