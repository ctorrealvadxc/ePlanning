using System;
using System.Collections.Generic;
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
		public void Insert(DominioModel x_oDominioModel)
		{
			 new DA_Dominio().Insert(x_oDominioModel);
		}

		/// <summary>
		/// Actualiza a registro de la tabla Dominio.
		/// </summary>
		public void Update(DominioModel x_oDominioModel)
		{
			 new DA_Dominio().Update(x_oDominioModel);
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
		public DominioModel Select(int IdDominio)
		{
			return new DA_Dominio().Select(IdDominio);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Dominio.
		/// </summary>
		public List<DominioModel> SelectAll(DominioModel dominioModel)
		{
			 return new DA_Dominio().SelectAll(dominioModel);
		}


		#endregion
	}
}
