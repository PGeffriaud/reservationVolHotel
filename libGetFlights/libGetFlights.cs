using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using booking.commonTypes;
using libGetFlights.wsFlights;

namespace booking.libGetFlights
{
    public class libGetFlights
    {
        public List<Flight> getAvailableFlights()
        {
            WSFlights ws = new WSFlights();

            flight[] tabFlight = ws.getFlights();
            List<Flight> resList = new List<Flight>();

            for(int i=0; i<tabFlight.Length; i++)
            {
                flight flight = tabFlight[i];
                Flight f = new Flight();
                f.id = flight.id;
                f.numPlane = flight.numPlane;
                f.dateStart = flight.dateStart;
                f.dateEnd = flight.dateEnd;
                f.cityFrom = flight.cityFrom;
                f.cityTo = flight.cityTo;
                f.cityFromCode = flight.cityFromCode;
                f.cityToCode = flight.cityToCode;
                f.price = flight.price;
                resList.Add(f);

            }
            return resList;
        }
    }
}
