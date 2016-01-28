using System;

namespace booking.libGetFlights
{
    public class Flight
    {
        public int id { get; set; }
        public string numPlane { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }
        public string cityFrom { get; set; }
        public string cityTo { get; set; }
        public string cityFromCode { get; set; }
        public string cityToCode { get; set; }

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