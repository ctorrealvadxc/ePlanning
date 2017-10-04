using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
		public void Insert(EstadoArchivoModel x_oEstadoArchivoModel)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdEstado", x_oEstadoArchivoModel.IdEstado),
					new SqlParameter("@Descripcion", x_oEstadoArchivoModel.Descripcion),
					new SqlParameter("@UsuarioCreacion", x_oEstadoArchivoModel.UsuarioCreacion)
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
		public void Update(EstadoArchivoModel x_oEstadoArchivoModel)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdEstado", x_oEstadoArchivoModel.IdEstado),
					new SqlParameter("@Descripcion", x_oEstadoArchivoModel.Descripcion),
					new SqlParameter("@UsuarioModificacion", x_oEstadoArchivoModel.UsuarioModificacion)
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
		public EstadoArchivoModel Select(int IdEstado)
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
			EstadoArchivoModel objEstadoArchivo = new EstadoArchivoModel();
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
		public List<EstadoArchivoModel> SelectAll(EstadoArchivoModel estadoArchivoModel)
		{
            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@pii_PageIndex", estadoArchivoModel.PageIndex),
                    new SqlParameter("@pii_PageSize", estadoArchivoModel.PageSize)
                };
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }

            try
            {
				List<EstadoArchivoModel> x_oEstadoArchivoModelList = new List<EstadoArchivoModel>();
				DataTable dtResult = new DataTable();

				using (dtResult = ejecutarDataTable("usp_gl_EstadoArchivo",parameters))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    EstadoArchivoModel x_oEstadoArchivoModel = MapDataReader(item);
					    x_oEstadoArchivoModelList.Add(x_oEstadoArchivoModel); 
					}

					return x_oEstadoArchivoModelList;
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Creates a new instance of the EstadoArchivoModel class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private EstadoArchivoModel MapDataReader(DataRow x_dr)
		{

			EstadoArchivoModel x_oEstadoArchivoModel = new EstadoArchivoModel();

			if (!x_dr.IsNull("IdEstado")) x_oEstadoArchivoModel.IdEstado = (int)x_dr["IdEstado"];
			if (!x_dr.IsNull("Descripcion")) x_oEstadoArchivoModel.Descripcion = (string)x_dr["Descripcion"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oEstadoArchivoModel.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oEstadoArchivoModel.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oEstadoArchivoModel.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oEstadoArchivoModel.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oEstadoArchivoModel;
		}

		#endregion
	}
}
