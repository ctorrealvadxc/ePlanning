using System;
using System.Collections.Generic;
using log4net;
using DXCTechnology.Belcorp.ePlanning.DataAccessLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer
{
	public class BL_Pai
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Pais.
		/// </summary>
		public void Insert(ModelPai x_oModelPai)
		{
			 new DA_Pai().Insert(x_oModelPai);
		}

		/// <summary>
		/// Actualiza a registro de la tabla Pais.
		/// </summary>
		public void Update(ModelPai x_oModelPai)
		{
			 new DA_Pai().Update(x_oModelPai);
		}

		/// <summary>
		/// Elimina un registro de la tabla Pais por su primary key.
		/// </summary>
		public void Delete(byte IdPais)
		{
			 new DA_Pai().Delete(IdPais);
		}

		/// <summary>
		/// Selecciona una registro de la tabla Pais por su primary key.
		/// </summary>
		public ModelPai Select(byte IdPais)
		{
			return new DA_Pai().Select(IdPais);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Pais.
		/// </summary>
		public List<ModelPai> SelectAll()
		{
			 return new DA_Pai().SelectAll();
		}


		#endregion
	}
}
