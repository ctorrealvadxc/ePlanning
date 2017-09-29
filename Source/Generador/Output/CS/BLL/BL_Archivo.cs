using System;
using System.Collections.Generic;
using log4net;
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
		public void Insert(ModelArchivo x_oModelArchivo)
		{
			 new DA_Archivo().Insert(x_oModelArchivo);
		}

		/// <summary>
		/// Actualiza a registro de la tabla Archivo.
		/// </summary>
		public void Update(ModelArchivo x_oModelArchivo)
		{
			 new DA_Archivo().Update(x_oModelArchivo);
		}

		/// <summary>
		/// Elimina un registro de la tabla Archivo por su primary key.
		/// </summary>
		public void Delete(long IdArchivo)
		{
			 new DA_Archivo().Delete(IdArchivo);
		}

		/// <summary>
		/// Deletes a record from the Archivo table by a foreign key.
		/// </summary>
		public void DeleteAllByIdCampanaPlaneacion(int IdCampanaPlaneacion)
		{
			 new DA_Archivo().DeleteAllByIdCampanaPlaneacion(IdCampanaPlaneacion);
		}

		/// <summary>
		/// Deletes a record from the Archivo table by a foreign key.
		/// </summary>
		public void DeleteAllByIdCampanaProceso(int IdCampanaProceso)
		{
			 new DA_Archivo().DeleteAllByIdCampanaProceso(IdCampanaProceso);
		}

		/// <summary>
		/// Deletes a record from the Archivo table by a foreign key.
		/// </summary>
		public void DeleteAllByIdEstado(int IdEstado)
		{
			 new DA_Archivo().DeleteAllByIdEstado(IdEstado);
		}

		/// <summary>
		/// Selecciona una registro de la tabla Archivo por su primary key.
		/// </summary>
		public ModelArchivo Select(long IdArchivo)
		{
			return new DA_Archivo().Select(IdArchivo);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Archivo.
		/// </summary>
		public List<ModelArchivo> SelectAll()
		{
			 return new DA_Archivo().SelectAll();
		}

		/// <summary>
		/// Selecciona los registros de la tabla Archivo por un foreign key.
		/// </summary>
		public List<ModelArchivo> SelectAllByIdCampanaPlaneacion(int IdCampanaPlaneacion)
		{
			return new DA_Archivo().SelectAllByIdCampanaPlaneacion(IdCampanaPlaneacion);
		}

		/// <summary>
		/// Selecciona los registros de la tabla Archivo por un foreign key.
		/// </summary>
		public List<ModelArchivo> SelectAllByIdCampanaProceso(int IdCampanaProceso)
		{
			return new DA_Archivo().SelectAllByIdCampanaProceso(IdCampanaProceso);
		}

		/// <summary>
		/// Selecciona los registros de la tabla Archivo por un foreign key.
		/// </summary>
		public List<ModelArchivo> SelectAllByIdEstado(int IdEstado)
		{
			return new DA_Archivo().SelectAllByIdEstado(IdEstado);
		}


		#endregion
	}
}
