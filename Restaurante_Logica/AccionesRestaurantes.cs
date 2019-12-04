using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurante_Datos;

namespace Restaurante_Logica
{
	public class AccionesRestaurantes
	{
		protected RestauranteEntities contexto = new RestauranteEntities();

		public Restaurante ObtenRestaurantePorIdentificador(int Identificador)
		{
			return this.contexto.Restaurantes.FirstOrDefault(r => r.Id_Restaurante == Identificador);
		}

		public void CrearRestaurante(string Nombre, int idCategoria)
		{
			this.contexto.Restaurantes.Add(new Restaurante
			{
				Nombre = Nombre,
				Id_Categorias = idCategoria,
				Id_Menu = null
			});
			this.contexto.SaveChanges();
		}

		public void ActualizarRestaurante(int Identificador, string Nombre, int IdCategoria, Nullable<int> IdMenu)
		{
			Restaurante restaurante = this.ObtenRestaurantePorIdentificador(Identificador);
			restaurante.Nombre = Nombre;
			restaurante.Id_Categorias = IdCategoria;
			restaurante.Id_Menu = IdMenu;
			this.contexto.SaveChanges();
		}
	}
}
