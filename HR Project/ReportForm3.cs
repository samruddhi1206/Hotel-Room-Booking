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
    public partial class ReportForm3 : Form
    {
        public ReportForm3()
        {
            InitializeComponent();
        }

        private void ReportForm3_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
        private DataTable StaffDetails()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=SAMRUDDHI\SQLEXPRESS01;Initial Catalog=HR_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Staff Where Staff_ID = '"+ Convert.ToInt32(textBox1.Text)+ "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDataSource Staff = new ReportDataSource("DataSet1", StaffDetails());
            reportViewer1.LocalReport.ReportPath = @"C:\Users\samru\OneDrive\Desktop\HR Project\HR Project\Reports\Report3.rdlc";
            reportViewer1.LocalReport.DataSources.Add(Staff);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", StaffDetails()));
            reportViewer1.RefreshReport();
        }

      
    }
}
