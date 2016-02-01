using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using libBookFlights.Properties;

namespace booking.libBookFlights
{
    [Transaction(TransactionOption.Required), ObjectPooling(5, 10), Description("Booking EMN")]
    public class libBookFlights
    {
        /// <summary>
        /// Ajoute une réservation d'un vol
        /// </summary>
        /// <param name="idClient">Identifiant commun du client</param>
        /// <param name="idFlight">Identifiant du vol</param>
        [AutoComplete]
        public void bookFlight(int idClient, int idFlight)
        {
            SqlConnection connection = new SqlConnection();
            var host = Settings.Default["host"];
            connection.ConnectionString = "Data Source=" + host + "\\SQLEXPRESS;Initial Catalog=AIRFLIGHT;Integrated Security=True";
            connection.Open();
            SqlCommand myCmd = new SqlCommand("createBookFlight", connection);
            myCmd.CommandType = System.Data.CommandType.StoredProcedure;
            myCmd.Parameters.Add(new SqlParameter("@idClient", idClient));
            myCmd.Parameters.Add(new SqlParameter("@idFlight", idFlight));
            Convert.ToInt32(myCmd.ExecuteNonQuery());
            connection.Close();
        }
    }
}
