using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_Logica
{
    class Administracion_General_Restaurantes
    {
        Restaurante_Datos.RestauranteEntities conexionBD = new Restaurante_Datos.RestauranteEntities();

        public bool insertarRestaurantes(String nombreRest, int categoria, int idMenu)
        {
            try
            {

                conexionBD.InsertarRestaurantes(nombreRest, categoria, idMenu);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool modificarRestaurantes(int id, String nombreRest, int categoria, int idMenu)
        {
            try
            {

                conexionBD.ModificarRestaurante(id, nombreRest, categoria, idMenu);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool eliminarRestaurantes(int id)
        {
            try
            {

                conexionBD.EliminarRestaurante(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<Restaurante_Datos.Restaurante> mostrarRestaurantes()
        {
            using (Restaurante_Datos.RestauranteEntities BD = new Restaurante_Datos.RestauranteEntities())
            {

                return BD.Restaurantes.ToList();
            }
        }
    }
}
