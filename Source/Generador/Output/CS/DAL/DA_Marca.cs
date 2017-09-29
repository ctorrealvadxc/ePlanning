using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using log4net;
using Microsoft.ApplicationBlocks.Data;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.DataAccessLayer
{
	public class DA_Marca : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Marca.
		/// </summary>
		public void Insert(ModelMarca x_oModelMarca)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@Descripcion", x_oModelMarca.Descripcion),
					new SqlParameter("@Abreviatura", x_oModelMarca.Abreviatura),
					new SqlParameter("@UsuarioCreacion", x_oModelMarca.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelMarca.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelMarca.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelMarca.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oModelMarca.IdMarca = (int)ejecutarScalar("usp_i_Marca", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla Marca.
		/// </summary>
		public void Update(ModelMarca x_oModelMarca)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdMarca", x_oModelMarca.IdMarca),
					new SqlParameter("@Descripcion", x_oModelMarca.Descripcion),
					new SqlParameter("@Abreviatura", x_oModelMarca.Abreviatura),
					new SqlParameter("@UsuarioCreacion", x_oModelMarca.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelMarca.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelMarca.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelMarca.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_u_Marca", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla Marca por su primary key.
		/// </summary>
		public void Delete(int IdMarca)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdMarca", IdMarca)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_Marca", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla Marca por su primary key.
		/// </summary>
		public ModelMarca Select(int IdMarca)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdMarca", IdMarca)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			DataTable dtResult = new DataTable();
			ModelMarca objMarca = new ModelMarca();
			try{
				using (dtResult = ejecutarDataTable("usp_g_Marca", parameters))
				{
					if (dtResult.Rows.Count > 0)
					{
						 foreach(DataRow item in dtResult.Rows){
							objMarca = MapDataReader(item);
						 }
					}
					else
					{
						return objMarca;
					}
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objMarca;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Marca.
		/// </summary>
		public List<ModelMarca> SelectAll()
		{

			try{
				List<ModelMarca> x_oModelMarcaList = new List<ModelMarca>();
				DataTable dtResult = new DataTable();

				using (dtResult = ejecutarDataTable("usp_gl_MarcaAll"))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelMarca x_oModelMarca = MapDataReader(item);
					    x_oModelMarcaList.Add(x_oModelMarca); 
					}

					return x_oModelMarcaList;
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Creates a new instance of the ModelMarca class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private ModelMarca MapDataReader(DataRow x_dr)
		{

			ModelMarca x_oModelMarca = new ModelMarca();

			if (!x_dr.IsNull("IdMarca")) x_oModelMarca.IdMarca = (int)x_dr["IdMarca"];
			if (!x_dr.IsNull("Descripcion")) x_oModelMarca.Descripcion = (string)x_dr["Descripcion"];
			if (!x_dr.IsNull("Abreviatura")) x_oModelMarca.Abreviatura = (string)x_dr["Abreviatura"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oModelMarca.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oModelMarca.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oModelMarca.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oModelMarca.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oModelMarca;
		}

		#endregion
	}
}
