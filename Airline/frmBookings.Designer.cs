namespace Airline
{
    partial class frmBookings
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
            this.label2 = new System.Windows.Forms.Label();
            this.lvwBookings = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FlightNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookingNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Booking";
            // 
            // lvwBookings
            // 
            this.lvwBookings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.FlightNum,
            this.BookingNum,
            this.FName,
            this.LName});
            this.lvwBookings.GridLines = true;
            this.lvwBookings.HideSelection = false;
            this.lvwBookings.Location = new System.Drawing.Point(35, 36);
            this.lvwBookings.Name = "lvwBookings";
            this.lvwBookings.Size = new System.Drawing.Size(735, 326);
            this.lvwBookings.TabIndex = 20;
            this.lvwBookings.UseCompatibleStateImageBehavior = false;
            this.lvwBookings.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 62;
            // 
            // FlightNum
            // 
            this.FlightNum.Text = "Flight Number";
            this.FlightNum.Width = 81;
            // 
            // BookingNum
            // 
            this.BookingNum.Text = "Booking #";
            this.BookingNum.Width = 75;
            // 
            // FName
            // 
            this.FName.Text = "First Name";
            this.FName.Width = 148;
            // 
            // LName
            // 
            this.LName.Text = "Last Name";
            this.LName.Width = 163;
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.Location = new System.Drawing.Point(423, 219);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(0, 13);
            this.lblAddCustomer.TabIndex = 19;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(695, 397);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 397);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 23);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add Booking";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvwBookings);
            this.Controls.Add(this.lblAddCustomer);
            this.Name = "frmBookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookings";
            this.Load += new System.EventHandler(this.frmBookings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvwBookings;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader FlightNum;
        private System.Windows.Forms.ColumnHeader BookingNum;
        private System.Windows.Forms.ColumnHeader FName;
        private System.Windows.Forms.ColumnHeader LName;
        private System.Windows.Forms.Label lblAddCustomer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
    }
}