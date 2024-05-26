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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }
        //Connection String
        SqlConnection con = new SqlConnection(@"Data Source=SAMRUDDHI\SQLEXPRESS01;Initial Catalog=HR_Database;Integrated Security=True");
        public int Room_ID;
 
        private void Rooms_Load(object sender, EventArgs e)
        {
            GetRoomRecord();
            AutomaticID();
            CategoryComboBox();
        }
        private void GetRoomRecord() //For Datagrid View
        {

            SqlCommand cmd = new SqlCommand("Select * from Rooms", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            RoomRecord.DataSource = dt;
        }
        private void AutomaticID() //For Generate Automatic Category_ID
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select max(Room_ID) from Rooms", con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int Room_ID = Convert.ToInt32(dr[0]);
                Room_ID++;
                textBox1.Text = Room_ID.ToString();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Exception", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private void CategoryComboBox()  // Add items in combobox list from category table
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Category_ID , Categories from Categories", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CategoryList.Items.Add(dr["Category_ID"].ToString());
                CategoryList.DisplayMember = (dr["Category_ID"].ToString());
                CategoryList.ValueMember = (dr["Category_ID"].ToString());
            }
            con.Close();
        }
        
        private void Insert_Click(object sender, EventArgs e) // Insert Button
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Room Name Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CategoryList.Text == "")
            {
                MessageBox.Show("Please Select Category", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("Location Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            }
            else if (StatusBox.Text == "")
            {
                MessageBox.Show("Room Status Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Rooms VALUES(@Room_Name, @Category_ID, @Location, @Status,@Rate)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Room_Name", textBox3.Text);
                cmd.Parameters.AddWithValue("@Category_ID",(CategoryList.Text));
                cmd.Parameters.AddWithValue("@Location", textBox6.Text);
                cmd.Parameters.AddWithValue("@Status", StatusBox.Text);
                cmd.Parameters.AddWithValue("@Rate", lblAmount.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Room Record Inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetRoomRecord();
                ResetForm();
                AutomaticID();
            }
        }
        private void FetchRate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Rate from Categories where Category_ID='"+CategoryList.SelectedItem+"'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int Rate = Convert.ToInt32(dr[0]);
            lblAmount.Text = Rate.ToString();
            con.Close();
        }

        private void CategoryList_SelectedIndexChanged(object sender, EventArgs e) 
        {
            FetchRate();
        }
        private void RoomRecord_CellClick(object sender, DataGridViewCellEventArgs e)  //Cell Click For Select Record 
        {
            Room_ID = Convert.ToInt32(RoomRecord.SelectedRows[0].Cells[0].Value);
            textBox1.Text = RoomRecord.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = RoomRecord.SelectedRows[0].Cells[1].Value.ToString();
            CategoryList.Text = RoomRecord.SelectedRows[0].Cells[2].Value.ToString();
            textBox6.Text = RoomRecord.SelectedRows[0].Cells[3].Value.ToString();
            StatusBox.Text = RoomRecord.SelectedRows[0].Cells[4].Value.ToString();
            lblAmount.Text = RoomRecord.SelectedRows[0].Cells[5].Value.ToString();
        }
        private void ResetForm()
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox6.Clear();
            textBox3.Focus();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Room_ID > 0)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Rooms WHERE Room_ID=@Room_ID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Room_ID", this.Room_ID);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetRoomRecord();
                ResetForm();
                AutomaticID();
            }
            else
            {
                MessageBox.Show("Please select valid record to delete", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)  // Update Button
        {
            if (textBox3.Text == "" | textBox6.Text == "" | CategoryList.Text == "" | StatusBox.Text == "" )
            {
                MessageBox.Show("Something Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Room_ID > 0)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Rooms SET Room_Name = @Room_Name, Category_ID=@Category_ID, Location = @Location, Status = @Status ,Rate = @Rate WHERE Room_ID=@Room_ID", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Room_Name", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Category_ID", CategoryList.Text);
                    cmd.Parameters.AddWithValue("@Location", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Status", StatusBox.Text);
                    cmd.Parameters.AddWithValue("@Rate", lblAmount.Text);
                    cmd.Parameters.AddWithValue("@Room_ID", this.Room_ID);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetRoomRecord();
                    ResetForm();
                    AutomaticID();
                }
                else
                {
                    MessageBox.Show("Please select valid record to update", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Rooms where Room_Name like '%" + textBox3.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            RoomRecord.DataSource = dt;
            con.Close();
        } 
    }
}
