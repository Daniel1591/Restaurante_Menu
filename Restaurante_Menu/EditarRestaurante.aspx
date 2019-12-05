<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="EditarRestaurante.aspx.cs" Inherits="Restaurante_Menu.EditarRestaurante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <div class="card card-register mx-auto mt-5">
      <div class="card-header">Restaurante</div>
      <div class="card-body">
          <div class="form-group">
            <div class="form-label-group">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server" class="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* Campo requerido" ControlToValidate="txtNombre" BorderColor="Red"></asp:RequiredFieldValidator>
            </div>
          </div>
          <div class="form-group">
            <div class="form-label-group">
                <asp:Label ID="lblCategoria" runat="server" Text="Categoria"></asp:Label>
                <asp:DropDownList ID="ddlCategorias" runat="server" DataValueField="Id_Categoria" DataTextField="Descripcion_Categoria" class="form-control"></asp:DropDownList>
            </div>
          </div>
          <asp:Button class="btn btn-primary btn-block" ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
      </div>
        <asp:Label ID="lblMensaje" runat="server" Text="" Font-Italic="True" ForeColor="Red"></asp:Label>
    </div>
  </div>
    <asp:HiddenField ID="hdnIdentificador" runat="server" />
</asp:Content>
