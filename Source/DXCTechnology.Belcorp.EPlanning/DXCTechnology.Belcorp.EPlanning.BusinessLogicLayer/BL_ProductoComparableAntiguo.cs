using System;
using System.Collections.Generic;
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
		public void Insert(ProductoComparableAntiguoModel x_oProductoComparableAntiguoModel)
		{
			 new DA_ProductoComparableAntiguo().Insert(x_oProductoComparableAntiguoModel);
		}

		/// <summary>
		/// Actualiza a registro de la tabla ProductoComparableAntiguo.
		/// </summary>
		public void Update(ProductoComparableAntiguoModel x_oProductoComparableAntiguoModel)
		{
			 new DA_ProductoComparableAntiguo().Update(x_oProductoComparableAntiguoModel);
		}

		/// <summary>
		/// Elimina un registro de la tabla ProductoComparableAntiguo por su primary key.
		/// </summary>
		public void Delete(byte IdPais, string CUC)
		{
			 new DA_ProductoComparableAntiguo().Delete(IdPais, CUC);
		}
        
		/// <summary>
		/// Selecciona una registro de la tabla ProductoComparableAntiguo por su primary key.
		/// </summary>
		public ProductoComparableAntiguoModel Select(byte IdPais, string CUC)
		{
			return new DA_ProductoComparableAntiguo().Select(IdPais, CUC);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla ProductoComparableAntiguo.
		/// </summary>
		public List<ProductoComparableAntiguoModel> SelectAll(ProductoComparableAntiguoModel productoComparableAntiguoModel)
		{
			 return new DA_ProductoComparableAntiguo().SelectAll(productoComparableAntiguoModel);
		}




		#endregion
	}
}
