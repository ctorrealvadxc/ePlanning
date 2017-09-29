using System;
using System.Collections.Generic;
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
		public void Insert(PalancaModel x_oPalancaModel)
		{
			 new DA_Palanca().Insert(x_oPalancaModel);
		}

		/// <summary>
		/// Actualiza a registro de la tabla Palanca.
		/// </summary>
		public void Update(PalancaModel x_oPalancaModel)
		{
			 new DA_Palanca().Update(x_oPalancaModel);
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
		public PalancaModel Select(short IdPalanca)
		{
			return new DA_Palanca().Select(IdPalanca);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Palanca.
		/// </summary>
		public List<PalancaModel> SelectAll(PalancaModel palancaModel)
		{
			 return new DA_Palanca().SelectAll(palancaModel);
		}


		#endregion
	}
}
