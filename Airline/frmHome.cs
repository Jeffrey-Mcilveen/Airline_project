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
    public partial class frmHome : Form
    {
        AirlineCoordinator aCoord;
        

        public frmHome()
        {
            InitializeComponent();

        }
        public frmHome(AirlineCoordinator aCoord)
        {
            this.aCoord = aCoord;

            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Form Customers = new frmCustomers(aCoord,this);
            Customers.Show();
            this.Hide();
        }

        private void btnFlights_Click(object sender, EventArgs e)
        {
            Form Flights = new frmFlights(aCoord,this);
            Flights.Show();
            this.Hide();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            Form Bookings = new frmBookings(aCoord, this);
            Bookings.Show();
            this.Hide();
        }
    }
}
