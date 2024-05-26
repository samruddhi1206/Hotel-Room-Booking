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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        //Connection String
        SqlConnection con = new SqlConnection(@"Data Source=SAMRUDDHI\SQLEXPRESS01;Initial Catalog=HR_Database;Integrated Security=True");
        public int Staff_ID;

        private void Staff_Load(object sender, EventArgs e)
        {
            GetStaffRecord();
            AutomaticID();
        }
        private void AutomaticID()  //For Generate Automatic Staff_ID
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select max(Staff_ID) from Staff", con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int Staff_ID = Convert.ToInt32(dr[0]);
            Staff_ID++;
            textBox1.Text = Staff_ID.ToString();
            con.Close();
        }
        private void GetStaffRecord() //For Datagrid View
        {
            SqlCommand cmd = new SqlCommand("Select * from Staff", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            StaffRecord.DataSource = dt;
        }

        private void Insert_Click(object sender, EventArgs e) //Insert Button
        {
           
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Name Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Mobile Number Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Address Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Gender Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Work Position Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Focus();
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("Salary Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox6.Focus();
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Staff VALUES(@Staff_ID, @Name, @Mobile, @Address, @Gender,@Work_Position,@Salary)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Staff_ID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Mobile", textBox3.Text);
                cmd.Parameters.AddWithValue("@Address", textBox4.Text);
                cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Work_Position", textBox5.Text);
                cmd.Parameters.AddWithValue("@Salary", textBox6.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStaffRecord();
                ResetForm();
            }
        }
        private void ResetForm() // For Reset TextBox
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            AutomaticID();
            textBox2.Focus();
        }

        private void StaffRecord_CellClick(object sender, DataGridViewCellEventArgs e) //Cell Click For Select Record 
        {
            Staff_ID = Convert.ToInt32(StaffRecord.SelectedRows[0].Cells[0].Value);
            textBox1.Text = StaffRecord.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = StaffRecord.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = StaffRecord.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = StaffRecord.SelectedRows[0].Cells[3].Value.ToString();
            comboBox1.Text = StaffRecord.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = StaffRecord.SelectedRows[0].Cells[5].Value.ToString();
            textBox6.Text = StaffRecord.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void update_Click(object sender, EventArgs e) // Update Button
        {
            if (textBox2.Text == string.Empty | textBox3.Text == "" | textBox4.Text == "" | comboBox1.Text == "" | textBox5.Text == "" | textBox6.Text == "")
            {
                MessageBox.Show("Something Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Staff_ID > 0)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Staff SET Name = @Name,Mobile = @Mobile, Address=@Address,Gender=@Gender,Work_Position=@Work_Position,Salary = @Salary WHERE Staff_ID=@Staff_ID", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Mobile", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Address", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Work_Position", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Salary", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Staff_ID", this.Staff_ID);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetStaffRecord();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Please select valid record to update", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e) // Delete Button
        {
            if (Staff_ID > 0)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Staff WHERE Staff_ID=@Staff_ID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Staff_ID", this.Staff_ID);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStaffRecord();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Please select valid record to delete", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset_Click(object sender, EventArgs e) // Reset Button
        {
            ResetForm();
        }

        private void button1_Click(object sender, EventArgs e) //Search Name and only those record view in Datagrid
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Staff where Name like '%" +textBox2.Text+"%'",con);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            StaffRecord.DataSource = dt;
            con.Close();
        }

          
    }
}
