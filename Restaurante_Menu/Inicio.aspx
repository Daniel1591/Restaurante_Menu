<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Restaurante_Menu.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Css/Inicio.css" rel="stylesheet" />
</head>
<body>
 <div class="loginbox">

     <img src="Imagenes/logo.png" class="user" alt="Alternate Text"/>

     <h2>Iniciar Sesion</h2>
     <form runat="server">

<asp:Label Text="Email" CssClass="lblemail" runat="server" />
<asp:TextBox CssClass="txtemail" runat="server" placeholder="Enter Email" ID="txtEmail" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="El correo electronico es obligatorio." ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>



<asp:Label Text="Password" CssClass="lblpass" runat="server" />
<asp:TextBox CssClass="txtpass" runat="server" type="password" placeholder="Enter Password" ID="txtClave" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="La clave es obligatoria." ControlToValidate="txtClave" ForeColor="Red"></asp:RequiredFieldValidator>
         <asp:Button Text="Inicio" CssClass="btnsubmit" runat="server" ID="btnInicio" OnClick="btnIncio" />
     </form>
     <asp:Label ID="lblInicioSession" runat="server" Text="" ForeColor="Red"></asp:Label>
 </div>
</body>
</html>
