using System;
using System.Collections.Generic;
using log4net;
using DXCTechnology.Belcorp.ePlanning.DataAccessLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer
{
	public class BL_Categoria
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Categoria.
		/// </summary>
		public void Insert(ModelCategoria x_oModelCategoria)
		{
			 new DA_Categoria().Insert(x_oModelCategoria);
		}

		/// <summary>
		/// Actualiza a registro de la tabla Categoria.
		/// </summary>
		public void Update(ModelCategoria x_oModelCategoria)
		{
			 new DA_Categoria().Update(x_oModelCategoria);
		}

		/// <summary>
		/// Elimina un registro de la tabla Categoria por su primary key.
		/// </summary>
		public void Delete(int IdCategoria)
		{
			 new DA_Categoria().Delete(IdCategoria);
		}

		/// <summary>
		/// Selecciona una registro de la tabla Categoria por su primary key.
		/// </summary>
		public ModelCategoria Select(int IdCategoria)
		{
			return new DA_Categoria().Select(IdCategoria);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Categoria.
		/// </summary>
		public List<ModelCategoria> SelectAll()
		{
			 return new DA_Categoria().SelectAll();
		}


		#endregion
	}
}
