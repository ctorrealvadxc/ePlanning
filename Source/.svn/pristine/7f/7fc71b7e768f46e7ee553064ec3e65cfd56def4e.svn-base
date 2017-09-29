using System;
using System.Collections.Generic;
using log4net;
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
		public void Insert(ModelTipoOferta x_oModelTipoOferta)
		{
			 new DA_TipoOferta().Insert(x_oModelTipoOferta);
		}

		/// <summary>
		/// Actualiza a registro de la tabla TipoOferta.
		/// </summary>
		public void Update(ModelTipoOferta x_oModelTipoOferta)
		{
			 new DA_TipoOferta().Update(x_oModelTipoOferta);
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
		public ModelTipoOferta Select(int IdTactica, short IdPalanca)
		{
			return new DA_TipoOferta().Select(IdTactica, IdPalanca);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla TipoOferta.
		/// </summary>
		public List<ModelTipoOferta> SelectAll()
		{
			 return new DA_TipoOferta().SelectAll();
		}

		/// <summary>
		/// Selecciona los registros de la tabla TipoOferta por un foreign key.
		/// </summary>
		public List<ModelTipoOferta> SelectAllByIdPalanca(short IdPalanca)
		{
			return new DA_TipoOferta().SelectAllByIdPalanca(IdPalanca);
		}


		#endregion
	}
}
