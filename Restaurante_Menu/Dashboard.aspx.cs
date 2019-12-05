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

            Label lbRecuperacion = gvRestaurantes.Rows[index].FindControl("lbIdRestaurante") as Label;
            Session["id"] = Convert.ToInt32(lbRecuperacion.Text);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            conexion.eliminarRestaurantes(Convert.ToInt32(Session["id"]));
            cargarTabla();
        }

    }
}