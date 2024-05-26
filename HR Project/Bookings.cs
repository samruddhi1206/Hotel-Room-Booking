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
    public partial class Bookings : Form
    {
        public Bookings()
        {
            InitializeComponent();
        }
        //Connection String
        SqlConnection con = new SqlConnection(@"Data Source=SAMRUDDHI\SQLEXPRESS01;Initial Catalog=HR_Database;Integrated Security=True");
        public int Booking_ID;

        private void Bookings_Load(object sender, EventArgs e)
        {
            GetBookingRecord();
            RoomIdComboBox();
            CustomerId();
            AutomaticID();
        }

        private void GetBookingRecord() //For Datagrid View
        {

            SqlCommand cmd = new SqlCommand("Select * from Booking", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            BookingRecord.DataSource = dt;
        }

        private void AutomaticID() //For Generate Automatic Category_ID
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select max(Booking_ID) from Booking", con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                Booking_ID = Convert.ToInt32(dr[0]);
                Booking_ID++;
                textBox1.Text = Booking_ID.ToString();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Exception", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void RoomIdComboBox()  // Add items in combobox list from Rooms table
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Room_ID from Rooms Where Status='Available' ", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbRoomId.Items.Add(dr["Room_ID"].ToString());
                cmbRoomId.DisplayMember = (dr["Room_ID"].ToString());
                cmbRoomId.ValueMember = (dr["Room_ID"].ToString());
            }
            con.Close();
        }

        int duration;
        private void AutomaticDuration() // Count Duration using DateIn and DateOut
        {
            DateTime date1 = DateIn.Value.Date;
            DateTime date2 = DateOut.Value.Date;

            duration = ((TimeSpan)(date2 - date1)).Days;
            Duration.Text = duration.ToString();

        }

        private void DateOut_ValueChanged(object sender, EventArgs e)
        {
            AutomaticDuration();
            Amount();
        }

        private void DateIn_ValueChanged(object sender, EventArgs e)
        {
            AutomaticDuration();
            Amount();
        }

        public  int Rate;
        private void fetchRate() //Fetch Rate
        {
             con.Open();
             SqlCommand cmd = new SqlCommand("Select Rate from Rooms where Room_ID='" + cmbRoomId.SelectedItem + "'", con);
             SqlDataReader dr = cmd.ExecuteReader();
             dr.Read();
             Rate = Convert.ToInt32(dr[0]);
             con.Close();
        }

        private void cmbRoomId_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchRate();
        }
        private void Amount()
        {
            int Amount;
            Amount = Rate*duration;
            lblAmount.Text = Amount.ToString();
        }
        private void CustomerId() // Display maximum Cutomer ID from Customer Table
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select max(Customer_ID) from Customer", con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int Customer_ID = Convert.ToInt32(dr[0]);
            textBox3.Text = Customer_ID.ToString();
            con.Close();
        }

        private void Booking_Click(object sender, EventArgs e) // Insert Button
        {
            if (textBox3.Text == "" || cmbRoomId.Text == "")
            {
                MessageBox.Show("Customer Id Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            }
            else if (cmbRoomId.Text == "")
            {
                MessageBox.Show("Room Id Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            }
            else
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Booking VALUES(@Room_ID, @Customer_ID, @Date_In, @Date_Out,@Duration,@Amount)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Room_ID", cmbRoomId.Text);
                cmd.Parameters.AddWithValue("@Customer_ID",textBox3.Text);
                cmd.Parameters.AddWithValue("@Date_In", DateIn.Value.Date);
                cmd.Parameters.AddWithValue("@Date_Out", DateOut.Value.Date);
                cmd.Parameters.AddWithValue("@Duration", Duration.Text);
                cmd.Parameters.AddWithValue("@Amount", lblAmount.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Room is Booked", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetBookingRecord();
                ResetForm();
                AutomaticID();
            }
        }
        private void ResetForm()
        {
            textBox1.Clear();
            textBox3.Clear();
            cmbRoomId.Focus();
        }

        private void button2_Click(object sender, EventArgs e) // Update Button
        {
            if (textBox3.Text == "" || cmbRoomId.Text == "" || cmbRoomId.Text == "")
            {
                MessageBox.Show("Something Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Booking_ID > 0)
                {
                    con.Close();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Booking SET Room_ID = @Room_ID, Customer_ID=@Customer_ID, Date_In = @Date_In, Date_Out = @Date_Out ,Duration = @Duration, Amount = @Amount WHERE Booking_ID=@Booking_ID", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Room_ID", cmbRoomId.Text);
                    cmd.Parameters.AddWithValue("@Customer_ID", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Date_In", DateIn.Value.Date);
                    cmd.Parameters.AddWithValue("@Date_Out", DateOut.Value.Date);
                    cmd.Parameters.AddWithValue("@Duration", Duration.Text);
                    cmd.Parameters.AddWithValue("@Amount", lblAmount.Text);
                    cmd.Parameters.AddWithValue("@Booking_ID", this.Booking_ID);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetBookingRecord();
                    ResetForm();
                    AutomaticID();
                
                }
                else
                {
                    MessageBox.Show("Please select valid record to update", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)  // Reset Button
        {
            ResetForm();
        }

        private void BookingRecord_CellClick(object sender, DataGridViewCellEventArgs e) //Cell click for Select Record
        {
            Booking_ID = Convert.ToInt32(BookingRecord.SelectedRows[0].Cells[0].Value);
            textBox1.Text = BookingRecord.SelectedRows[0].Cells[0].Value.ToString();
            cmbRoomId.Text = BookingRecord.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = BookingRecord.SelectedRows[0].Cells[2].Value.ToString();
            DateIn.Text = BookingRecord.SelectedRows[0].Cells[3].Value.ToString();
            DateOut.Text = BookingRecord.SelectedRows[0].Cells[4].Value.ToString();
            Duration.Text = BookingRecord.SelectedRows[0].Cells[5].Value.ToString();
            lblAmount.Text = BookingRecord.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void Cancel_Click(object sender, EventArgs e) // Delete Button
        {
            if (Booking_ID > 0)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Booking WHERE Booking_ID=@Booking_ID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Booking_ID", this.Booking_ID);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetBookingRecord();
                ResetForm();
                AutomaticID();
            }
            else
            {
                MessageBox.Show("Please select valid record to delete", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    
    }
}
