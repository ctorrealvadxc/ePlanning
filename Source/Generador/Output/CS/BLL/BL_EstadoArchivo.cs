using System;
using System.Collections.Generic;
using log4net;
using DXCTechnology.Belcorp.ePlanning.DataAccessLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer
{
	public class BL_EstadoArchivo
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla EstadoArchivo.
		/// </summary>
		public void Insert(ModelEstadoArchivo x_oModelEstadoArchivo)
		{
			 new DA_EstadoArchivo().Insert(x_oModelEstadoArchivo);
		}

		/// <summary>
		/// Actualiza a registro de la tabla EstadoArchivo.
		/// </summary>
		public void Update(ModelEstadoArchivo x_oModelEstadoArchivo)
		{
			 new DA_EstadoArchivo().Update(x_oModelEstadoArchivo);
		}

		/// <summary>
		/// Elimina un registro de la tabla EstadoArchivo por su primary key.
		/// </summary>
		public void Delete(int IdEstado)
		{
			 new DA_EstadoArchivo().Delete(IdEstado);
		}

		/// <summary>
		/// Selecciona una registro de la tabla EstadoArchivo por su primary key.
		/// </summary>
		public ModelEstadoArchivo Select(int IdEstado)
		{
			return new DA_EstadoArchivo().Select(IdEstado);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla EstadoArchivo.
		/// </summary>
		public List<ModelEstadoArchivo> SelectAll()
		{
			 return new DA_EstadoArchivo().SelectAll();
		}


		#endregion
	}
}
