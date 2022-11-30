using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class frmCustomers : Form
    {
        AirlineCoordinator aCoord;
        public frmHome home;
        
        public frmCustomers()
        {
            InitializeComponent();
        }

        public frmCustomers(AirlineCoordinator aCoord, frmHome home)
        {
            this.home = home;
            this.aCoord = aCoord;
            
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            
            home.Show();
            this.Close();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            lvwCustomers.Clear();
            lvwCustomers.Columns.Add("Number");
            lvwCustomers.Columns.Add("First Name");
            lvwCustomers.Columns.Add("Last Name");
            lvwCustomers.Columns.Add("Phone #");
            Customer[] temp = aCoord.customerList();
            for (int x = 0; x < aCoord.getNumOfCust(); x++)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(temp[x].getId()));
                item.SubItems.Add(temp[x].getFirstName());
                item.SubItems.Add(temp[x].getLastName());
                item.SubItems.Add(temp[x].getPhone());

                lvwCustomers.Items.Add(item);

            }
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if(txtCustomerFName.Text == "" || txtCustomerLName.Text == "" || txtCustomerPNum.Text == "")
            {
                lblAddCustomer.ForeColor = System.Drawing.Color.Red;
                lblAddCustomer.Text = "Fields cannot be empty!";
                return;
            }
            if (aCoord.addCustomer(txtCustomerFName.Text, txtCustomerLName.Text, txtCustomerPNum.Text))
            {
                lblAddCustomer.ForeColor = System.Drawing.Color.Green;
                lblAddCustomer.Text = "Customer Added!";
                txtCustomerFName.Clear();
                txtCustomerLName.Clear();
                txtCustomerPNum.Clear();
            }
            else
            {
                lblAddCustomer.ForeColor = System.Drawing.Color.Red;
                lblAddCustomer.Text = "Failed to add customer.";
            }
            load();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (txtDeleteID.Text == "")
            {
                lblDelete.ForeColor = System.Drawing.Color.Red;
                lblDelete.Text = "Fields cannot be empty!";
                return;
            }
            if (aCoord.deleteCustomer(Convert.ToInt32(txtDeleteID.Text)))
            {
                lblDelete.ForeColor = System.Drawing.Color.Green;
                lblDelete.Text = "Customer deleted!";
                txtDeleteID.Clear();

            }
            else
            {
                lblDelete.ForeColor = System.Drawing.Color.Red;
                lblDelete.Text = "Failed to delete customer.";
            }
            load();

        }
    }
}
