using System;
using System.Collections.Generic;
using log4net;
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
		public void Insert(ModelParametro x_oModelParametro)
		{
			 new DA_Parametro().Insert(x_oModelParametro);
		}

		/// <summary>
		/// Actualiza a registro de la tabla Parametro.
		/// </summary>
		public void Update(ModelParametro x_oModelParametro)
		{
			 new DA_Parametro().Update(x_oModelParametro);
		}

		/// <summary>
		/// Elimina un registro de la tabla Parametro por su primary key.
		/// </summary>
		public void Delete(int IdParametro)
		{
			 new DA_Parametro().Delete(IdParametro);
		}

		/// <summary>
		/// Deletes a record from the Parametro table by a foreign key.
		/// </summary>
		public void DeleteAllByIdDominio(int IdDominio)
		{
			 new DA_Parametro().DeleteAllByIdDominio(IdDominio);
		}

		/// <summary>
		/// Selecciona una registro de la tabla Parametro por su primary key.
		/// </summary>
		public ModelParametro Select(int IdParametro)
		{
			return new DA_Parametro().Select(IdParametro);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Parametro.
		/// </summary>
		public List<ModelParametro> SelectAll()
		{
			 return new DA_Parametro().SelectAll();
		}

		/// <summary>
		/// Selecciona los registros de la tabla Parametro por un foreign key.
		/// </summary>
		public List<ModelParametro> SelectAllByIdDominio(int IdDominio)
		{
			return new DA_Parametro().SelectAllByIdDominio(IdDominio);
		}


		#endregion
	}
}
