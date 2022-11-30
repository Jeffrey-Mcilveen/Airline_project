namespace Airline
{
    partial class frmBookingAdd
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lvwCustomers = new System.Windows.Forms.ListView();
            this.CustomerNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerPNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwFlights = new System.Windows.Forms.ListView();
            this.FlightNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FlightOrigin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FlightDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurrentSeated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxSeats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCustNum = new System.Windows.Forms.TextBox();
            this.txtFlightNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(681, 402);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lvwCustomers
            // 
            this.lvwCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerNumber,
            this.CustomerFName,
            this.CustomerLName,
            this.CustomerPNum});
            this.lvwCustomers.GridLines = true;
            this.lvwCustomers.HideSelection = false;
            this.lvwCustomers.Location = new System.Drawing.Point(29, 62);
            this.lvwCustomers.Name = "lvwCustomers";
            this.lvwCustomers.Size = new System.Drawing.Size(742, 138);
            this.lvwCustomers.TabIndex = 24;
            this.lvwCustomers.UseCompatibleStateImageBehavior = false;
            this.lvwCustomers.View = System.Windows.Forms.View.Details;
            // 
            // CustomerNumber
            // 
            this.CustomerNumber.Text = "Number";
            this.CustomerNumber.Width = 88;
            // 
            // CustomerFName
            // 
            this.CustomerFName.Text = "First Name";
            this.CustomerFName.Width = 222;
            // 
            // CustomerLName
            // 
            this.CustomerLName.Text = "Last Name";
            this.CustomerLName.Width = 221;
            // 
            // CustomerPNum
            // 
            this.CustomerPNum.Text = "Phone #";
            this.CustomerPNum.Width = 149;
            // 
            // lvwFlights
            // 
            this.lvwFlights.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FlightNumber,
            this.FlightOrigin,
            this.FlightDestination,
            this.CurrentSeated,
            this.MaxSeats});
            this.lvwFlights.GridLines = true;
            this.lvwFlights.HideSelection = false;
            this.lvwFlights.Location = new System.Drawing.Point(29, 235);
            this.lvwFlights.Name = "lvwFlights";
            this.lvwFlights.Size = new System.Drawing.Size(742, 153);
            this.lvwFlights.TabIndex = 25;
            this.lvwFlights.UseCompatibleStateImageBehavior = false;
            this.lvwFlights.View = System.Windows.Forms.View.Details;
            // 
            // FlightNumber
            // 
            this.FlightNumber.Text = "Number";
            // 
            // FlightOrigin
            // 
            this.FlightOrigin.Text = "Origin";
            this.FlightOrigin.Width = 183;
            // 
            // FlightDestination
            // 
            this.FlightDestination.Text = "Destination";
            this.FlightDestination.Width = 233;
            // 
            // CurrentSeated
            // 
            this.CurrentSeated.Text = "Current Seated";
            this.CurrentSeated.Width = 89;
            // 
            // MaxSeats
            // 
            this.MaxSeats.Text = "Max Seats";
            this.MaxSeats.Width = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Customer List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Flight List";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(390, 404);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCustNum
            // 
            this.txtCustNum.Location = new System.Drawing.Point(130, 407);
            this.txtCustNum.Name = "txtCustNum";
            this.txtCustNum.Size = new System.Drawing.Size(100, 20);
            this.txtCustNum.TabIndex = 29;
            // 
            // txtFlightNum
            // 
            this.txtFlightNum.Location = new System.Drawing.Point(284, 407);
            this.txtFlightNum.Name = "txtFlightNum";
            this.txtFlightNum.Size = new System.Drawing.Size(100, 20);
            this.txtFlightNum.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Customer #:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Flight #";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(471, 409);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(0, 13);
            this.lblAdd.TabIndex = 33;
            // 
            // frmBookingAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFlightNum);
            this.Controls.Add(this.txtCustNum);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwFlights);
            this.Controls.Add(this.lvwCustomers);
            this.Controls.Add(this.btnBack);
            this.Name = "frmBookingAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Booking";
            this.Load += new System.EventHandler(this.frmBookingAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lvwCustomers;
        private System.Windows.Forms.ColumnHeader CustomerNumber;
        private System.Windows.Forms.ColumnHeader CustomerFName;
        private System.Windows.Forms.ColumnHeader CustomerLName;
        private System.Windows.Forms.ColumnHeader CustomerPNum;
        private System.Windows.Forms.ListView lvwFlights;
        private System.Windows.Forms.ColumnHeader FlightNumber;
        private System.Windows.Forms.ColumnHeader FlightOrigin;
        private System.Windows.Forms.ColumnHeader FlightDestination;
        private System.Windows.Forms.ColumnHeader CurrentSeated;
        private System.Windows.Forms.ColumnHeader MaxSeats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCustNum;
        private System.Windows.Forms.TextBox txtFlightNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAdd;
    }
}