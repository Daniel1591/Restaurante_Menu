using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Restaurante_Menu
{
    public partial class Dashboard : System.Web.UI.Page
    {

        Restaurante_Logica.Administracion_General_Restaurantes conexion = new Restaurante_Logica.Administracion_General_Restaurantes();
        int index = -1;

        protected void Page_Load(object sender, EventArgs e)
        {

            cargarTabla();

            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnInsertar.Enabled = true;
        }

        private void cargarTabla()
        {
            gvRestaurantes.DataSource = conexion.mostrarRestaurantes();
            gvRestaurantes.DataBind();
        }

        protected void gvRestaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvRestaurantes.SelectedRow.BackColor = Color.SkyBlue;
            index = gvRestaurantes.SelectedRow.RowIndex;

            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
            btnInsertar.Enabled = false;

            Label lbId = gvRestaurantes.Rows[index].FindControl("lbIdRestaurante") as Label;
            Session["id"] = Convert.ToInt32(lbId.Text);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            conexion.eliminarRestaurantes(Convert.ToInt32(Session["id"]));
            // Mostrar mensaje de eliminado correctamente.
            cargarTabla();
            Session.Remove("id");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EditarRestaurante.aspx");
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EditarRestaurante.aspx");
        }

    }
}