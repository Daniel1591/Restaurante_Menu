using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurante_Datos;

namespace Restaurante_Logica
{
	public class AccionesCategorias
	{
		protected RestauranteEntities contexto = new RestauranteEntities();

		public List<Categoria> ObtenerTodas()
		{
			return this.contexto.Categorias.ToList();
		}
	}
}
