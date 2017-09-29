using System;
using System.Collections.Generic;
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
		public void Insert(EstadoArchivoModel x_oEstadoArchivoModel)
		{
			 new DA_EstadoArchivo().Insert(x_oEstadoArchivoModel);
		}

		/// <summary>
		/// Actualiza a registro de la tabla EstadoArchivo.
		/// </summary>
		public void Update(EstadoArchivoModel x_oEstadoArchivoModel)
		{
			 new DA_EstadoArchivo().Update(x_oEstadoArchivoModel);
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
		public EstadoArchivoModel Select(int IdEstado)
		{
			return new DA_EstadoArchivo().Select(IdEstado);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla EstadoArchivo.
		/// </summary>
		public List<EstadoArchivoModel> SelectAll(EstadoArchivoModel estadoArchivoModel)
		{
			 return new DA_EstadoArchivo().SelectAll(estadoArchivoModel);
		}


		#endregion
	}
}
