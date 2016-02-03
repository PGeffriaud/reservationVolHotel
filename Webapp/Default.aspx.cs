using System;
using System.Data;
using System.Collections.Generic;
using System.Messaging;
using System.Web.UI.WebControls;
using booking.libGetInfos;
using booking.commonTypes;

namespace Webapp
{
    public partial class Default : System.Web.UI.Page
    {
        List<Flight> flights;
        List<Hotel> hotels;

        protected void Page_Load(object sender, EventArgs e)
        {
            libGetInfos libInfos = new libGetInfos();

            // Génération liste des vols
            flights = libInfos.getListFlights();
            tableFlights.DataSource = flights;
            tableFlights.DataBind();

            // Génération liste des hôtels
            hotels = libInfos.getListHotels();
            tableHotels.DataSource = hotels;
            tableHotels.DataBind();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Création de l'objet Reservation
            Reservation resa = new Reservation();
            resa.idClient = Guid.NewGuid().ToString();

            Flight selectedFlight = flights[tableFlights.SelectedIndex];
            resa.idFlight = selectedFlight.id;

            Hotel selectedHotel = hotels[tableHotels.SelectedIndex];
            resa.idHotel = selectedHotel.id;

            resa.hotelDateFrom = Convert.ToDateTime(dateFrom.Text);
            resa.hotelDateTo = Convert.ToDateTime(dateTo.Text);

            // Ecriture dans la file
            MessageQueue mq = new MessageQueue(@".\private$\bookingemn");
            mq.Send(resa, "resa" + resa.idClient);
            mq.Close();

            labelResult.Text = "Réservation enregistrée";
        }

        protected void tableFlights_GridViewRowEventHandler(Object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onmouseover"] = "this.style.cursor='pointer';";
                e.Row.Attributes["onclick"] = this.Page.ClientScript.GetPostBackClientHyperlink(tableFlights, "Select$" + e.Row.RowIndex);
            }
        }

        protected void tableHotels_GridViewRowEventHandler(Object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onmouseover"] = "this.style.cursor='pointer';";
                e.Row.Attributes["onclick"] = this.Page.ClientScript.GetPostBackClientHyperlink(tableHotels, "Select$" + e.Row.RowIndex);
            }
        }

        protected void tableFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tableFlights.SelectedIndex;
            if(index >= 0)
            {
                Flight selectedFlight = flights[tableFlights.SelectedIndex];
                string selectedCity = selectedFlight.cityTo;

                libGetInfos libInfos = new libGetInfos();
                hotels = libInfos.getListHotelsOfCity(selectedCity);
                tableHotels.DataSource = hotels;
                tableHotels.DataBind();
            }
        }

        protected void tableHotels_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableFlights_SelectedIndexChanged(sender, e);
        }
    }
}