using System;
using System.Collections.Generic;
using log4net;
using DXCTechnology.Belcorp.ePlanning.DataAccessLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer
{
	public class BL_Palanca
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Palanca.
		/// </summary>
		public void Insert(ModelPalanca x_oModelPalanca)
		{
			 new DA_Palanca().Insert(x_oModelPalanca);
		}

		/// <summary>
		/// Actualiza a registro de la tabla Palanca.
		/// </summary>
		public void Update(ModelPalanca x_oModelPalanca)
		{
			 new DA_Palanca().Update(x_oModelPalanca);
		}

		/// <summary>
		/// Elimina un registro de la tabla Palanca por su primary key.
		/// </summary>
		public void Delete(short IdPalanca)
		{
			 new DA_Palanca().Delete(IdPalanca);
		}

		/// <summary>
		/// Selecciona una registro de la tabla Palanca por su primary key.
		/// </summary>
		public ModelPalanca Select(short IdPalanca)
		{
			return new DA_Palanca().Select(IdPalanca);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Palanca.
		/// </summary>
		public List<ModelPalanca> SelectAll()
		{
			 return new DA_Palanca().SelectAll();
		}


		#endregion
	}
}
