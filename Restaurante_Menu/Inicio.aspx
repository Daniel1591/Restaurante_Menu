<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Restaurante_Menu.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Css/Inicio.css" rel="stylesheet" />
</head>
<body>
    <div class="loginbox">
        <img src="imagenes/logo.png" " alt="Alternate Text" class="user"/>
       
        <h2>Iniciar Sesion</h2>
        <form runat="server">
            <asp:Label Text="Email" CssClass="lblemail" runat="server" />
            <asp:TextBox runat="server" CssClass="txtemail" placeholder="Enter Email" />

            <asp:Label Text="Password" CssClass="lblpass" runat="server"/>
            <asp:TextBox runat="server" CssClass="txtpass" type="password" placeholder="Enter Passworld" />

            <asp:Button Text="Inicio" CssClass="btnsubmit" runat="server" />
        </form>
        
    </div>
</body>
</html>
