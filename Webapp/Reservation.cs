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
        public string idClient { get; set; }
        public int idFlight { get; set; }
        public int idHotel { get; set; }
        public DateTime hotelDateFrom { get; set; }
        public DateTime hotelDateTo { get; set; }

    }
}