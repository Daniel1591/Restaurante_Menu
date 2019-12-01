using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_Logica
{
    public class Inicio_Sesion
    {

        public Boolean validaCredenciales(String email, String password)
        {

            //try
            //{

            if("johan".Equals(email) && "123".Equals(password))
            {
                return true;
            }
            else
            {
                return false;
            }

            //} catch (Exception ex)
            //{

            //}
        }

    }
}
