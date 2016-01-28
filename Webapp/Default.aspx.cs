using System;
using System.Data;
using System.Collections.Generic;
using booking.libGetFlights;
using booking.libGetHotels;

namespace Webapp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Génération liste des vols
            libGetFlights libFlights = new libGetFlights();
            List<Flight> flights = libFlights.getAvailableFlights();
            tableFlights.DataSource = flights;
            tableFlights.DataBind();

            // Génération liste des hôtels
            libGetHotels libHotels = new libGetHotels();
            List<Hotel> hotels = libHotels.getAvailableHotels();
            tableHotels.DataSource = hotels;
            tableHotels.DataBind();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            labelResult.Text = "Félicitations: "+txtName.Text+" -- Réservation effectuée !";
        }
    }
}