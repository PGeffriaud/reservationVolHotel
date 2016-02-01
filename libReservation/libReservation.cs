using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking.libReservation
{
    [Transaction(TransactionOption.Required), ObjectPooling(5, 10), Description("Booking EMN")]
    public class libReservation : ServicedComponent
    {
        [AutoComplete]
        public void reservation(int idClient, int idFlight, int idHotel, DateTime dateFrom, DateTime dateTo)
        {
            
        }
    }
}
