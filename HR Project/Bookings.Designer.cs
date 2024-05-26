namespace HR_Project
{
    partial class Bookings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DateIn = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.DateOut = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Booking = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BookingRecord = new System.Windows.Forms.DataGridView();
            this.cmbRoomId = new System.Windows.Forms.ComboBox();
            this.Duration = new System.Windows.Forms.Label();
            this.Days = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.Rs = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookingRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1375, 71);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(563, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "BOOKING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(164, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Booking Id  :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(414, 93);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 39);
            this.textBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(728, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Room Id  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(164, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 34);
            this.label4.TabIndex = 11;
            this.label4.Text = "Customer Id  :";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(414, 145);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(241, 39);
            this.textBox3.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(728, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 34);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date In :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(164, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 34);
            this.label6.TabIndex = 16;
            this.label6.Text = "Date Out :";
            // 
            // DateIn
            // 
            this.DateIn.CalendarFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateIn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateIn.Location = new System.Drawing.Point(957, 136);
            this.DateIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateIn.Name = "DateIn";
            this.DateIn.Size = new System.Drawing.Size(241, 39);
            this.DateIn.TabIndex = 17;
            this.DateIn.ValueChanged += new System.EventHandler(this.DateIn_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(728, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 34);
            this.label7.TabIndex = 18;
            this.label7.Text = "Duration :";
            // 
            // DateOut
            // 
            this.DateOut.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOut.Location = new System.Drawing.Point(414, 192);
            this.DateOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateOut.Name = "DateOut";
            this.DateOut.Size = new System.Drawing.Size(241, 39);
            this.DateOut.TabIndex = 20;
            this.DateOut.ValueChanged += new System.EventHandler(this.DateOut_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(452, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 33);
            this.label8.TabIndex = 23;
            this.label8.Text = "Amount :";
            // 
            // Booking
            // 
            this.Booking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Booking.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking.ForeColor = System.Drawing.Color.Black;
            this.Booking.Location = new System.Drawing.Point(385, 332);
            this.Booking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Booking.Name = "Booking";
            this.Booking.Size = new System.Drawing.Size(120, 40);
            this.Booking.TabIndex = 25;
            this.Booking.Text = "Book";
            this.Booking.UseVisualStyleBackColor = false;
            this.Booking.Click += new System.EventHandler(this.Booking_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Red;
            this.Cancel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.Black;
            this.Cancel.Location = new System.Drawing.Point(679, 332);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(120, 40);
            this.Cancel.TabIndex = 27;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(826, 332);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 30;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookingRecord
            // 
            this.BookingRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookingRecord.BackgroundColor = System.Drawing.Color.White;
            this.BookingRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookingRecord.DefaultCellStyle = dataGridViewCellStyle1;
            this.BookingRecord.Location = new System.Drawing.Point(12, 399);
            this.BookingRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BookingRecord.Name = "BookingRecord";
            this.BookingRecord.RowTemplate.Height = 24;
            this.BookingRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookingRecord.Size = new System.Drawing.Size(1351, 372);
            this.BookingRecord.TabIndex = 31;
            this.BookingRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookingRecord_CellClick);
            // 
            // cmbRoomId
            // 
            this.cmbRoomId.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomId.FormattingEnabled = true;
            this.cmbRoomId.Location = new System.Drawing.Point(957, 84);
            this.cmbRoomId.Name = "cmbRoomId";
            this.cmbRoomId.Size = new System.Drawing.Size(241, 39);
            this.cmbRoomId.TabIndex = 32;
            this.cmbRoomId.SelectedIndexChanged += new System.EventHandler(this.cmbRoomId_SelectedIndexChanged);
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration.Location = new System.Drawing.Point(951, 198);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(29, 33);
            this.Duration.TabIndex = 33;
            this.Duration.Text = "0";
            // 
            // Days
            // 
            this.Days.AutoSize = true;
            this.Days.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Days.Location = new System.Drawing.Point(986, 198);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(71, 33);
            this.Days.TabIndex = 34;
            this.Days.Text = "Days";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(660, 275);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(29, 33);
            this.lblAmount.TabIndex = 35;
            this.lblAmount.Text = "0";
            // 
            // Rs
            // 
            this.Rs.AutoSize = true;
            this.Rs.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rs.Location = new System.Drawing.Point(600, 275);
            this.Rs.Name = "Rs";
            this.Rs.Size = new System.Drawing.Size(52, 33);
            this.Rs.TabIndex = 36;
            this.Rs.Text = "Rs.";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(535, 332);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 37;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1375, 784);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Rs);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.cmbRoomId);
            this.Controls.Add(this.BookingRecord);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Booking);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DateOut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookings";
            this.Load += new System.EventHandler(this.Bookings_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookingRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Booking;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView BookingRecord;
        private System.Windows.Forms.ComboBox cmbRoomId;
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.Label Days;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label Rs;
        private System.Windows.Forms.Button button2;
    }
}