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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SAMRUDDHI\SQLEXPRESS01;Initial Catalog=HR_Database;Integrated Security=True");

        private void User_Load(object sender, EventArgs e)
        {
            GetUserRecord();
            AutomaticID();
        }
        private void GetUserRecord() //For Datagrid View
        {
            SqlCommand cmd = new SqlCommand("Select * from UserLogin", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            UserRecord.DataSource = dt;
        }
        private void AutomaticID()  //For Generate Automatic User_ID
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select max(User_ID) from UserLogin", con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int User_ID = Convert.ToInt32(dr[0]);
            User_ID++;
            textBox1.Text = User_ID.ToString();
            con.Close();
        }
        private void Insert_Click(object sender, EventArgs e)  //Insert Button
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
                MessageBox.Show("User Name Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Focus();
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("Password Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox6.Focus();
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("User Type Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox6.Focus();
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into UserLogin values(@User_ID,@Name,@Mobile,@Address,@Gender,@Username,@Password,@UserType)", con);

                cmd.Parameters.AddWithValue("@User_ID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Mobile", textBox3.Text);
                cmd.Parameters.AddWithValue("@Address", textBox4.Text);
                cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Username", textBox5.Text);
                cmd.Parameters.AddWithValue("@Password", textBox6.Text);
                cmd.Parameters.AddWithValue("@UserType", comboBox2.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User Record Inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetUserRecord();
                ResetForm();
            }
            
        }
        private void ResetForm() // For Reset TextBox
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            AutomaticID();
            textBox2.Focus();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        public int User_ID;
        private void UserRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            User_ID = Convert.ToInt32(UserRecord.SelectedRows[0].Cells[0].Value);
            textBox1.Text = UserRecord.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = UserRecord.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = UserRecord.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = UserRecord.SelectedRows[0].Cells[3].Value.ToString();
            comboBox1.Text = UserRecord.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = UserRecord.SelectedRows[0].Cells[5].Value.ToString();
            textBox6.Text = UserRecord.SelectedRows[0].Cells[6].Value.ToString();
            comboBox2.Text = UserRecord.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)  //Update Button
        {
            if (textBox2.Text == "" | textBox3.Text == "" | textBox4.Text == "" | comboBox1.Text == "" | textBox5.Text == "" | textBox6.Text == "" | comboBox2.Text == "")
            {
                MessageBox.Show("Something Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(User_ID>0)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update UserLogin set Name = @Name,Mobile = @Mobile, Address=@Address,Gender=@Gender,Username=@Username,Password=@Password,UserType=@UserType WHERE User_ID=@User_ID", con);

                    cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Mobile", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Address", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Username", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox6.Text);
                    cmd.Parameters.AddWithValue("@UserType", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@User_ID", this.User_ID);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User Record Updated", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetUserRecord();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Please select valid record to update", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e) //Delete Button
        {
            if (User_ID > 0)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM UserLogin WHERE User_ID=@User_ID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@User_ID", this.User_ID);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetUserRecord();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Please select valid record to delete", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)  //Search Name and only those record view in Datagrid
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from UserLogin where Name like '%" + textBox2.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            UserRecord.DataSource = dt;
            con.Close();
        }

    }
}
