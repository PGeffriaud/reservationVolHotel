<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Webapp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="http://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <link type="text/css" rel="stylesheet" href="css/materialize.min.css"  media="screen,projection"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script type="text/javascript" src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script type="text/javascript" src="js/materialize.min.js"></script>
    <title>Reservation - EMN2016</title>
</head>
<body>
    <div class="row">
    <form id="form1" runat="server" class="col s12">

        <div class="row col s6 offset-s3">
            <h2>Welcome to our webApp !</h2>
        </div>
            <div class="row input-field col s5 offset-s3">
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                <label for="txtName">Name</label>
            </div>
            <div class="row input-field col s5 offset-s3">
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                <label for="txtFirstName">Firsname</label>
            </div>
        <div class="row col s3 offset-s5">
        <asp:LinkButton ID="btnSubmit" runat="server" CssClass="btn waves-effect waves-light">Submit</asp:LinkButton>      
        </div>
    </form>
    </div>
</body>
</html>
