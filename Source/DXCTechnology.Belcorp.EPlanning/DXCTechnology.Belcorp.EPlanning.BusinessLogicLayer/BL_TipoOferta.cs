using System;
using System.Collections.Generic;
using DXCTechnology.Belcorp.ePlanning.DataAccessLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer
{
	public class BL_TipoOferta
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla TipoOferta.
		/// </summary>
		public void Insert(TipoOfertaModel x_oTipoOfertaModel)
		{
			 new DA_TipoOferta().Insert(x_oTipoOfertaModel);
		}

		/// <summary>
		/// Actualiza a registro de la tabla TipoOferta.
		/// </summary>
		public void Update(TipoOfertaModel x_oTipoOfertaModel)
		{
			 new DA_TipoOferta().Update(x_oTipoOfertaModel);
		}

		/// <summary>
		/// Elimina un registro de la tabla TipoOferta por su primary key.
		/// </summary>
		public void Delete(int IdTactica, short IdPalanca)
		{
			 new DA_TipoOferta().Delete(IdTactica, IdPalanca);
		}

		/// <summary>
		/// Deletes a record from the TipoOferta table by a foreign key.
		/// </summary>
		public void DeleteAllByIdPalanca(short IdPalanca)
		{
			 new DA_TipoOferta().DeleteAllByIdPalanca(IdPalanca);
		}

		/// <summary>
		/// Selecciona una registro de la tabla TipoOferta por su primary key.
		/// </summary>
		public TipoOfertaModel Select(int IdTactica, short IdPalanca)
		{
			return new DA_TipoOferta().Select(IdTactica, IdPalanca);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla TipoOferta.
		/// </summary>
		public List<TipoOfertaModel> SelectAll(TipoOfertaModel tipoOfertaModel)
		{
			 return new DA_TipoOferta().SelectAll(tipoOfertaModel);
		}
        

		#endregion
	}
}
