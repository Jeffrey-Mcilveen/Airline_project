namespace Airline
{
    partial class frmCustomers
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerFName = new System.Windows.Forms.TextBox();
            this.txtCustomerLName = new System.Windows.Forms.TextBox();
            this.txtCustomerPNum = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.txtDeleteID = new System.Windows.Forms.TextBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(695, 406);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
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
            this.lvwCustomers.Location = new System.Drawing.Point(28, 36);
            this.lvwCustomers.Name = "lvwCustomers";
            this.lvwCustomers.Size = new System.Drawing.Size(742, 326);
            this.lvwCustomers.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer List";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(365, 420);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCustomer.TabIndex = 4;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone #";
            // 
            // txtCustomerFName
            // 
            this.txtCustomerFName.Location = new System.Drawing.Point(28, 393);
            this.txtCustomerFName.Name = "txtCustomerFName";
            this.txtCustomerFName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerFName.TabIndex = 10;
            // 
            // txtCustomerLName
            // 
            this.txtCustomerLName.Location = new System.Drawing.Point(135, 393);
            this.txtCustomerLName.Name = "txtCustomerLName";
            this.txtCustomerLName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerLName.TabIndex = 11;
            // 
            // txtCustomerPNum
            // 
            this.txtCustomerPNum.Location = new System.Drawing.Point(242, 393);
            this.txtCustomerPNum.Name = "txtCustomerPNum";
            this.txtCustomerPNum.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerPNum.TabIndex = 12;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(365, 391);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(134, 23);
            this.btnAddCustomer.TabIndex = 13;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.Location = new System.Drawing.Point(505, 393);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(0, 13);
            this.lblAddCustomer.TabIndex = 14;
            // 
            // txtDeleteID
            // 
            this.txtDeleteID.Location = new System.Drawing.Point(242, 422);
            this.txtDeleteID.Name = "txtDeleteID";
            this.txtDeleteID.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteID.TabIndex = 15;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(446, 425);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(0, 13);
            this.lblDelete.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter customer number to delete:";
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.txtDeleteID);
            this.Controls.Add(this.lblAddCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtCustomerPNum);
            this.Controls.Add(this.txtCustomerLName);
            this.Controls.Add(this.txtCustomerFName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwCustomers);
            this.Controls.Add(this.btnBack);
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerFName;
        private System.Windows.Forms.TextBox txtCustomerLName;
        private System.Windows.Forms.TextBox txtCustomerPNum;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblAddCustomer;
        private System.Windows.Forms.TextBox txtDeleteID;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label label2;
    }
}
