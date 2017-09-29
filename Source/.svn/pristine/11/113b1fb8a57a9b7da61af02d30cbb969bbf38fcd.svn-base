using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using log4net;
using Microsoft.ApplicationBlocks.Data;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.DataAccessLayer
{
	public class DA_Categoria : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Categoria.
		/// </summary>
		public void Insert(ModelCategoria x_oModelCategoria)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@Descripcion", x_oModelCategoria.Descripcion),
					new SqlParameter("@Abreviatura", x_oModelCategoria.Abreviatura),
					new SqlParameter("@UsuarioCreacion", x_oModelCategoria.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelCategoria.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelCategoria.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelCategoria.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oModelCategoria.IdCategoria = (int)ejecutarScalar("usp_i_Categoria", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla Categoria.
		/// </summary>
		public void Update(ModelCategoria x_oModelCategoria)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdCategoria", x_oModelCategoria.IdCategoria),
					new SqlParameter("@Descripcion", x_oModelCategoria.Descripcion),
					new SqlParameter("@Abreviatura", x_oModelCategoria.Abreviatura),
					new SqlParameter("@UsuarioCreacion", x_oModelCategoria.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelCategoria.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelCategoria.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelCategoria.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_u_Categoria", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla Categoria por su primary key.
		/// </summary>
		public void Delete(int IdCategoria)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdCategoria", IdCategoria)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_Categoria", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla Categoria por su primary key.
		/// </summary>
		public ModelCategoria Select(int IdCategoria)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdCategoria", IdCategoria)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			DataTable dtResult = new DataTable();
			ModelCategoria objCategoria = new ModelCategoria();
			try{
				using (dtResult = ejecutarDataTable("usp_g_Categoria", parameters))
				{
					if (dtResult.Rows.Count > 0)
					{
						 foreach(DataRow item in dtResult.Rows){
							objCategoria = MapDataReader(item);
						 }
					}
					else
					{
						return objCategoria;
					}
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objCategoria;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Categoria.
		/// </summary>
		public List<ModelCategoria> SelectAll()
		{

			try{
				List<ModelCategoria> x_oModelCategoriaList = new List<ModelCategoria>();
				DataTable dtResult = new DataTable();

				using (dtResult = ejecutarDataTable("usp_gl_CategoriaAll"))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelCategoria x_oModelCategoria = MapDataReader(item);
					    x_oModelCategoriaList.Add(x_oModelCategoria); 
					}

					return x_oModelCategoriaList;
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Creates a new instance of the ModelCategoria class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private ModelCategoria MapDataReader(DataRow x_dr)
		{

			ModelCategoria x_oModelCategoria = new ModelCategoria();

			if (!x_dr.IsNull("IdCategoria")) x_oModelCategoria.IdCategoria = (int)x_dr["IdCategoria"];
			if (!x_dr.IsNull("Descripcion")) x_oModelCategoria.Descripcion = (string)x_dr["Descripcion"];
			if (!x_dr.IsNull("Abreviatura")) x_oModelCategoria.Abreviatura = (string)x_dr["Abreviatura"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oModelCategoria.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oModelCategoria.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oModelCategoria.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oModelCategoria.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oModelCategoria;
		}

		#endregion
	}
}
