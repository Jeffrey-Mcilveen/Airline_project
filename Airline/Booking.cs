using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Booking
    {
        private string date;
        private int bookingNum;
        private Flight flight;
        private Customer customer;

        public Booking(int bookingNum, Flight flight, Customer customer)
        {
            date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
            this.bookingNum = bookingNum;
            this.flight = flight;
            this.customer = customer;
        }

        public int getBookingNum()
        {
            return bookingNum;
        }
        public string getDate()
        {
            return date;
        }
        public string getCustomerName()
        {
            return customer.getFirstName() + " " + customer.getLastName();
        }
        public int getCustNum()
        {
            return customer.getId();
        }
        public int getFlightNum()
        {
            return flight.getFlightNumber();
        }
    }
}
