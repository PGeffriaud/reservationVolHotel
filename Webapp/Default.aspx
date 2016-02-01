<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Webapp.Default" EnableEventValidation="false" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <link href="http://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet"/>
    <link type="text/css" rel="stylesheet" href="css/materialize.min.css"  media="screen,projection"/>
    <link type="text/css" rel="stylesheet" href="css/style.css" />

    <script type="text/javascript" src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script type="text/javascript" src="js/materialize.min.js"></script>
    <script type="text/javascript" src="js/script.js"></script>

    <title>Réservation - EMN2016</title>
</head>
<body>
    <div class="row">
    <form id="formResa" runat="server" class="col s12">

        <div class="row col s8 offset-s2">
            <h2>Welcome to our booking webApp !</h2> 
        </div>
           
        <div class="row col s12 card-panel teal lighten-2">
            <asp:Label ID="labelResult" runat="server" Text=""></asp:Label>
        </div>
        <div class="row">
            <div class="col s6">
                <asp:GridView ID="tableFlights" runat="server" CssClass="center-align highlight" HeaderStyle-BackColor="#bdbdbd" OnRowDataBound="tableFlights_GridViewRowEventHandler" AutoGenerateColumns="false" OnSelectedIndexChanged="tableFlights_SelectedIndexChanged">
                    <Columns> 
                        <asp:BoundField DataField="numPlane" HeaderText="Numéro"  />
                        <asp:BoundField DataField="dateStart" HeaderText="Date départ"  />
                        <asp:BoundField DataField="dateEnd" HeaderText="Date arrivée"  />
                        <asp:BoundField DataField="cityFrom" HeaderText="Ville départ"  />
                        <asp:BoundField DataField="cityTo" HeaderText="Ville arrivée"  />
                    </Columns>
                    <HeaderStyle BackColor="#BDBDBD"></HeaderStyle>
                    <SelectedRowStyle BackColor="#BDBDBD" />
                </asp:GridView>
            </div>
            <div class="col s6">
                <asp:GridView ID="tableHotels" runat="server" CssClass="center-align highlight" HeaderStyle-BackColor="#bdbdbd" OnRowDataBound="tableHotels_GridViewRowEventHandler" AutoGenerateColumns="false" OnSelectedIndexChanged="tableHotels_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="name" HeaderText="Nom"  />
                        <asp:BoundField DataField="city" HeaderText="Ville"  />
                        <asp:BoundField DataField="adress" HeaderText="Adresse"  />
                        <asp:BoundField DataField="price" HeaderText="Prix"  />
                    </Columns>
                    <HeaderStyle BackColor="#BDBDBD"></HeaderStyle>
                    <SelectedRowStyle BackColor="#BDBDBD" />
                </asp:GridView>
            </div>
        </div>
        <div class="row col s2 offset-s5">
             <button data-target="modalCoord" class="btn modal-trigger">Réserver</button>
        </div>
        
        <div id="modalCoord" class="modal">
        <div class="row modal-content">
            <h4>Informations personnelles</h4>
            <div class="input-field col s6">
                <i class="material-icons prefix">account_circle</i>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                <label for="txtName">Name</label>
            </div>
            <div class="input-field col s6">
                <i class="material-icons prefix">phone</i>
                <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
                <label for="txtTel">Telephone</label>
            </div>
        </div>
        <div class="modal-footer">
            <asp:LinkButton ID="btnSubmit" runat="server" CssClass="btn waves-effect waves-light" OnClick="btnSubmit_Click">Submit<i class="material-icons right">send</i></asp:LinkButton>
        </div>
        </div>
          
    </form>
    </div>
</body>
</html>
