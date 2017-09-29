using System;
using System.Collections.Generic;
using log4net;
using DXCTechnology.Belcorp.ePlanning.DataAccessLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer
{
	public class BL_ArchivoLog
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla ArchivoLog.
		/// </summary>
		public void Insert(ModelArchivoLog x_oModelArchivoLog)
		{
			 new DA_ArchivoLog().Insert(x_oModelArchivoLog);
		}

		/// <summary>
		/// Actualiza a registro de la tabla ArchivoLog.
		/// </summary>
		public void Update(ModelArchivoLog x_oModelArchivoLog)
		{
			 new DA_ArchivoLog().Update(x_oModelArchivoLog);
		}

		/// <summary>
		/// Elimina un registro de la tabla ArchivoLog por su primary key.
		/// </summary>
		public void Delete(long IdArchivoLog, long IdArchivo)
		{
			 new DA_ArchivoLog().Delete(IdArchivoLog, IdArchivo);
		}

		/// <summary>
		/// Deletes a record from the ArchivoLog table by a foreign key.
		/// </summary>
		public void DeleteAllByIdArchivo(long IdArchivo)
		{
			 new DA_ArchivoLog().DeleteAllByIdArchivo(IdArchivo);
		}

		/// <summary>
		/// Selecciona una registro de la tabla ArchivoLog por su primary key.
		/// </summary>
		public ModelArchivoLog Select(long IdArchivoLog, long IdArchivo)
		{
			return new DA_ArchivoLog().Select(IdArchivoLog, IdArchivo);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla ArchivoLog.
		/// </summary>
		public List<ModelArchivoLog> SelectAll()
		{
			 return new DA_ArchivoLog().SelectAll();
		}

		/// <summary>
		/// Selecciona los registros de la tabla ArchivoLog por un foreign key.
		/// </summary>
		public List<ModelArchivoLog> SelectAllByIdArchivo(long IdArchivo)
		{
			return new DA_ArchivoLog().SelectAllByIdArchivo(IdArchivo);
		}


		#endregion
	}
}
