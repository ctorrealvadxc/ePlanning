using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using log4net;
using Microsoft.ApplicationBlocks.Data;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.DataAccessLayer
{
	public class DA_TipoOferta : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla TipoOferta.
		/// </summary>
		public void Insert(ModelTipoOferta x_oModelTipoOferta)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdTactica", x_oModelTipoOferta.IdTactica),
					new SqlParameter("@IdPalanca", x_oModelTipoOferta.IdPalanca),
					new SqlParameter("@Valor", x_oModelTipoOferta.Valor),
					new SqlParameter("@UsuarioCreacion", x_oModelTipoOferta.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelTipoOferta.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelTipoOferta.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelTipoOferta.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_i_TipoOferta", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla TipoOferta.
		/// </summary>
		public void Update(ModelTipoOferta x_oModelTipoOferta)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdTactica", x_oModelTipoOferta.IdTactica),
					new SqlParameter("@IdPalanca", x_oModelTipoOferta.IdPalanca),
					new SqlParameter("@Valor", x_oModelTipoOferta.Valor),
					new SqlParameter("@UsuarioCreacion", x_oModelTipoOferta.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelTipoOferta.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelTipoOferta.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelTipoOferta.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_u_TipoOferta", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla TipoOferta por su primary key.
		/// </summary>
		public void Delete(int IdTactica, short IdPalanca)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdTactica", IdTactica),
					new SqlParameter("@IdPalanca", IdPalanca)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_TipoOferta", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the TipoOferta table by a foreign key.
		/// </summary>
		public void ByIdPalanca(short IdPalanca)
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
				ejecutarNonQuery("usp_d_TipoOfertaByIdPalanca", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla TipoOferta por su primary key.
		/// </summary>
		public ModelTipoOferta Select(int IdTactica, short IdPalanca)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdTactica", IdTactica),
					new SqlParameter("@IdPalanca", IdPalanca)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			DataTable dtResult = new DataTable();
			ModelTipoOferta objTipoOferta = new ModelTipoOferta();
			try{
				using (dtResult = ejecutarDataTable("usp_g_TipoOferta", parameters))
				{
					if (dtResult.Rows.Count > 0)
					{
						 foreach(DataRow item in dtResult.Rows){
							objTipoOferta = MapDataReader(item);
						 }
					}
					else
					{
						return objTipoOferta;
					}
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objTipoOferta;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla TipoOferta.
		/// </summary>
		public List<ModelTipoOferta> SelectAll()
		{

			try{
				List<ModelTipoOferta> x_oModelTipoOfertaList = new List<ModelTipoOferta>();
				DataTable dtResult = new DataTable();

				using (dtResult = ejecutarDataTable("usp_gl_TipoOfertaAll"))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelTipoOferta x_oModelTipoOferta = MapDataReader(item);
					    x_oModelTipoOfertaList.Add(x_oModelTipoOferta); 
					}

					return x_oModelTipoOfertaList;
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Selecciona los registros de la tabla TipoOferta por un foreign key.
		/// </summary>
		public List<ModelTipoOferta> AllByIdPalanca(short IdPalanca)
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

			List<ModelTipoOferta> x_oModelTipoOfertaList = new List<ModelTipoOferta>();
			DataTable dtResult = new DataTable();

			try{
				using (dtResult = ejecutarDataTable("usp_gl_TipoOfertaAllByIdPalanca", parameters))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelTipoOferta x_oModelTipoOferta = MapDataReader(item);
					    x_oModelTipoOfertaList.Add(x_oModelTipoOferta); 
					}

				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oModelTipoOfertaList;
		}

		/// <summary>
		/// Creates a new instance of the ModelTipoOferta class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private ModelTipoOferta MapDataReader(DataRow x_dr)
		{

			ModelTipoOferta x_oModelTipoOferta = new ModelTipoOferta();

			if (!x_dr.IsNull("IdTactica")) x_oModelTipoOferta.IdTactica = (int)x_dr["IdTactica"];
			if (!x_dr.IsNull("IdPalanca")) x_oModelTipoOferta.IdPalanca = (short)x_dr["IdPalanca"];
			if (!x_dr.IsNull("Valor")) x_oModelTipoOferta.Valor = (short)x_dr["Valor"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oModelTipoOferta.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oModelTipoOferta.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oModelTipoOferta.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oModelTipoOferta.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oModelTipoOferta;
		}

		#endregion
	}
}
