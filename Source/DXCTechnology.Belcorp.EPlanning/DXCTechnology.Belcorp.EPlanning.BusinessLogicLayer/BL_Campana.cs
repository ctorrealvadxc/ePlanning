using System;
using System.Collections.Generic;
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
		public void Insert(CampanaModel x_oCampanaModel)
		{
			 new DA_Campana().Insert(x_oCampanaModel);
		}

		/// <summary>
		/// Actualiza a registro de la tabla Campana.
		/// </summary>
		public void Update(CampanaModel x_oCampanaModel)
		{
			 new DA_Campana().Update(x_oCampanaModel);
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
		public CampanaModel Select(int IdCampana)
		{
			return new DA_Campana().Select(IdCampana);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Campana.
		/// </summary>
		public List<CampanaModel> SelectAll(CampanaModel campanaModel)
		{
			 return new DA_Campana().SelectAll(campanaModel);
		}

        public List<CampanaModel> SelectProceso(CampanaModel campanaModel)
        {
            return new DA_Campana().SelectProceso(campanaModel);
        }
        

        #endregion
    }
}
