using System;
using System.Collections.Generic;
using log4net;
using DXCTechnology.Belcorp.ePlanning.DataAccessLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer
{
	public class BL_Campana
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Campana.
		/// </summary>
		public void Insert(ModelCampana x_oModelCampana)
		{
			 new DA_Campana().Insert(x_oModelCampana);
		}

		/// <summary>
		/// Actualiza a registro de la tabla Campana.
		/// </summary>
		public void Update(ModelCampana x_oModelCampana)
		{
			 new DA_Campana().Update(x_oModelCampana);
		}

		/// <summary>
		/// Elimina un registro de la tabla Campana por su primary key.
		/// </summary>
		public void Delete(int IdCampana)
		{
			 new DA_Campana().Delete(IdCampana);
		}

		/// <summary>
		/// Selecciona una registro de la tabla Campana por su primary key.
		/// </summary>
		public ModelCampana Select(int IdCampana)
		{
			return new DA_Campana().Select(IdCampana);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Campana.
		/// </summary>
		public List<ModelCampana> SelectAll()
		{
			 return new DA_Campana().SelectAll();
		}


		#endregion
	}
}
