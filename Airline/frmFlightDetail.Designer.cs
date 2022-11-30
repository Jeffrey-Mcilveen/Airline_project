namespace Airline
{
    partial class frmFlightDetail
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
            this.lvwCustomers = new System.Windows.Forms.ListView();
            this.FlightNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FlightOrigin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FlightDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurrentSeated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxSeats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwCustomers
            // 
            this.lvwCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FlightNumber,
            this.FlightOrigin,
            this.FlightDestination,
            this.CurrentSeated,
            this.MaxSeats});
            this.lvwCustomers.GridLines = true;
            this.lvwCustomers.HideSelection = false;
            this.lvwCustomers.Location = new System.Drawing.Point(63, 52);
            this.lvwCustomers.Name = "lvwCustomers";
            this.lvwCustomers.Size = new System.Drawing.Size(636, 326);
            this.lvwCustomers.TabIndex = 18;
            this.lvwCustomers.UseCompatibleStateImageBehavior = false;
            this.lvwCustomers.View = System.Windows.Forms.View.Details;
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
            this.label1.Location = new System.Drawing.Point(247, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Customers Booked on Flight";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(353, 384);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmFlightDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwCustomers);
            this.Name = "frmFlightDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFlightDetail";
            this.Load += new System.EventHandler(this.frmFlightDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwCustomers;
        private System.Windows.Forms.ColumnHeader FlightNumber;
        private System.Windows.Forms.ColumnHeader FlightOrigin;
        private System.Windows.Forms.ColumnHeader FlightDestination;
        private System.Windows.Forms.ColumnHeader CurrentSeated;
        private System.Windows.Forms.ColumnHeader MaxSeats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}