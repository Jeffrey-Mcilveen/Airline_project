using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class BookingManager
    {
        private static int currentBookingNumber;
        private int maxNumBookings;
        private int numBookings;
        private Booking[] bookingList;



        public BookingManager(int cbn, int max)
        {
            currentBookingNumber = cbn;
            maxNumBookings = max;
            numBookings = 0;
            bookingList = new Booking[maxNumBookings];
        }
        public bool addBooking(Flight flight, Customer customer)
        {
            if (numBookings >= maxNumBookings)
            {
                return false;

            }
            
            
                Booking c = new Booking(currentBookingNumber, flight, customer);
                currentBookingNumber++;
                bookingList[numBookings] = c;
                numBookings++;
                return true;
            
           
        }

        public int findBooking(int bid)
        {
            for (int x = 0; x < numBookings; x++)
            {
                if (bookingList[x].getBookingNum() == bid)
                    return x;
            }
            return -1;
        }
        
        
        public Booking getBooking(int bid)
        {
            int loc = findBooking(bid);
            if (loc == -1) { return null; }
            return bookingList[loc];
        }

        public bool deleteBooking(int bid)
        {
            int loc = findBooking(bid);
            if (loc == -1) { return false; }
            bookingList[loc] = bookingList[numBookings - 1];
            numBookings--;
            return true;
        }

        public Booking[] getBookingList()
        {
            return bookingList;
        }
        public int getNumOfBookings()
        {
            return numBookings;
        }
    }
}
