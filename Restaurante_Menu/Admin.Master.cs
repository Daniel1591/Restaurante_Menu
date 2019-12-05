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
   
    public partial class Admin : System.Web.UI.MasterPage
	{
        Restaurante_Logica.Inicio_Sesion inicio = new Inicio_Sesion();
        Inicio s = new Inicio();
        Restaurante_Datos.RestauranteEntities conexionBD = new Restaurante_Datos.RestauranteEntities();
        protected void Page_Load(object sender, EventArgs e)
		{
            
		}

        public void eliminarSesion()
        {


          

                if (s.Session["sesion"] != null)
                {
                    s.Session.Remove("sesion");
                    Response.Redirect("~/Default.aspx");
                    
                    

                }
              


        }

        protected void cerraSesion_Click(object sender, EventArgs e)
        {
            eliminarSesion();
        }
    }

	}
