using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using log4net;
using Microsoft.ApplicationBlocks.Data;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.DataAccessLayer
{
	public class DA_Archivo : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Archivo.
		/// </summary>
		public void Insert(ModelArchivo x_oModelArchivo)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@NombreCargado", x_oModelArchivo.NombreCargado),
					new SqlParameter("@NombreHistorico", x_oModelArchivo.NombreHistorico),
					new SqlParameter("@IdPalanca", x_oModelArchivo.IdPalanca),
					new SqlParameter("@IdCampanaPlaneacion", x_oModelArchivo.IdCampanaPlaneacion),
					new SqlParameter("@IdCampanaProceso", x_oModelArchivo.IdCampanaProceso),
					new SqlParameter("@NumeroEspacios", x_oModelArchivo.NumeroEspacios),
					new SqlParameter("@UnidadesLimite", x_oModelArchivo.UnidadesLimite),
					new SqlParameter("@IdEstado", x_oModelArchivo.IdEstado),
					new SqlParameter("@FechaEstado", x_oModelArchivo.FechaEstado),
					new SqlParameter("@UsuarioCreacion", x_oModelArchivo.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelArchivo.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelArchivo.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelArchivo.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oModelArchivo.IdArchivo = (long)ejecutarScalar("usp_i_Archivo", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla Archivo.
		/// </summary>
		public void Update(ModelArchivo x_oModelArchivo)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdArchivo", x_oModelArchivo.IdArchivo),
					new SqlParameter("@NombreCargado", x_oModelArchivo.NombreCargado),
					new SqlParameter("@NombreHistorico", x_oModelArchivo.NombreHistorico),
					new SqlParameter("@IdPalanca", x_oModelArchivo.IdPalanca),
					new SqlParameter("@IdCampanaPlaneacion", x_oModelArchivo.IdCampanaPlaneacion),
					new SqlParameter("@IdCampanaProceso", x_oModelArchivo.IdCampanaProceso),
					new SqlParameter("@NumeroEspacios", x_oModelArchivo.NumeroEspacios),
					new SqlParameter("@UnidadesLimite", x_oModelArchivo.UnidadesLimite),
					new SqlParameter("@IdEstado", x_oModelArchivo.IdEstado),
					new SqlParameter("@FechaEstado", x_oModelArchivo.FechaEstado),
					new SqlParameter("@UsuarioCreacion", x_oModelArchivo.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelArchivo.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelArchivo.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelArchivo.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_u_Archivo", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla Archivo por su primary key.
		/// </summary>
		public void Delete(long IdArchivo)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdArchivo", IdArchivo)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_Archivo", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the Archivo table by a foreign key.
		/// </summary>
		public void ByIdCampanaPlaneacion(int IdCampanaPlaneacion)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdCampanaPlaneacion", IdCampanaPlaneacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_ArchivoByIdCampanaPlaneacion", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the Archivo table by a foreign key.
		/// </summary>
		public void ByIdCampanaProceso(int IdCampanaProceso)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdCampanaProceso", IdCampanaProceso)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_ArchivoByIdCampanaProceso", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the Archivo table by a foreign key.
		/// </summary>
		public void ByIdEstado(int IdEstado)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdEstado", IdEstado)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_ArchivoByIdEstado", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla Archivo por su primary key.
		/// </summary>
		public ModelArchivo Select(long IdArchivo)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdArchivo", IdArchivo)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			DataTable dtResult = new DataTable();
			ModelArchivo objArchivo = new ModelArchivo();
			try{
				using (dtResult = ejecutarDataTable("usp_g_Archivo", parameters))
				{
					if (dtResult.Rows.Count > 0)
					{
						 foreach(DataRow item in dtResult.Rows){
							objArchivo = MapDataReader(item);
						 }
					}
					else
					{
						return objArchivo;
					}
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objArchivo;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Archivo.
		/// </summary>
		public List<ModelArchivo> SelectAll()
		{

			try{
				List<ModelArchivo> x_oModelArchivoList = new List<ModelArchivo>();
				DataTable dtResult = new DataTable();

				using (dtResult = ejecutarDataTable("usp_gl_ArchivoAll"))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelArchivo x_oModelArchivo = MapDataReader(item);
					    x_oModelArchivoList.Add(x_oModelArchivo); 
					}

					return x_oModelArchivoList;
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Selecciona los registros de la tabla Archivo por un foreign key.
		/// </summary>
		public List<ModelArchivo> AllByIdCampanaPlaneacion(int IdCampanaPlaneacion)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@IdCampanaPlaneacion", IdCampanaPlaneacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ModelArchivo> x_oModelArchivoList = new List<ModelArchivo>();
			DataTable dtResult = new DataTable();

			try{
				using (dtResult = ejecutarDataTable("usp_gl_ArchivoAllByIdCampanaPlaneacion", parameters))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelArchivo x_oModelArchivo = MapDataReader(item);
					    x_oModelArchivoList.Add(x_oModelArchivo); 
					}

				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oModelArchivoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla Archivo por un foreign key.
		/// </summary>
		public List<ModelArchivo> AllByIdCampanaProceso(int IdCampanaProceso)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@IdCampanaProceso", IdCampanaProceso)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ModelArchivo> x_oModelArchivoList = new List<ModelArchivo>();
			DataTable dtResult = new DataTable();

			try{
				using (dtResult = ejecutarDataTable("usp_gl_ArchivoAllByIdCampanaProceso", parameters))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelArchivo x_oModelArchivo = MapDataReader(item);
					    x_oModelArchivoList.Add(x_oModelArchivo); 
					}

				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oModelArchivoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla Archivo por un foreign key.
		/// </summary>
		public List<ModelArchivo> AllByIdEstado(int IdEstado)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@IdEstado", IdEstado)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ModelArchivo> x_oModelArchivoList = new List<ModelArchivo>();
			DataTable dtResult = new DataTable();

			try{
				using (dtResult = ejecutarDataTable("usp_gl_ArchivoAllByIdEstado", parameters))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelArchivo x_oModelArchivo = MapDataReader(item);
					    x_oModelArchivoList.Add(x_oModelArchivo); 
					}

				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oModelArchivoList;
		}

		/// <summary>
		/// Creates a new instance of the ModelArchivo class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private ModelArchivo MapDataReader(DataRow x_dr)
		{

			ModelArchivo x_oModelArchivo = new ModelArchivo();

			if (!x_dr.IsNull("IdArchivo")) x_oModelArchivo.IdArchivo = (long)x_dr["IdArchivo"];
			if (!x_dr.IsNull("NombreCargado")) x_oModelArchivo.NombreCargado = (string)x_dr["NombreCargado"];
			if (!x_dr.IsNull("NombreHistorico")) x_oModelArchivo.NombreHistorico = (string)x_dr["NombreHistorico"];
			if (!x_dr.IsNull("IdPalanca")) x_oModelArchivo.IdPalanca = (short)x_dr["IdPalanca"];
			if (!x_dr.IsNull("IdCampanaPlaneacion")) x_oModelArchivo.IdCampanaPlaneacion = (int)x_dr["IdCampanaPlaneacion"];
			if (!x_dr.IsNull("IdCampanaProceso")) x_oModelArchivo.IdCampanaProceso = (int)x_dr["IdCampanaProceso"];
			if (!x_dr.IsNull("NumeroEspacios")) x_oModelArchivo.NumeroEspacios = (byte)x_dr["NumeroEspacios"];
			if (!x_dr.IsNull("UnidadesLimite")) x_oModelArchivo.UnidadesLimite = (byte)x_dr["UnidadesLimite"];
			if (!x_dr.IsNull("IdEstado")) x_oModelArchivo.IdEstado = (int)x_dr["IdEstado"];
			if (!x_dr.IsNull("FechaEstado")) x_oModelArchivo.FechaEstado = (DateTime)x_dr["FechaEstado"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oModelArchivo.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oModelArchivo.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oModelArchivo.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oModelArchivo.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oModelArchivo;
		}

		#endregion
	}
}
