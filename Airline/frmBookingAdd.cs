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
    public partial class frmBookingAdd : Form
    {
        frmHome home;
        AirlineCoordinator aCoord;
        public frmBookingAdd(AirlineCoordinator aCoord, frmHome home)
        {
            this.home = home;
            this.aCoord = aCoord;
            InitializeComponent();
        }

        private void frmBookingAdd_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form Bookings = new frmBookings(aCoord, home);
            Bookings.Show();
            this.Close();
        }
        private void load()
        {
            lvwFlights.Clear();
            lvwFlights.Columns.Add("Number");
            lvwFlights.Columns.Add("Origin");
            lvwFlights.Columns.Add("Destination");
            lvwFlights.Columns.Add("Number of Seated");
            lvwFlights.Columns.Add("Number of Seated");
            Flight[] temp = aCoord.flightList();
            for (int x = 0; x < aCoord.getNumOfFlights(); x++)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(temp[x].getFlightNumber()));
                item.SubItems.Add(temp[x].getOrigin());
                item.SubItems.Add(temp[x].getDestination());
                item.SubItems.Add(Convert.ToString(temp[x].getNumPassengers()));
                item.SubItems.Add(Convert.ToString(temp[x].getMaxSeats()));

                lvwFlights.Items.Add(item);

            }
            lvwCustomers.Clear();
            lvwCustomers.Columns.Add("Number");
            lvwCustomers.Columns.Add("First Name");
            lvwCustomers.Columns.Add("Last Name");
            lvwCustomers.Columns.Add("Phone #");
            Customer[] tempc = aCoord.customerList();
            for (int x = 0; x < aCoord.getNumOfCust(); x++)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(tempc[x].getId()));
                item.SubItems.Add(tempc[x].getFirstName());
                item.SubItems.Add(tempc[x].getLastName());
                item.SubItems.Add(tempc[x].getPhone());

                lvwCustomers.Items.Add(item);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCustNum.Text == "" || txtFlightNum.Text == "")
            {
                lblAdd.ForeColor = System.Drawing.Color.Red;
                lblAdd.Text = "Fields cannot be empty!";
                return;
            }
            if (aCoord.addBooking(Convert.ToInt32(txtFlightNum.Text), Convert.ToInt32(txtCustNum.Text)))
            {
                lblAdd.ForeColor = System.Drawing.Color.Green;
                lblAdd.Text = "Booking Added!";
                txtCustNum.Clear();
                txtFlightNum.Clear();
                
            }
            else
            {
                lblAdd.ForeColor = System.Drawing.Color.Red;
                lblAdd.Text = "Failed to add booking.";
            }
        }
    }
}
