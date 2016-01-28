namespace booking.libGetHotels
{
    public class Hotel
    {
        public int id;
        public string name;
        public string city;
        public string adress;
        public int price;

        public Hotel(int id, string name, string city, string adress, int price)
        {
            this.id = id;
            this.name = name;
            this.city = city;
            this.adress = adress;
            this.price = price;
        }
    }
}