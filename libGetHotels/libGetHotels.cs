using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using booking.commonTypes;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using libGetHotels.Properties;

namespace booking.libGetHotels
{
    public class libGetHotels
    {
        public List<Hotel> getAvailableHotels()
        {
            var truc = Settings.Default["URL_WSHOTELS"];
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(truc+"getHotels");
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            string jsonResult = reader.ReadToEnd();

            List<Hotel> listHotels = JsonConvert.DeserializeObject<List<Hotel>>(jsonResult);

            return listHotels;
        }

        public List<Hotel> getAvailableHotelsOfCity(string city)
        {
            var truc = Settings.Default["URL_WSHOTELS"];
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(truc + "getHotels/" + city);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            string jsonResult = reader.ReadToEnd();

            List<Hotel> listHotels = JsonConvert.DeserializeObject<List<Hotel>>(jsonResult);

            return listHotels;
        }
    }
}
