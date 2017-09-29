using System;
using System.Collections.Generic;
using log4net;
using DXCTechnology.Belcorp.ePlanning.DataAccessLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer
{
	public class BL_Consolidado
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Consolidado.
		/// </summary>
		public void Insert(ModelConsolidado x_oModelConsolidado)
		{
			 new DA_Consolidado().Insert(x_oModelConsolidado);
		}

		/// <summary>
		/// Actualiza a registro de la tabla Consolidado.
		/// </summary>
		public void Update(ModelConsolidado x_oModelConsolidado)
		{
			 new DA_Consolidado().Update(x_oModelConsolidado);
		}

		/// <summary>
		/// Elimina un registro de la tabla Consolidado por su primary key.
		/// </summary>
		public void Delete(long IdConsolidado)
		{
			 new DA_Consolidado().Delete(IdConsolidado);
		}

		/// <summary>
		/// Deletes a record from the Consolidado table by a foreign key.
		/// </summary>
		public void DeleteAllByIdCampanaPlaneacion(int IdCampanaPlaneacion)
		{
			 new DA_Consolidado().DeleteAllByIdCampanaPlaneacion(IdCampanaPlaneacion);
		}

		/// <summary>
		/// Deletes a record from the Consolidado table by a foreign key.
		/// </summary>
		public void DeleteAllByIdCampanaProceso(int IdCampanaProceso)
		{
			 new DA_Consolidado().DeleteAllByIdCampanaProceso(IdCampanaProceso);
		}

		/// <summary>
		/// Deletes a record from the Consolidado table by a foreign key.
		/// </summary>
		public void DeleteAllByIdCategoria(int IdCategoria)
		{
			 new DA_Consolidado().DeleteAllByIdCategoria(IdCategoria);
		}

		/// <summary>
		/// Deletes a record from the Consolidado table by a foreign key.
		/// </summary>
		public void DeleteAllByIdMarca(int IdMarca)
		{
			 new DA_Consolidado().DeleteAllByIdMarca(IdMarca);
		}

		/// <summary>
		/// Deletes a record from the Consolidado table by a foreign key.
		/// </summary>
		public void DeleteAllByIdPais(byte IdPais)
		{
			 new DA_Consolidado().DeleteAllByIdPais(IdPais);
		}

		/// <summary>
		/// Deletes a record from the Consolidado table by a foreign key.
		/// </summary>
		public void DeleteAllByIdPalanca(short IdPalanca)
		{
			 new DA_Consolidado().DeleteAllByIdPalanca(IdPalanca);
		}

		/// <summary>
		/// Selecciona una registro de la tabla Consolidado por su primary key.
		/// </summary>
		public ModelConsolidado Select(long IdConsolidado)
		{
			return new DA_Consolidado().Select(IdConsolidado);
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Consolidado.
		/// </summary>
		public List<ModelConsolidado> SelectAll()
		{
			 return new DA_Consolidado().SelectAll();
		}

		/// <summary>
		/// Selecciona los registros de la tabla Consolidado por un foreign key.
		/// </summary>
		public List<ModelConsolidado> SelectAllByIdCampanaPlaneacion(int IdCampanaPlaneacion)
		{
			return new DA_Consolidado().SelectAllByIdCampanaPlaneacion(IdCampanaPlaneacion);
		}

		/// <summary>
		/// Selecciona los registros de la tabla Consolidado por un foreign key.
		/// </summary>
		public List<ModelConsolidado> SelectAllByIdCampanaProceso(int IdCampanaProceso)
		{
			return new DA_Consolidado().SelectAllByIdCampanaProceso(IdCampanaProceso);
		}

		/// <summary>
		/// Selecciona los registros de la tabla Consolidado por un foreign key.
		/// </summary>
		public List<ModelConsolidado> SelectAllByIdCategoria(int IdCategoria)
		{
			return new DA_Consolidado().SelectAllByIdCategoria(IdCategoria);
		}

		/// <summary>
		/// Selecciona los registros de la tabla Consolidado por un foreign key.
		/// </summary>
		public List<ModelConsolidado> SelectAllByIdMarca(int IdMarca)
		{
			return new DA_Consolidado().SelectAllByIdMarca(IdMarca);
		}

		/// <summary>
		/// Selecciona los registros de la tabla Consolidado por un foreign key.
		/// </summary>
		public List<ModelConsolidado> SelectAllByIdPais(byte IdPais)
		{
			return new DA_Consolidado().SelectAllByIdPais(IdPais);
		}

		/// <summary>
		/// Selecciona los registros de la tabla Consolidado por un foreign key.
		/// </summary>
		public List<ModelConsolidado> SelectAllByIdPalanca(short IdPalanca)
		{
			return new DA_Consolidado().SelectAllByIdPalanca(IdPalanca);
		}


		#endregion
	}
}
