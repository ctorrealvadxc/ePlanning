using System;
using System.Collections.Generic;
using DXCTechnology.Belcorp.ePlanning.DataAccessLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer
{
	public class BL_Archivo
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Archivo.
		/// </summary>
		public void Insert(ArchivoModel x_oArchivoModel)
		{
			 new DA_Archivo().Insert(x_oArchivoModel);
		}

		/// <summary>
		/// Actualiza a registro de la tabla Archivo.
		/// </summary>
		public void Update(ArchivoModel x_oArchivoModel)
		{
			 new DA_Archivo().Update(x_oArchivoModel);
		}

        /// <summary>
        /// Actualiza el estado de un registro de la tabla Archivo.
        /// </summary>
        public void UpdateIdEstado(ArchivoModel x_oArchivoModel)
        {
            new DA_Archivo().UpdateIdEstado(x_oArchivoModel);
        }

        /// <summary>
        /// Elimina un registro de la tabla Archivo por su primary key.
        /// </summary>
        public void Delete(long IdArchivo)
		{
			 new DA_Archivo().Delete(IdArchivo);
		}
        

		/// <summary>
		/// Selecciona una registro de la tabla Archivo por su primary key.
		/// </summary>
		public ArchivoModel Select(long IdArchivo)
		{
			return new DA_Archivo().Select(IdArchivo);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Archivo.
		/// </summary>
		public List<ArchivoModel> SelectAll(ArchivoModel archivoModel)
		{
			 return new DA_Archivo().SelectAll(archivoModel);
		}

		#endregion
	}
}
