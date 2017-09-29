using System;
using System.Collections.Generic;
using DXCTechnology.Belcorp.ePlanning.DataAccessLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer
{
	public class BL_Parametro
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Parametro.
		/// </summary>
		public void Insert(ParametroModel x_oParametroModel)
		{
			 new DA_Parametro().Insert(x_oParametroModel);
		}

		/// <summary>
		/// Actualiza a registro de la tabla Parametro.
		/// </summary>
		public void Update(ParametroModel x_oParametroModel)
		{
			 new DA_Parametro().Update(x_oParametroModel);
		}

		/// <summary>
		/// Elimina un registro de la tabla Parametro por su primary key.
		/// </summary>
		public void Delete(int IdParametro)
		{
			 new DA_Parametro().Delete(IdParametro);
		}
        
		/// <summary>
		/// Selecciona una registro de la tabla Parametro por su primary key.
		/// </summary>
		public ParametroModel Select(int IdParametro)
		{
			return new DA_Parametro().Select(IdParametro);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Parametro.
		/// </summary>
		public List<ParametroModel> SelectAll(ParametroModel parametroModel)
		{
			 return new DA_Parametro().SelectAll(parametroModel);
		}

		#endregion
	}
}
