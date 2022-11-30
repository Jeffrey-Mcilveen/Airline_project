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
    public partial class frmFlightDetail : Form
    {
        AirlineCoordinator aCoord;
        frmHome home;
        frmFlights Flights;
        int flightID;
        public frmFlightDetail(AirlineCoordinator aCoord, frmFlights Flights, frmHome home)
        {
            this.home = home;
            this.Flights = Flights;
            this.aCoord = aCoord;
            flightID = Convert.ToInt32(Flights.txtFlightID.Text);
            InitializeComponent();
        }

        private void frmFlightDetail_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            lvwCustomers.Clear();
            lvwCustomers.Columns.Add("Customer Number");
            lvwCustomers.Columns.Add("Name");
            
            Booking[] temp = aCoord.bookingList();
            for (int x = 0; x < aCoord.getNumOfBookings(); x++)
            {
                if(temp[x].getFlightNum() == flightID)
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(temp[x].getCustNum()));
                    item.SubItems.Add(temp[x].getCustomerName());
                    lvwCustomers.Items.Add(item);
                }
                

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form backToFlights = new frmFlights(aCoord, home);
            backToFlights.Show();
            this.Close();
            
        }
    }
}
