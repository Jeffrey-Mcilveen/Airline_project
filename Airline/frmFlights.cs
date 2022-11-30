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
    public partial class frmFlights : Form
    {
        AirlineCoordinator aCoord;
        public frmHome home;
        public frmFlights()
        {
            InitializeComponent();
        }

        

        public frmFlights(AirlineCoordinator aCoord,frmHome home)
        {
            this.home = home;
            this.aCoord = aCoord;
            InitializeComponent();
        }

        private void frmFlights_Load(object sender, EventArgs e)
        {
            load();
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
        }

        private void lvwFlights_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            if(txtDelete.Text == "")
            {
                lblDelete.ForeColor = System.Drawing.Color.Red;
                lblDelete.Text = "Fields cannot be empty!";
                return;
            }
            if (aCoord.deleteFlight(Convert.ToInt32(txtDelete.Text)))
            {
                lblDelete.ForeColor = System.Drawing.Color.Green;
                lblDelete.Text = "Flight deleted!";
                txtDelete.Clear();

            }
            else
            {
                lblDelete.ForeColor = System.Drawing.Color.Red;
                lblDelete.Text = "Failed to delete flight.";
            }
            load();
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            if (txtFlightNum.Text == "" || txtOrigin.Text == "" || txtDestination.Text == "" || txtMaxSeats.Text =="")
            {
                lblAdd.ForeColor = System.Drawing.Color.Red;
                lblAdd.Text = "Fields cannot be empty!";
                return;
            }
            if (aCoord.addFlight(Convert.ToInt32(txtFlightNum.Text), txtOrigin.Text, txtDestination.Text, Convert.ToInt32(txtMaxSeats.Text)))
            {
                lblAdd.ForeColor = System.Drawing.Color.Green;
                lblAdd.Text = "Flight Added!";
                txtFlightNum.Clear();
                txtOrigin.Clear();
                txtDestination.Clear();
                txtMaxSeats.Clear();
            }
            else
            {
                lblAdd.ForeColor = System.Drawing.Color.Red;
                lblAdd.Text = "Failed to add flight.";
            }
            load();
        }

        private void btnDetailedView_Click(object sender, EventArgs e)
        {
            if (txtFlightID.Text == "")
            {
                lblDetailed.ForeColor = System.Drawing.Color.Red;
                lblDetailed.Text = "Fields cannot be empty!";
                return;
            }
            Form FlightDetails = new frmFlightDetail(aCoord, this, home);
            FlightDetails.Show();
            this.Close();
        }
    }
}
