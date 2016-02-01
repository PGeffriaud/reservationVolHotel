<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Webapp.Default" EnableEventValidation="false" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <link href="http://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet"/>
    <link type="text/css" rel="stylesheet" href="css/materialize.min.css"  media="screen,projection"/>
    <link type="text/css" rel="stylesheet" href="css/style.css" />

    <script type="text/javascript" src="js/jquery-2.2.0.min.js"></script>
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
           
        <!-- Liste des vols et hotels disponibles -->
        <div class="row col s12 card-panel teal lighten-2">
            <asp:Label ID="labelResult" runat="server" Text=""></asp:Label>
        </div>
        <div class="row">
            <div class="col s6">
                <asp:GridView ID="tableFlights" runat="server" CssClass="center-align highlight bordered" OnRowDataBound="tableFlights_GridViewRowEventHandler" AutoGenerateColumns="false" >
                    <Columns> 
                        <asp:BoundField DataField="id" HeaderText="Id" Visible="false" />
                        <asp:BoundField DataField="numPlane" HeaderText="Numéro" />
                        <asp:BoundField DataField="dateStart" HeaderText="Départ" DataFormatString="{0:d}" />
                        <asp:BoundField DataField="dateEnd" HeaderText="Arrivée" DataFormatString="{0:d}" />
                        <asp:BoundField DataField="cityFrom" HeaderText="Ville départ" />
                        <asp:BoundField DataField="cityTo" HeaderText="Ville arrivée" />
                        <asp:BoundField DataField="price" HeaderText="Prix" DataFormatString="{0:C}" />
                    </Columns>
                    <HeaderStyle BackColor="#eeeeee" />
                    <SelectedRowStyle BackColor="#4db6ac" />
                </asp:GridView>
            </div>
            <div class="col s6">
                <asp:GridView ID="tableHotels" runat="server" CssClass="center-align highlight bordered" OnRowDataBound="tableHotels_GridViewRowEventHandler" AutoGenerateColumns="false" >
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="Id" Visible="false"/>
                        <asp:BoundField DataField="name" HeaderText="Nom" />
                        <asp:BoundField DataField="city" HeaderText="Ville" />
                        <asp:BoundField DataField="adress" HeaderText="Adresse"  />
                        <asp:BoundField DataField="price" HeaderText="Prix" DataFormatString="{0:C}" />
                    </Columns>
                    <HeaderStyle BackColor="#eeeeee"></HeaderStyle>
                    <SelectedRowStyle BackColor="#4db6ac" />
                </asp:GridView>
            </div>
        </div>
        <div class="row col s2 offset-s5">
             <button data-target="modalCoord" class="btn modal-trigger">Réserver</button>
        </div>
        
        <!-- Page modal : fomulaire de réservation -->
        <div id="modalCoord" class="modal">
        <div class="modal-content">
            <h4>Informations personnelles</h4>
            <div class="row">
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
            <div class="row">
                <div class="input-field col s6">
                    <i class="material-icons prefix">schedule</i>
                    <asp:TextBox ID="dateFrom" runat="server" CssClass="datepicker"></asp:TextBox>
                    <label for="dateFrom">Début réservation</label>
                </div>
                <div class="input-field col s6">
                    <i class="material-icons prefix">schedule</i>
                    <asp:TextBox ID="dateTo" runat="server" CssClass="datepicker" ></asp:TextBox>
                    <label for="dateFrom">Fin  réservation</label>
                </div>
            </div>
            <div class="row input-field col s12">
                <i class="material-icons prefix">vpn_key</i>
                <asp:TextBox ID="txtNumCompte" runat="server"></asp:TextBox>
                <label for="txtIban">Numéro carte bleue</label>
            </div>
        <div class="modal-footer">
            <asp:LinkButton ID="btnSubmit" runat="server" CssClass="btn waves-effect waves-light" OnClick="btnSubmit_Click">Submit<i class="material-icons right">send</i></asp:LinkButton>
        </div>
        </div>
        </div>
          
    </form>
    </div>
</body>
</html>
