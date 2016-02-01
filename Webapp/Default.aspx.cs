using System;
using System.Data;
using System.Collections.Generic;
using System.Messaging;
using booking.libGetInfos;
using booking.libGetFlights;
using booking.libGetHotels;
using System.Web.UI.WebControls;
using booking.Reservation;

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
                e.Row.Attributes["onclick"] = this.Page.ClientScript.GetPostBackClientHyperlink(this.tableFlights, "Select$" + e.Row.RowIndex);
            }
        }

        protected void tableHotels_GridViewRowEventHandler(Object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onmouseover"] = "this.style.cursor='pointer';";
                e.Row.Attributes["onclick"] = this.Page.ClientScript.GetPostBackClientHyperlink(this.tableHotels, "Select$" + e.Row.RowIndex);
            }
        }

    }
}