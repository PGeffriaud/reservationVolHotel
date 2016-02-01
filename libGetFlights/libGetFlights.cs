using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using booking.commonTypes;

namespace booking.libGetFlights
{
    public class libGetFlights
    {
        public List<Flight> getAvailableFlights()
        {
            List<Flight> res = new List<Flight>();
            res.Add(new Flight(1, "FL001", new DateTime(2016, 1, 1), new DateTime(2016, 1, 5), "Nantes", "Paris", "NAN", "CDG"));
            res.Add(new Flight(2, "FL002", new DateTime(2016, 1, 5), new DateTime(2016, 1, 6), "Paris", "Nantes", "CDG", "NAN"));
            res.Add(new Flight(3, "FL003", new DateTime(2016, 1, 8), new DateTime(2016, 1, 10), "Nantes", "Marseille", "NAN", "MAR"));
            return res;
        }
    }
}
