using System;

namespace booking.commonTypes
{
    public class Hotel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string adress { get; set; }
        public double price { get; set; }

        public Hotel()
        {
        }

        public Hotel(int id, string name, string city, string adress, double price)
        {
            this.id = id;
            this.name = name;
            this.city = city;
            this.adress = adress;
            this.price = price;
        }
    }
}