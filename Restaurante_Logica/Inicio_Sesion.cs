using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_Logica
{
    public class Inicio_Sesion
    {

        Restaurante_Datos.RestauranteEntities conexionBD = new Restaurante_Datos.RestauranteEntities();
        public bool validaCredenciales(String email, String password)
        {

            try
            {
                
                var consulta = (from datos in conexionBD.Usuarios
                                where datos.Correo == email && datos.Contrasena == password
                                select datos).FirstOrDefault();

                if (consulta.Correo.Equals(email) && consulta.Contrasena.Equals(password))
                {

                    return true;
                } 
                else
                {

                    return false;
                }
                
            }
            catch (Exception ex)
            {

                return false;
                throw new Exception("SE HA PRODUCIDO UN ERROR" + ex.Message, ex);
            }
        }

    }
}
