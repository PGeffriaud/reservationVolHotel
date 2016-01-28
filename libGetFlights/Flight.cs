using System;

namespace booking.libGetFlights
{
    public class Flight
    {
        public int id;
        public string numPlane;
        public DateTime dateStart;
        public DateTime dateEnd;
        public string cityFrom;
        public string cityTo;
        public string cityFromCode;
        public string cityToCode;

        public Flight(int id, string numPlane, DateTime dateStart, DateTime dateEnd, string cityFrom, string cityTo, string cityFromCode, string cityToCode)
        {
            this.id = id;
            this.numPlane = numPlane;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
            this.cityFrom = cityFrom;
            this.cityTo = cityTo;
            this.cityFromCode = cityFromCode;
            this.cityToCode = cityToCode;
        }
    }
}