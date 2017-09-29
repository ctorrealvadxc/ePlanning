using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using log4net;
using Microsoft.ApplicationBlocks.Data;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.DataAccessLayer
{
	public class DA_Pai : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Pais.
		/// </summary>
		public void Insert(ModelPai x_oModelPai)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@Descripcion", x_oModelPai.Descripcion),
					new SqlParameter("@Abreviatura", x_oModelPai.Abreviatura),
					new SqlParameter("@UsuarioCreacion", x_oModelPai.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelPai.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelPai.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelPai.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_i_Pais", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla Pais.
		/// </summary>
		public void Update(ModelPai x_oModelPai)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdPais", x_oModelPai.IdPais),
					new SqlParameter("@Descripcion", x_oModelPai.Descripcion),
					new SqlParameter("@Abreviatura", x_oModelPai.Abreviatura),
					new SqlParameter("@UsuarioCreacion", x_oModelPai.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelPai.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelPai.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelPai.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_u_Pais", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla Pais por su primary key.
		/// </summary>
		public void Delete(byte IdPais)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdPais", IdPais)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_Pais", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla Pais por su primary key.
		/// </summary>
		public ModelPai Select(byte IdPais)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdPais", IdPais)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			DataTable dtResult = new DataTable();
			ModelPai objPais = new ModelPai();
			try{
				using (dtResult = ejecutarDataTable("usp_g_Pais", parameters))
				{
					if (dtResult.Rows.Count > 0)
					{
						 foreach(DataRow item in dtResult.Rows){
							objPais = MapDataReader(item);
						 }
					}
					else
					{
						return objPais;
					}
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objPais;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Pais.
		/// </summary>
		public List<ModelPai> SelectAll()
		{

			try{
				List<ModelPai> x_oModelPaiList = new List<ModelPai>();
				DataTable dtResult = new DataTable();

				using (dtResult = ejecutarDataTable("usp_gl_PaisAll"))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelPai x_oModelPai = MapDataReader(item);
					    x_oModelPaiList.Add(x_oModelPai); 
					}

					return x_oModelPaiList;
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Creates a new instance of the ModelPai class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private ModelPai MapDataReader(DataRow x_dr)
		{

			ModelPai x_oModelPai = new ModelPai();

			if (!x_dr.IsNull("IdPais")) x_oModelPai.IdPais = (byte)x_dr["IdPais"];
			if (!x_dr.IsNull("Descripcion")) x_oModelPai.Descripcion = (string)x_dr["Descripcion"];
			if (!x_dr.IsNull("Abreviatura")) x_oModelPai.Abreviatura = (string)x_dr["Abreviatura"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oModelPai.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oModelPai.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oModelPai.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oModelPai.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oModelPai;
		}

		#endregion
	}
}
