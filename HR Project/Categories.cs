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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }
        //Connection String
        SqlConnection con = new SqlConnection(@"Data Source=SAMRUDDHI\SQLEXPRESS01;Initial Catalog=HR_Database;Integrated Security=True");
        public int Category_ID;

        private void Categories_Load(object sender, EventArgs e)
        {
            GetCategoryRecord();
            AutomaticID();
        }
        private void AutomaticID() //For Generate Automatic Category_ID
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select max(Category_ID) from Categories", con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int Category_ID = Convert.ToInt32(dr[0]);
                Category_ID++;
                textBox1.Text = Category_ID.ToString();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Exception", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void GetCategoryRecord() //For Datagrid View
        {
           
            SqlCommand cmd = new SqlCommand("Select * from Categories", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            CategoryRecord.DataSource = dt;
        }
        
        private void Insert_Click(object sender, EventArgs e)  // Insert Botton
        {
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Categories Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Rate Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            }
           else
           {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Categories VALUES(@Categories, @Rate)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Categories", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Rate", textBox3.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Category Inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetCategoryRecord();
                    ResetForm();
                    AutomaticID();
           }
           
        }

        private void ResetForm()  // For Reset Textboxes
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox2.Focus();
        }
        private void Reset_Click(object sender, EventArgs e)  // Reset Button
        {
            ResetForm();
        }

        private void Search_Click(object sender, EventArgs e) // Search Button
        {
            con.Open();
            if (textBox1.Text != "")
            {
                SqlCommand cmd = new SqlCommand("SELECT Categories ,Rate from Categories WHERE Category_ID = @Category_ID", con);
                cmd.Parameters.AddWithValue("@Category_ID", int.Parse(textBox1.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    textBox2.Text = da.GetValue(0).ToString();
                    textBox3.Text = da.GetValue(1).ToString();
                }
                con.Close();
            }
        }

        private void CategoryRecord_CellClick(object sender, DataGridViewCellEventArgs e) //Cell Click For Select Record 
        {
            Category_ID = Convert.ToInt32(CategoryRecord.SelectedRows[0].Cells[0].Value);
            textBox1.Text = CategoryRecord.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = CategoryRecord.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = CategoryRecord.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)  // Delete Button
        {
            if (Category_ID > 0)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Categories WHERE Category_ID=@Category_ID", con);
                cmd.CommandType = CommandType.Text;
                
                cmd.Parameters.AddWithValue("@Category_ID", this.Category_ID);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCategoryRecord();
                ResetForm();
                AutomaticID();
            }
            else
            {
                MessageBox.Show("Please select valid record to delete", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e) // Update Button
        {
            if (textBox2.Text == string.Empty || textBox3.Text == "")
            {
                MessageBox.Show("Something Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Category_ID > 0)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Categories SET Categories = @Categories, Rate = @Rate WHERE Category_ID=@Category_ID", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Categories", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Rate", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Category_ID", this.Category_ID);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetCategoryRecord();
                    ResetForm();
                    AutomaticID();
                }
                else
                {
                    MessageBox.Show("Please select valid record to update", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
  
    }
}
