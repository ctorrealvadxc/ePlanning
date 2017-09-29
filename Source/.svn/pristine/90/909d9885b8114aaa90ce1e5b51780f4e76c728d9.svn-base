using System;
using System.Collections.Generic;
using log4net;
using DXCTechnology.Belcorp.ePlanning.DataAccessLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer
{
	public class BL_Marca
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Marca.
		/// </summary>
		public void Insert(ModelMarca x_oModelMarca)
		{
			 new DA_Marca().Insert(x_oModelMarca);
		}

		/// <summary>
		/// Actualiza a registro de la tabla Marca.
		/// </summary>
		public void Update(ModelMarca x_oModelMarca)
		{
			 new DA_Marca().Update(x_oModelMarca);
		}

		/// <summary>
		/// Elimina un registro de la tabla Marca por su primary key.
		/// </summary>
		public void Delete(int IdMarca)
		{
			 new DA_Marca().Delete(IdMarca);
		}

		/// <summary>
		/// Selecciona una registro de la tabla Marca por su primary key.
		/// </summary>
		public ModelMarca Select(int IdMarca)
		{
			return new DA_Marca().Select(IdMarca);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Marca.
		/// </summary>
		public List<ModelMarca> SelectAll()
		{
			 return new DA_Marca().SelectAll();
		}


		#endregion
	}
}
