using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using booking.libGetFlights;
using booking.libGetHotels;
using booking.commonTypes;

namespace booking.libGetInfos
{
    public class libGetInfos
    {
        public List<Flight> getListFlights()
        {
            libGetFlights.libGetFlights libFlights = new libGetFlights.libGetFlights();
            return libFlights.getAvailableFlights();
        }

        public List<Hotel> getListHotels()
        {
            libGetHotels.libGetHotels libHotels = new libGetHotels.libGetHotels();
            return libHotels.getAvailableHotels();
        }
    }
}
