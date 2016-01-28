<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Webapp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="http://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet"/>
    <link type="text/css" rel="stylesheet" href="css/materialize.min.css"  media="screen,projection"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script type="text/javascript" src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script type="text/javascript" src="js/materialize.min.js"></script>
    <script type="text/javascript" src="js/script.js"></script>
    <title>Reservation - EMN2016</title>
</head>
<body>
    <div class="row">
    <form id="formResa" runat="server" class="col s12">

        <div class="row col s6 offset-s3">
            <h2>Welcome to our webApp !</h2>
        </div>
           
        <div class="row col s12 card-panel teal lighten-2">
            <asp:Label ID="labelResult" runat="server" Text=""></asp:Label>
        </div>
        <div class="row col s12">
            <asp:GridView ID="tableFlights" runat="server">
            </asp:GridView>
        </div>
        <div class="row col s12">
            <asp:GridView ID="tableHotels" runat="server">
            </asp:GridView>
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
