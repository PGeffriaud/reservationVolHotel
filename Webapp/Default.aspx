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
    <form id="form1" runat="server" class="col s12">

        <div class="row col s6 offset-s3">
            <h2>Welcome to our webApp !</h2>
        </div>
            <div class="row input-field col s5 offset-s3">
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                <label for="txtFirstName">Firsname</label>
            </div>
            <div class="row input-field col s5 offset-s3">
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                <label for="txtName">Name</label>
            </div>
        <div class="row col s1 offset-s5">
        <asp:LinkButton ID="btnSubmit" runat="server" CssClass="btn waves-effect waves-light" OnClick="btnSubmit_Click">Submit<i class="material-icons right">send</i></asp:LinkButton>      
        </div>
        <div class="row col s12">
            <asp:Label ID="labelResult" runat="server" Text=""></asp:Label>
        </div>
        <div class="row col s10 offset-s1">
            
        </div>
        

    </form>
          <div id="modal1" class="modal">
            <div class="modal-content">
              <h4>Modal Header</h4>
              <p>A bunch of text</p>
            </div>
            <div class="modal-footer">
              <a href="#!" class=" modal-action modal-close waves-effect waves-green btn-flat">Agree</a>
            </div>
          </div>
        <div class="row col s2 offset-s5">
             <button data-target="modal1" class="btn modal-trigger">Modal</button>
        </div>
    </div>
</body>
</html>
