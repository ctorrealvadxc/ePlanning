using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using log4net;
using Microsoft.ApplicationBlocks.Data;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.DataAccessLayer
{
	public class DA_Palanca : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Palanca.
		/// </summary>
		public void Insert(ModelPalanca x_oModelPalanca)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@Descripcion", x_oModelPalanca.Descripcion),
					new SqlParameter("@Abreviatura", x_oModelPalanca.Abreviatura),
					new SqlParameter("@UsuarioCreacion", x_oModelPalanca.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelPalanca.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelPalanca.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelPalanca.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_i_Palanca", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla Palanca.
		/// </summary>
		public void Update(ModelPalanca x_oModelPalanca)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdPalanca", x_oModelPalanca.IdPalanca),
					new SqlParameter("@Descripcion", x_oModelPalanca.Descripcion),
					new SqlParameter("@Abreviatura", x_oModelPalanca.Abreviatura),
					new SqlParameter("@UsuarioCreacion", x_oModelPalanca.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelPalanca.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelPalanca.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelPalanca.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_u_Palanca", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla Palanca por su primary key.
		/// </summary>
		public void Delete(short IdPalanca)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdPalanca", IdPalanca)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_Palanca", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla Palanca por su primary key.
		/// </summary>
		public ModelPalanca Select(short IdPalanca)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdPalanca", IdPalanca)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			DataTable dtResult = new DataTable();
			ModelPalanca objPalanca = new ModelPalanca();
			try{
				using (dtResult = ejecutarDataTable("usp_g_Palanca", parameters))
				{
					if (dtResult.Rows.Count > 0)
					{
						 foreach(DataRow item in dtResult.Rows){
							objPalanca = MapDataReader(item);
						 }
					}
					else
					{
						return objPalanca;
					}
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objPalanca;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Palanca.
		/// </summary>
		public List<ModelPalanca> SelectAll()
		{

			try{
				List<ModelPalanca> x_oModelPalancaList = new List<ModelPalanca>();
				DataTable dtResult = new DataTable();

				using (dtResult = ejecutarDataTable("usp_gl_PalancaAll"))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelPalanca x_oModelPalanca = MapDataReader(item);
					    x_oModelPalancaList.Add(x_oModelPalanca); 
					}

					return x_oModelPalancaList;
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Creates a new instance of the ModelPalanca class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private ModelPalanca MapDataReader(DataRow x_dr)
		{

			ModelPalanca x_oModelPalanca = new ModelPalanca();

			if (!x_dr.IsNull("IdPalanca")) x_oModelPalanca.IdPalanca = (short)x_dr["IdPalanca"];
			if (!x_dr.IsNull("Descripcion")) x_oModelPalanca.Descripcion = (string)x_dr["Descripcion"];
			if (!x_dr.IsNull("Abreviatura")) x_oModelPalanca.Abreviatura = (string)x_dr["Abreviatura"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oModelPalanca.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oModelPalanca.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oModelPalanca.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oModelPalanca.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oModelPalanca;
		}

		#endregion
	}
}
