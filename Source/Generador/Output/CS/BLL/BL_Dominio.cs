using System;
using System.Collections.Generic;
using log4net;
using DXCTechnology.Belcorp.ePlanning.DataAccessLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer
{
	public class BL_Dominio
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Dominio.
		/// </summary>
		public void Insert(ModelDominio x_oModelDominio)
		{
			 new DA_Dominio().Insert(x_oModelDominio);
		}

		/// <summary>
		/// Actualiza a registro de la tabla Dominio.
		/// </summary>
		public void Update(ModelDominio x_oModelDominio)
		{
			 new DA_Dominio().Update(x_oModelDominio);
		}

		/// <summary>
		/// Elimina un registro de la tabla Dominio por su primary key.
		/// </summary>
		public void Delete(int IdDominio)
		{
			 new DA_Dominio().Delete(IdDominio);
		}

		/// <summary>
		/// Selecciona una registro de la tabla Dominio por su primary key.
		/// </summary>
		public ModelDominio Select(int IdDominio)
		{
			return new DA_Dominio().Select(IdDominio);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Dominio.
		/// </summary>
		public List<ModelDominio> SelectAll()
		{
			 return new DA_Dominio().SelectAll();
		}


		#endregion
	}
}
