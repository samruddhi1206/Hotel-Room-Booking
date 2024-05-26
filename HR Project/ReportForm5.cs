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
    public partial class ReportForm5 : Form
    {
        public ReportForm5()
        {
            InitializeComponent();
        }

        private void ReportForm5_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        private DataTable UserDetails()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=SAMRUDDHI\SQLEXPRESS01;Initial Catalog=HR_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from UserLogin Where Name like '%" + textBox1.Text + "%' AND Mobile = '" + textBox2.Text + "' ", con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDataSource UserLogin = new ReportDataSource("DataSet1", UserDetails());
            reportViewer1.LocalReport.ReportPath = @"C:\Users\samru\OneDrive\Desktop\HR Project - Copy\HR Project\Reports\Report5.rdlc";
            reportViewer1.LocalReport.DataSources.Add(UserLogin);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", UserDetails()));
            reportViewer1.RefreshReport();
        }
    }
}
