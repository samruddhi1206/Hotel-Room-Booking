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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        //Connection String
        SqlConnection con = new SqlConnection(@"Data Source=SAMRUDDHI\SQLEXPRESS01;Initial Catalog=HR_Database;Integrated Security=True");

        public int Customer_ID;

        private void Customer_Load(object sender, EventArgs e)
        {
            GetCustomerRecord();
            AutomaticID();
        }
        private void GetCustomerRecord() //For Datagrid View
        {

            SqlCommand cmd = new SqlCommand("Select * from Customer", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            CustomerRecord.DataSource = dt;
        }

        private void CustomerRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer_ID = Convert.ToInt32(CustomerRecord.SelectedRows[0].Cells[0].Value);
            textBox1.Text = CustomerRecord.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = CustomerRecord.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = CustomerRecord.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = CustomerRecord.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = CustomerRecord.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void AutomaticID() //For Generate Automatic Category_ID
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select max(Customer_ID) from Customer", con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                Customer_ID = Convert.ToInt32(dr[0]);
                Customer_ID++;
                textBox1.Text = Customer_ID.ToString();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Exception", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ResetForm()  // For Reset Textboxes
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox2.Focus();
            
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetForm();
            AutomaticID();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Name Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Mobile Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Address Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Member Count Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Focus();
            }
            else
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Customer VALUES(@Name, @Mobile, @Address, @Member)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Mobile", textBox3.Text);
                cmd.Parameters.AddWithValue("@Address", textBox4.Text);
                cmd.Parameters.AddWithValue("@Member", textBox5.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCustomerRecord();
                ResetForm();
                AutomaticID();
            }
        }

        private void Delete_Click(object sender, EventArgs e) // Delete Button
        {
            if (Customer_ID > 0)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Customer WHERE Customer_ID=@Customer_ID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Customer_ID", this.Customer_ID);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCustomerRecord();
                ResetForm();
                
            }
            else
            {
                MessageBox.Show("Please select valid record to delete", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e) // Update or Modify Button
        {
            if (textBox2.Text == "" | textBox3.Text == "" | textBox4.Text == "" | textBox5.Text == "")
            {
                MessageBox.Show("Something Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Customer_ID > 0)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Customer SET Name = @Name, Mobile = @Mobile, Address=@Address, Member=@Member WHERE Customer_ID=@Customer_ID", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Mobile", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Address", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Member", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Customer_ID", this.Customer_ID);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetCustomerRecord();
                    ResetForm();
                    AutomaticID();
                }
                else
                {
                    MessageBox.Show("Please select valid record to update", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Search_Click(object sender, EventArgs e) //Search Name and only those record view in Datagrid
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Customer where Name like '%" + textBox2.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            CustomerRecord.DataSource = dt;
            con.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
