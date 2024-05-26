namespace HR_Project
{
    partial class Analytics
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblbooked = new System.Windows.Forms.Label();
            this.lblAvaRoom = new System.Windows.Forms.Label();
            this.lblAmt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1375, 60);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(567, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Analytics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Rooms";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(820, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Booked Rooms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 45);
            this.label4.TabIndex = 8;
            this.label4.Text = "Available Rooms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(820, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 45);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Finance";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(283, 176);
            this.lblRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(172, 43);
            this.lblRoom.TabIndex = 13;
            this.lblRoom.Text = "00 Rooms";
            this.lblRoom.Click += new System.EventHandler(this.lblRoom_Click);
            // 
            // lblbooked
            // 
            this.lblbooked.AutoSize = true;
            this.lblbooked.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbooked.Location = new System.Drawing.Point(882, 176);
            this.lblbooked.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbooked.Name = "lblbooked";
            this.lblbooked.Size = new System.Drawing.Size(172, 43);
            this.lblbooked.TabIndex = 14;
            this.lblbooked.Text = "00 Rooms";
            // 
            // lblAvaRoom
            // 
            this.lblAvaRoom.AutoSize = true;
            this.lblAvaRoom.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvaRoom.Location = new System.Drawing.Point(283, 450);
            this.lblAvaRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvaRoom.Name = "lblAvaRoom";
            this.lblAvaRoom.Size = new System.Drawing.Size(172, 43);
            this.lblAvaRoom.TabIndex = 15;
            this.lblAvaRoom.Text = "00 Rooms";
            // 
            // lblAmt
            // 
            this.lblAmt.AutoSize = true;
            this.lblAmt.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmt.Location = new System.Drawing.Point(882, 450);
            this.lblAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(107, 43);
            this.lblAmt.TabIndex = 17;
            this.lblAmt.Text = "Rs.00";
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1375, 784);
            this.Controls.Add(this.lblAmt);
            this.Controls.Add(this.lblAvaRoom);
            this.Controls.Add(this.lblbooked);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Analytics";
            this.Text = "Analytics";
            this.Load += new System.EventHandler(this.Analytics_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblbooked;
        private System.Windows.Forms.Label lblAvaRoom;
        private System.Windows.Forms.Label lblAmt;
    }
}