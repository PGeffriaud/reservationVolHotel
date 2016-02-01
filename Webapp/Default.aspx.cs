using System;
using System.Data;
using System.Collections.Generic;
using System.Messaging;
using booking.libGetInfos;
using booking.libGetFlights;
using booking.libGetHotels;
using System.Web.UI.WebControls;

namespace Webapp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            libGetInfos libInfos = new libGetInfos();

            // Génération liste des vols
            List<Flight> flights = libInfos.getListFlights();
            tableFlights.DataSource = flights;
            tableFlights.DataBind();

            // Génération liste des hôtels
            List<Hotel> hotels = libInfos.getListHotels();
            tableHotels.DataSource = hotels;
            tableHotels.DataBind();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Récupération de l'objet Reservation
            Reservation resa = new Reservation();
            labelResult.Text = tableFlights.SelectedRow.ToString();

            resa.flight = new Flight(1, "FL001", new DateTime(2016, 1, 1), new DateTime(2016, 1, 5), "Nantes", "Paris", "NAN", "CDG");
            resa.hotel = new Hotel(1, "Campanile", "Nantes", "20 rue la liberté", 75);

            // Ecriture dans la file
            //MessageQueue mq = new MessageQueue(@".\private$\bookingemn");
            //mq.Close();

            //labelResult.Text = "Félicitations: "+txtName.Text+" -- Réservation effectuée !";
        }

        protected void tableFlights_GridViewRowEventHandler(Object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onmouseover"] = "this.style.cursor='pointer';this.style.textDecoration='underline';";
                e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";
                e.Row.ToolTip = "Click to select row";
                e.Row.Attributes["onclick"] = this.Page.ClientScript.GetPostBackClientHyperlink(this.tableFlights, "Select$" + e.Row.RowIndex);
            }
        }

        protected void tableFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = tableFlights.SelectedRow.Cells[0].Text;
            labelResult.Text = "Ligne sélectionnée: " + name;
        }

        protected void tableHotels_GridViewRowEventHandler(Object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onmouseover"] = "this.style.cursor='pointer';this.style.textDecoration='underline';";
                e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";
                e.Row.ToolTip = "Click to select row";
                e.Row.Attributes["onclick"] = this.Page.ClientScript.GetPostBackClientHyperlink(this.tableHotels, "Select$" + e.Row.RowIndex);
            }
        }

        protected void tableHotels_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = tableHotels.SelectedRow.Cells[0].Text;
            labelResult.Text = "Ligne sélectionnée: " + name;
        }
    }
}