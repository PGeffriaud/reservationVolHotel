using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.EnterpriseServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libBookHotels.Properties;

namespace booking.libBookHotels
{
    [Transaction(TransactionOption.Required), ObjectPooling(5, 10), Description("Booking EMN")]
    public class libBookHotels : ServicedComponent
    {
        /// <summary>
        /// Ajoute une réservation d'un hotel
        /// </summary>
        /// <param name="idClient">identifiant commun du client</param>
        /// <param name="idHotel">identifiant de l'hotel</param>
        /// <param name="dateFrom">date de début de la réservation (limitée au jour)</param>
        /// <param name="dateTo">date de fin de la réservation (limitée au jour)</param>
        [AutoComplete]
        public void bookHotel(string idClient, int idHotel, DateTime dateFrom, DateTime dateTo)
        {
            SqlConnection connection = new SqlConnection();
            var host = Settings.Default["host"];
            connection.ConnectionString = "Data Source=" + host + "\\SQLEXPRESS;Initial Catalog=BNBHOTEL;Integrated Security=True";
            connection.Open();
            SqlCommand myCmd = new SqlCommand("createBookHotel", connection);
            myCmd.CommandType = System.Data.CommandType.StoredProcedure;
            myCmd.Parameters.Add(new SqlParameter("@idClient", idClient));
            myCmd.Parameters.Add(new SqlParameter("@idHotel", idHotel));
            myCmd.Parameters.Add(new SqlParameter("@dateFrom", dateFrom));
            myCmd.Parameters.Add(new SqlParameter("@dateTo", dateTo));
            Convert.ToInt32(myCmd.ExecuteNonQuery());
            connection.Close();
        }
    }
}
