using System;
using System.Collections.Generic;
using DXCTechnology.Belcorp.ePlanning.DataAccessLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer
{
	public class BL_ArchivoLog
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla ArchivoLog.
		/// </summary>
		public void Insert(ArchivoLogModel x_oArchivoLogModel)
		{
			 new DA_ArchivoLog().Insert(x_oArchivoLogModel);
		}
        
        
		/// <summary>
		/// Selecciona todos los registro de la tabla ArchivoLog.
		/// </summary>
		public List<ArchivoLogModel> SelectAll(ArchivoLogModel x_oArchivoLogModel)
		{
			 return new DA_ArchivoLog().SelectAll(x_oArchivoLogModel);
		}


		#endregion
	}
}
