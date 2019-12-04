<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarRestaurante.aspx.cs" Inherits="Restaurante_Menu.EditarRestaurante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <asp:DropDownList ID="ddlCategorias" runat="server" DataValueField="Id_Categoria" DataTextField="Descripcion_Categoria"></asp:DropDownList>
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" /><br />
            <asp:Label ID="lblMensaje" runat="server" Text="" Font-Italic="True" ForeColor="Red"></asp:Label>
            <asp:HiddenField ID="hdnIdentificador" runat="server" />
        </div>
    </form>
</body>
</html>
