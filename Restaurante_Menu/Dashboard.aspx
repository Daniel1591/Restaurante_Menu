<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Restaurante_Menu.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="jumbotron" style="text-align: center">
            <h3 class="text-muted">MANTENIMIENTO DE RESTAURANTES</h3>
        </div>
        <div class="img-thumbnail">

            <asp:GridView ID="gvRestaurantes" runat="server" CssClass="table"
                DataKeyNames="Id_Restaurante" OnSelectedIndexChanged="gvRestaurantes_SelectedIndexChanged"
                AutoGenerateColumns="false">
                <Columns>
                    <asp:CommandField ButtonType="Link" ShowSelectButton="true" HeaderText="SELECCIONAR" />

                    <asp:TemplateField HeaderText="CÓDIGO" Visible="false">
                        <ItemTemplate>
                            <asp:Label ID="lbIdRestaurante" runat="server" Text='<% # Bind("Id_Restaurante")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="NOMBRE RESTAURANTE">
                        <ItemTemplate>
                            <asp:Label ID="lbNombreRestaurante" runat="server" Text='<% # Bind("Nombre")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="CATEGORÍA">
                        <ItemTemplate>
                            <asp:Label ID="lbCategoriaRestaurante" runat="server" Text='<% # Bind("Descripcion_Categoria")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <div class="img-thumbnail" style="padding-top: 10px; padding-left: 50px; padding-right: 50px; text-align:center">
            <asp:Button ID="btnEliminar" runat="server" CssClass="btn btn-info" Text="Eliminar Restaurante" OnClick="btnEliminar_Click" />
            <asp:Button ID="btnEditar" runat="server" CssClass="btn btn-info" Text="Editar Restaurante" OnClick="btnEditar_Click"/>
            <asp:Button ID="btnInsertar" runat="server" CssClass="btn btn-info" Text="Insertar Restaurante" OnClick="btnInsertar_Click"/>
        
        </div>
    </div>
</asp:Content>
