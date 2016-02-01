using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking.libGetHotels
{
    public class libGetHotels
    {
        public List<Hotel> getAvailableHotels()
        {
            List<Hotel> res = new List<Hotel>();
            res.Add(new Hotel(1, "campanil", "Nantes", "20 rue des cerisiers", 60));
            res.Add(new Hotel(1, "nom2", "Nantes", "20 rue la liberté", 75));
            res.Add(new Hotel(1, "nom3", "Nantes", "20 av Pasteur", 80));
            return res;
        }
    }
}
