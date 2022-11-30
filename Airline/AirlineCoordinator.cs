using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class AirlineCoordinator
    {
        FlightManager flManager;
        CustomerManager custManager;
        BookingManager bookManager;


        public AirlineCoordinator(int custIdSeed, int maxCust, int maxFlights, int BookingSeed, int MaxNumBookings)
        {
            flManager = new FlightManager(maxFlights);
            custManager = new CustomerManager(custIdSeed, maxCust);
            bookManager = new BookingManager(BookingSeed, MaxNumBookings);

        }

        public bool addFlight(int flightNo, string origin, string destination, int maxSeats)
        {
            return flManager.addFlight(flightNo, origin, destination, maxSeats);
        }

        public bool addBooking(int flightId, int customerId)
        {
            if (customerExist(customerId) && flightExists(flightId)) { 
                Flight flight = flManager.getFlight(flightId);
                Customer customer = custManager.getCustomer(customerId);
                return bookManager.addBooking(flight, customer);
            }
            return false;
        }


        public bool addCustomer(string fname, string lname, string phone)
        {
            return custManager.addCustomer(fname, lname, phone);
        }

        public Flight[] flightList()
        {
            return flManager.getFlightList();
        }
        public bool flightExists(int fid) { return flManager.flightExists(fid); }

        public Customer[] customerList()
        {
            return custManager.getCustomerList();
        }
        public bool customerExist(int cid) { return custManager.customerExist(cid); }

        public Booking[] bookingList()
        {
            return bookManager.getBookingList();
        }

        public bool deleteCustomer(int id)
        {
            return custManager.deleteCustomer(id);
        }

        public bool deleteFlight(int fid)
        {
            return flManager.deleteFlight(fid);
        }
        public int getNumOfCust()
        {
            return custManager.getNumOfCustomers();
        }
        public int getNumOfFlights()
        {
            return flManager.getNumOfFlights();
        }
        public int getNumOfBookings()
        {
            return bookManager.getNumOfBookings();
        }

    }
}
