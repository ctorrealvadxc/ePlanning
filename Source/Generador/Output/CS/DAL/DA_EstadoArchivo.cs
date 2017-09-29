using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using log4net;
using Microsoft.ApplicationBlocks.Data;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.DataAccessLayer
{
	public class DA_EstadoArchivo : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla EstadoArchivo.
		/// </summary>
		public void Insert(ModelEstadoArchivo x_oModelEstadoArchivo)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdEstado", x_oModelEstadoArchivo.IdEstado),
					new SqlParameter("@Descripcion", x_oModelEstadoArchivo.Descripcion),
					new SqlParameter("@UsuarioCreacion", x_oModelEstadoArchivo.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelEstadoArchivo.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelEstadoArchivo.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelEstadoArchivo.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_i_EstadoArchivo", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla EstadoArchivo.
		/// </summary>
		public void Update(ModelEstadoArchivo x_oModelEstadoArchivo)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdEstado", x_oModelEstadoArchivo.IdEstado),
					new SqlParameter("@Descripcion", x_oModelEstadoArchivo.Descripcion),
					new SqlParameter("@UsuarioCreacion", x_oModelEstadoArchivo.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelEstadoArchivo.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelEstadoArchivo.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelEstadoArchivo.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_u_EstadoArchivo", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla EstadoArchivo por su primary key.
		/// </summary>
		public void Delete(int IdEstado)
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
				ejecutarNonQuery("usp_d_EstadoArchivo", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla EstadoArchivo por su primary key.
		/// </summary>
		public ModelEstadoArchivo Select(int IdEstado)
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

			DataTable dtResult = new DataTable();
			ModelEstadoArchivo objEstadoArchivo = new ModelEstadoArchivo();
			try{
				using (dtResult = ejecutarDataTable("usp_g_EstadoArchivo", parameters))
				{
					if (dtResult.Rows.Count > 0)
					{
						 foreach(DataRow item in dtResult.Rows){
							objEstadoArchivo = MapDataReader(item);
						 }
					}
					else
					{
						return objEstadoArchivo;
					}
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objEstadoArchivo;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla EstadoArchivo.
		/// </summary>
		public List<ModelEstadoArchivo> SelectAll()
		{

			try{
				List<ModelEstadoArchivo> x_oModelEstadoArchivoList = new List<ModelEstadoArchivo>();
				DataTable dtResult = new DataTable();

				using (dtResult = ejecutarDataTable("usp_gl_EstadoArchivoAll"))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelEstadoArchivo x_oModelEstadoArchivo = MapDataReader(item);
					    x_oModelEstadoArchivoList.Add(x_oModelEstadoArchivo); 
					}

					return x_oModelEstadoArchivoList;
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Creates a new instance of the ModelEstadoArchivo class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private ModelEstadoArchivo MapDataReader(DataRow x_dr)
		{

			ModelEstadoArchivo x_oModelEstadoArchivo = new ModelEstadoArchivo();

			if (!x_dr.IsNull("IdEstado")) x_oModelEstadoArchivo.IdEstado = (int)x_dr["IdEstado"];
			if (!x_dr.IsNull("Descripcion")) x_oModelEstadoArchivo.Descripcion = (string)x_dr["Descripcion"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oModelEstadoArchivo.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oModelEstadoArchivo.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oModelEstadoArchivo.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oModelEstadoArchivo.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oModelEstadoArchivo;
		}

		#endregion
	}
}
