using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            AirlineCoordinator aCoord = new AirlineCoordinator(100, 200, 30, 10, 50);
            aCoord.addFlight(10006, "Halifax", "Toronto", 50);
            aCoord.addFlight(10007, "Toronto", "Halfax", 50);
            aCoord.addCustomer("Jeffrey", "Mcilveen", "416-667-3432");
            aCoord.addCustomer("Peter", "Parker", "442-669-8097");
            aCoord.addBooking(10006, 100);
            aCoord.addBooking(10007, 101);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmHome(aCoord));
        }
    }
}
