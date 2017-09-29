using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using log4net;
using Microsoft.ApplicationBlocks.Data;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.DataAccessLayer
{
	public class DA_Campana : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Campana.
		/// </summary>
		public void Insert(ModelCampana x_oModelCampana)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdCampana", x_oModelCampana.IdCampana),
					new SqlParameter("@UsuarioCreacion", x_oModelCampana.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelCampana.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelCampana.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelCampana.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_i_Campana", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla Campana.
		/// </summary>
		public void Update(ModelCampana x_oModelCampana)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdCampana", x_oModelCampana.IdCampana),
					new SqlParameter("@UsuarioCreacion", x_oModelCampana.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelCampana.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelCampana.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelCampana.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_u_Campana", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla Campana por su primary key.
		/// </summary>
		public void Delete(int IdCampana)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdCampana", IdCampana)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_Campana", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla Campana por su primary key.
		/// </summary>
		public ModelCampana Select(int IdCampana)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdCampana", IdCampana)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			DataTable dtResult = new DataTable();
			ModelCampana objCampana = new ModelCampana();
			try{
				using (dtResult = ejecutarDataTable("usp_g_Campana", parameters))
				{
					if (dtResult.Rows.Count > 0)
					{
						 foreach(DataRow item in dtResult.Rows){
							objCampana = MapDataReader(item);
						 }
					}
					else
					{
						return objCampana;
					}
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objCampana;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Campana.
		/// </summary>
		public List<ModelCampana> SelectAll()
		{

			try{
				List<ModelCampana> x_oModelCampanaList = new List<ModelCampana>();
				DataTable dtResult = new DataTable();

				using (dtResult = ejecutarDataTable("usp_gl_CampanaAll"))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelCampana x_oModelCampana = MapDataReader(item);
					    x_oModelCampanaList.Add(x_oModelCampana); 
					}

					return x_oModelCampanaList;
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Creates a new instance of the ModelCampana class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private ModelCampana MapDataReader(DataRow x_dr)
		{

			ModelCampana x_oModelCampana = new ModelCampana();

			if (!x_dr.IsNull("IdCampana")) x_oModelCampana.IdCampana = (int)x_dr["IdCampana"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oModelCampana.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oModelCampana.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oModelCampana.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oModelCampana.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oModelCampana;
		}

		#endregion
	}
}
