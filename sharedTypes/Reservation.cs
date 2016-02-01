using System;

namespace booking.commonTypes
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