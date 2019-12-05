using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Restaurante_Logica;
using Restaurante_Datos;

namespace Restaurante_Menu
{
    public partial class Inicio : System.Web.UI.Page
    {
        Restaurante_Logica.Inicio_Sesion usuarios = new Restaurante_Logica.Inicio_Sesion();

        protected void Page_Load(object sender, EventArgs e)
        {


        }


        protected void btnIncio(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                

                try
                {
                    Usuario usuario = null;
                    if (usuarios.validaCredenciales(this.txtEmail.Text, this.txtClave.Text, out usuario))
                    {
                        Page.Session.Add("sesion", usuario);

                        Response.Redirect("~/Dashboard.aspx");
                    }
                    else
                    {
                        this.lblInicioSession.Text = "Correo y/o Clave incorrectas. Intente de nuevo.";

                    }
                }
                catch (Exception ex)
                {

                    this.lblInicioSession.Text = ex.GetBaseException().Message;
                }
            }

        }
        }
    }
