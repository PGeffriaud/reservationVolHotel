using System;

namespace booking.commonTypes
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
        public double price { get; set; }

        public Flight()
        {
        }

        public Flight(int id, string numPlane, DateTime dateStart, DateTime dateEnd, string cityFrom, string cityTo, string cityFromCode, string cityToCode, double price)
        {
            this.id = id;
            this.numPlane = numPlane;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
            this.cityFrom = cityFrom;
            this.cityTo = cityTo;
            this.cityFromCode = cityFromCode;
            this.cityToCode = cityToCode;
            this.price = price;
        }
    }
}