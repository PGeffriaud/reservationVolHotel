using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using booking.libBookFlights;
using booking.libBookHotels;

namespace booking.libReservation
{
    [Transaction(TransactionOption.Required), ObjectPooling(5, 10), Description("Booking EMN")]
    public class libReservation : ServicedComponent
    {
        [AutoComplete]
        public void reservation(string idClient, int idFlight, int idHotel, DateTime dateFrom, DateTime dateTo)
        {
            var libBookFlights = new libBookFlights.libBookFlights();
            var libBookHotels = new libBookHotels.libBookHotels();

            libBookFlights.bookFlight(idClient,idFlight);
            libBookHotels.bookHotel(idClient,idHotel,dateFrom,dateTo);
        }
    }
}
