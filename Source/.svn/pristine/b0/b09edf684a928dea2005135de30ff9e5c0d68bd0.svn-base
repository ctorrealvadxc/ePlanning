using System;
using System.Collections.Generic;
using log4net;
using DXCTechnology.Belcorp.ePlanning.DataAccessLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer
{
	public class BL_ProductoComparableAntiguo
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla ProductoComparableAntiguo.
		/// </summary>
		public void Insert(ModelProductoComparableAntiguo x_oModelProductoComparableAntiguo)
		{
			 new DA_ProductoComparableAntiguo().Insert(x_oModelProductoComparableAntiguo);
		}

		/// <summary>
		/// Actualiza a registro de la tabla ProductoComparableAntiguo.
		/// </summary>
		public void Update(ModelProductoComparableAntiguo x_oModelProductoComparableAntiguo)
		{
			 new DA_ProductoComparableAntiguo().Update(x_oModelProductoComparableAntiguo);
		}

		/// <summary>
		/// Elimina un registro de la tabla ProductoComparableAntiguo por su primary key.
		/// </summary>
		public void Delete(byte IdPais, string CUC)
		{
			 new DA_ProductoComparableAntiguo().Delete(IdPais, CUC);
		}

		/// <summary>
		/// Deletes a record from the ProductoComparableAntiguo table by a foreign key.
		/// </summary>
		public void DeleteAllByIdPais(byte IdPais)
		{
			 new DA_ProductoComparableAntiguo().DeleteAllByIdPais(IdPais);
		}

		/// <summary>
		/// Selecciona una registro de la tabla ProductoComparableAntiguo por su primary key.
		/// </summary>
		public ModelProductoComparableAntiguo Select(byte IdPais, string CUC)
		{
			return new DA_ProductoComparableAntiguo().Select(IdPais, CUC);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla ProductoComparableAntiguo.
		/// </summary>
		public List<ModelProductoComparableAntiguo> SelectAll()
		{
			 return new DA_ProductoComparableAntiguo().SelectAll();
		}

		/// <summary>
		/// Selecciona los registros de la tabla ProductoComparableAntiguo por un foreign key.
		/// </summary>
		public List<ModelProductoComparableAntiguo> SelectAllByIdPais(byte IdPais)
		{
			return new DA_ProductoComparableAntiguo().SelectAllByIdPais(IdPais);
		}


		#endregion
	}
}
