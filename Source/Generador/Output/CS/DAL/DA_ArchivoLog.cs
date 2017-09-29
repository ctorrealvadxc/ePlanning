using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using log4net;
using Microsoft.ApplicationBlocks.Data;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.DataAccessLayer
{
	public class DA_ArchivoLog : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla ArchivoLog.
		/// </summary>
		public void Insert(ModelArchivoLog x_oModelArchivoLog)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdArchivoLog", x_oModelArchivoLog.IdArchivoLog),
					new SqlParameter("@IdArchivo", x_oModelArchivoLog.IdArchivo),
					new SqlParameter("@Observacion", x_oModelArchivoLog.Observacion),
					new SqlParameter("@Linea", x_oModelArchivoLog.Linea),
					new SqlParameter("@UsuarioCreacion", x_oModelArchivoLog.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelArchivoLog.FechaCreacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_i_ArchivoLog", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla ArchivoLog.
		/// </summary>
		public void Update(ModelArchivoLog x_oModelArchivoLog)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdArchivoLog", x_oModelArchivoLog.IdArchivoLog),
					new SqlParameter("@IdArchivo", x_oModelArchivoLog.IdArchivo),
					new SqlParameter("@Observacion", x_oModelArchivoLog.Observacion),
					new SqlParameter("@Linea", x_oModelArchivoLog.Linea),
					new SqlParameter("@UsuarioCreacion", x_oModelArchivoLog.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelArchivoLog.FechaCreacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_u_ArchivoLog", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla ArchivoLog por su primary key.
		/// </summary>
		public void Delete(long IdArchivoLog, long IdArchivo)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdArchivoLog", IdArchivoLog),
					new SqlParameter("@IdArchivo", IdArchivo)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_ArchivoLog", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the ArchivoLog table by a foreign key.
		/// </summary>
		public void ByIdArchivo(long IdArchivo)
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
				ejecutarNonQuery("usp_d_ArchivoLogByIdArchivo", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla ArchivoLog por su primary key.
		/// </summary>
		public ModelArchivoLog Select(long IdArchivoLog, long IdArchivo)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdArchivoLog", IdArchivoLog),
					new SqlParameter("@IdArchivo", IdArchivo)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			DataTable dtResult = new DataTable();
			ModelArchivoLog objArchivoLog = new ModelArchivoLog();
			try{
				using (dtResult = ejecutarDataTable("usp_g_ArchivoLog", parameters))
				{
					if (dtResult.Rows.Count > 0)
					{
						 foreach(DataRow item in dtResult.Rows){
							objArchivoLog = MapDataReader(item);
						 }
					}
					else
					{
						return objArchivoLog;
					}
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objArchivoLog;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla ArchivoLog.
		/// </summary>
		public List<ModelArchivoLog> SelectAll()
		{

			try{
				List<ModelArchivoLog> x_oModelArchivoLogList = new List<ModelArchivoLog>();
				DataTable dtResult = new DataTable();

				using (dtResult = ejecutarDataTable("usp_gl_ArchivoLogAll"))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelArchivoLog x_oModelArchivoLog = MapDataReader(item);
					    x_oModelArchivoLogList.Add(x_oModelArchivoLog); 
					}

					return x_oModelArchivoLogList;
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Selecciona los registros de la tabla ArchivoLog por un foreign key.
		/// </summary>
		public List<ModelArchivoLog> AllByIdArchivo(long IdArchivo)
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

			List<ModelArchivoLog> x_oModelArchivoLogList = new List<ModelArchivoLog>();
			DataTable dtResult = new DataTable();

			try{
				using (dtResult = ejecutarDataTable("usp_gl_ArchivoLogAllByIdArchivo", parameters))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelArchivoLog x_oModelArchivoLog = MapDataReader(item);
					    x_oModelArchivoLogList.Add(x_oModelArchivoLog); 
					}

				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oModelArchivoLogList;
		}

		/// <summary>
		/// Creates a new instance of the ModelArchivoLog class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private ModelArchivoLog MapDataReader(DataRow x_dr)
		{

			ModelArchivoLog x_oModelArchivoLog = new ModelArchivoLog();

			if (!x_dr.IsNull("IdArchivoLog")) x_oModelArchivoLog.IdArchivoLog = (long)x_dr["IdArchivoLog"];
			if (!x_dr.IsNull("IdArchivo")) x_oModelArchivoLog.IdArchivo = (long)x_dr["IdArchivo"];
			if (!x_dr.IsNull("Observacion")) x_oModelArchivoLog.Observacion = (string)x_dr["Observacion"];
			if (!x_dr.IsNull("Linea")) x_oModelArchivoLog.Linea = (string)x_dr["Linea"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oModelArchivoLog.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oModelArchivoLog.FechaCreacion = (DateTime)x_dr["FechaCreacion"];

			return x_oModelArchivoLog;
		}

		#endregion
	}
}
