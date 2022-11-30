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
    public partial class frmBookings : Form
    {
        frmHome home;
        AirlineCoordinator aCoord;

        public frmBookings(AirlineCoordinator aCoord, frmHome home)
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

        private void frmBookings_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            lvwBookings.Clear();
            lvwBookings.Columns.Add("Date");
            lvwBookings.Columns.Add("Booking #");
            lvwBookings.Columns.Add("Customer Name");
            lvwBookings.Columns.Add("Flight #");
            Booking[] temp = aCoord.bookingList();
            for (int x = 0; x < aCoord.getNumOfBookings(); x++)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(temp[x].getDate()));
                item.SubItems.Add(Convert.ToString(temp[x].getBookingNum()));
                item.SubItems.Add(temp[x].getCustomerName());
                item.SubItems.Add(Convert.ToString(temp[x].getFlightNum()));               
                lvwBookings.Items.Add(item);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form BookingAdd = new frmBookingAdd(aCoord, home);
            BookingAdd.Show();
            this.Close();
        }
    }
}
