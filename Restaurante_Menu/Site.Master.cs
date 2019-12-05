using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Restaurante_Datos;
using Restaurante_Logica;

namespace Restaurante_Menu
{
    public partial class SiteMaster : MasterPage
    {
        Restaurante_Logica.Inicio_Sesion inicio = new Inicio_Sesion();
        Inicio s = new Inicio();
        Restaurante_Datos.RestauranteEntities conexionBD = new Restaurante_Datos.RestauranteEntities();
        protected void Page_Load(object sender, EventArgs e)

        {


            ocultar();

        }
        public void ocultar()
        {
            

                try

                {

                if (s.Session["sesion"] == null)
                    {

                    
                    Dashboard.Visible = false;
                    //IniciarSesion.Visible = true;
                }
                    else

                    //Dashboard.Visible = true;
                    IniciarSesion.Visible = false;

            }
                catch (Exception ex)
                {

                    throw new Exception("SE HA PRODUCIDO UN ERROR" + ex.Message, ex);

                }

            }
        }


    }

 
 
    
