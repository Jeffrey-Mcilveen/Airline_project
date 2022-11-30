namespace Airline
{
    partial class frmFlights
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
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.CurrentSeated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FlightDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FlightOrigin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.txtFlightNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteFlight = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lvwFlights = new System.Windows.Forms.ListView();
            this.FlightNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxSeats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBack = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.txtMaxSeats = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFlightID = new System.Windows.Forms.TextBox();
            this.btnDetailedView = new System.Windows.Forms.Button();
            this.lblDetailed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.Location = new System.Drawing.Point(400, 219);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(0, 13);
            this.lblAddCustomer.TabIndex = 15;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(615, 387);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(0, 13);
            this.lblAdd.TabIndex = 28;
            // 
            // CurrentSeated
            // 
            this.CurrentSeated.Text = "Current Seated";
            this.CurrentSeated.Width = 89;
            // 
            // FlightDestination
            // 
            this.FlightDestination.Text = "Destination";
            this.FlightDestination.Width = 233;
            // 
            // FlightOrigin
            // 
            this.FlightOrigin.Text = "Origin";
            this.FlightOrigin.Width = 183;
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.Location = new System.Drawing.Point(475, 382);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(134, 23);
            this.btnAddFlight.TabIndex = 27;
            this.btnAddFlight.Text = "Add Flight";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(247, 384);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(100, 20);
            this.txtDestination.TabIndex = 26;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(140, 384);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(100, 20);
            this.txtOrigin.TabIndex = 25;
            // 
            // txtFlightNum
            // 
            this.txtFlightNum.Location = new System.Drawing.Point(33, 384);
            this.txtFlightNum.Name = "txtFlightNum";
            this.txtFlightNum.Size = new System.Drawing.Size(100, 20);
            this.txtFlightNum.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Origin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Flight #";
            // 
            // btnDeleteFlight
            // 
            this.btnDeleteFlight.Location = new System.Drawing.Point(353, 415);
            this.btnDeleteFlight.Name = "btnDeleteFlight";
            this.btnDeleteFlight.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFlight.TabIndex = 20;
            this.btnDeleteFlight.Text = "Delete";
            this.btnDeleteFlight.UseVisualStyleBackColor = true;
            this.btnDeleteFlight.Click += new System.EventHandler(this.btnDeleteFlight_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Flight List";
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
            this.lvwFlights.Location = new System.Drawing.Point(31, 36);
            this.lvwFlights.Name = "lvwFlights";
            this.lvwFlights.Size = new System.Drawing.Size(636, 326);
            this.lvwFlights.TabIndex = 17;
            this.lvwFlights.UseCompatibleStateImageBehavior = false;
            this.lvwFlights.View = System.Windows.Forms.View.Details;
            this.lvwFlights.SelectedIndexChanged += new System.EventHandler(this.lvwFlights_SelectedIndexChanged);
            // 
            // FlightNumber
            // 
            this.FlightNumber.Text = "Number";
            // 
            // MaxSeats
            // 
            this.MaxSeats.Text = "Max Seats";
            this.MaxSeats.Width = 67;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(698, 406);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(247, 418);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(100, 20);
            this.txtDelete.TabIndex = 29;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(434, 421);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(0, 13);
            this.lblDelete.TabIndex = 30;
            // 
            // txtMaxSeats
            // 
            this.txtMaxSeats.Location = new System.Drawing.Point(353, 384);
            this.txtMaxSeats.Name = "txtMaxSeats";
            this.txtMaxSeats.Size = new System.Drawing.Size(100, 20);
            this.txtMaxSeats.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Max seats";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Flight Number to Delete:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(706, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Flight #:";
            // 
            // txtFlightID
            // 
            this.txtFlightID.Location = new System.Drawing.Point(688, 116);
            this.txtFlightID.Name = "txtFlightID";
            this.txtFlightID.Size = new System.Drawing.Size(75, 20);
            this.txtFlightID.TabIndex = 35;
            // 
            // btnDetailedView
            // 
            this.btnDetailedView.Location = new System.Drawing.Point(688, 142);
            this.btnDetailedView.Name = "btnDetailedView";
            this.btnDetailedView.Size = new System.Drawing.Size(85, 23);
            this.btnDetailedView.TabIndex = 36;
            this.btnDetailedView.Text = "Detailed View";
            this.btnDetailedView.UseVisualStyleBackColor = true;
            this.btnDetailedView.Click += new System.EventHandler(this.btnDetailedView_Click);
            // 
            // lblDetailed
            // 
            this.lblDetailed.AutoSize = true;
            this.lblDetailed.Location = new System.Drawing.Point(691, 187);
            this.lblDetailed.Name = "lblDetailed";
            this.lblDetailed.Size = new System.Drawing.Size(0, 13);
            this.lblDetailed.TabIndex = 37;
            // 
            // frmFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDetailed);
            this.Controls.Add(this.btnDetailedView);
            this.Controls.Add(this.txtFlightID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaxSeats);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnAddFlight);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.txtFlightNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteFlight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvwFlights);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAddCustomer);
            this.Name = "frmFlights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flights";
            this.Load += new System.EventHandler(this.frmFlights_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCustomer;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.ColumnHeader CurrentSeated;
        private System.Windows.Forms.ColumnHeader FlightDestination;
        private System.Windows.Forms.ColumnHeader FlightOrigin;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtFlightNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteFlight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvwFlights;
        private System.Windows.Forms.ColumnHeader FlightNumber;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ColumnHeader MaxSeats;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.TextBox txtMaxSeats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDetailedView;
        public System.Windows.Forms.TextBox txtFlightID;
        private System.Windows.Forms.Label lblDetailed;
    }
}
