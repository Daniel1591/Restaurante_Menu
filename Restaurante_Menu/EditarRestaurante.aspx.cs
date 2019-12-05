using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Restaurante_Logica;

namespace Restaurante_Menu
{
    public partial class EditarRestaurante : System.Web.UI.Page
    {
        private AccionesCategorias categorias = new AccionesCategorias();
        private AccionesRestaurantes restaurantes = new AccionesRestaurantes();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.cargarCategorias();
                this.cargarRestaurante();
            }
        }


        private void cargarRestaurante()
        {

            if (Session["id"] != null)
            {
                int Identificador = int.Parse(Session["id"].ToString());
                var restaurante = this.restaurantes.ObtenRestaurantePorIdentificador(Identificador);

                if (restaurante == null)
                {
                    return;
                }
                this.txtNombre.Text = restaurante.Nombre;
                this.ddlCategorias.SelectedValue = restaurante.Id_Categorias.ToString();
                this.hdnIdentificador.Value = Identificador.ToString();
            }
        }

        private void cargarCategorias()
        {
            try
            {
                this.ddlCategorias.DataSource = this.categorias.ObtenerTodas();
                this.ddlCategorias.DataBind();
            }
            catch (Exception ex)
            {
                this.lblMensaje.Text = ex.GetBaseException().Message;
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string Identificador = this.hdnIdentificador.Value;
                if (String.IsNullOrEmpty(Identificador))
                {
                    this.restaurantes.CrearRestaurante(
                        this.txtNombre.Text,
                        int.Parse(this.ddlCategorias.SelectedValue)
                    );
                }
                else
                {
                    int? IdMenu = null;
                    this.restaurantes.ActualizarRestaurante(
                        int.Parse(Identificador),
                        this.txtNombre.Text,
                        int.Parse(this.ddlCategorias.SelectedValue),
                        IdMenu
                    );
                }

                Session.Remove("id");

                // Mostrar mensaje de salvado correctamente.
                Response.Redirect("~/Dashboard.aspx");
            }
            catch (Exception ex)
            {
                this.lblMensaje.Text = ex.GetBaseException().Message;
            }
        }

    }
}