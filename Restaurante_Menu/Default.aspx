<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Restaurante_Menu._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Restaurantes Zona del Caribe</h1>
        <p class="lead">Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...</p>
        <p><a href="https://www.lipsum.com/" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Restaurante #1</h2>
            <p>
               Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin congue erat non ipsum mollis, vitae scelerisque turpis lacinia. 
               Cras metus diam, maximus et neque ut, tristique luctus erat. Phasellus fermentum nulla velit, at iaculis urna vulputate eget. 
               Suspendisse potenti. Aenean vestibulum urna quis turpis cursus, vitae auctor nisi sagittis. 
            </p>
            <p>
                <a class="btn btn-default" href="#">Ir a pagina detalle restaurante #1 &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Restaurante #2</h2>
            <p>
                Nulla finibus at dui eu pharetra. Nam aliquam purus vel purus dapibus fringilla.
                Pellentesque blandit, turpis sit amet ullamcorper mollis, nisi dolor volutpat enim, nec tincidunt turpis purus et ligula.
            </p>
            <p>
                <a class="btn btn-default" href="#">Ir a pagina detalle restaurante #2 &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Restaurante #3</h2>
            <p>
                Morbi mattis nunc nulla, porttitor eleifend diam tincidunt ut. 
                Nam placerat a nibh vitae blandit. Sed dapibus iaculis lobortis. 
                Aenean viverra leo at quam consequat, vitae faucibus tortor tempor.
            </p>
            <p>
                <a class="btn btn-default" href="#">Ir a pagina detalle restaurante #3 &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
