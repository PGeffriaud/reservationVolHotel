using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using booking.libGetFlights;
using booking.libGetHotels;

namespace Webapp
{
    public class Reservation
    {
        public Flight flight { get; set; }
        public Hotel hotel { get; set; }
    }
}