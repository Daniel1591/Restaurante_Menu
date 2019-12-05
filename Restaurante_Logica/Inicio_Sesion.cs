using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurante_Datos;

namespace Restaurante_Logica
{


    public class Inicio_Sesion
    {
        
        Restaurante_Datos.RestauranteEntities conexionBD = new Restaurante_Datos.RestauranteEntities();
        public bool validaCredenciales(String email, String password, out Usuario usuariOutput)
        {
            
                string encriptada = this.encriptarClaveUsuario(password);

                Usuario usuario = (from datos in conexionBD.Usuarios
                where datos.Correo == email && datos.Contrasena == encriptada select datos).FirstOrDefault();
                usuariOutput = usuario;
                return (usuario != null);


        }

        public string encriptarClaveUsuario(string password)
        {

            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] datos = md5.ComputeHash(Encoding.Default.GetBytes(password));
            StringBuilder strConstructor = new StringBuilder();
            for (int i = 0; i < datos.Length; i++)
            {
                strConstructor.Append(datos[i].ToString("x2"));
            }
            return strConstructor.ToString();
        }

  
       

    }
}
