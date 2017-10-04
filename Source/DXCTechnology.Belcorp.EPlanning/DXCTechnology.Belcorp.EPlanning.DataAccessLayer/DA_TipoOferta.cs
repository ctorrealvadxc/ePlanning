using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
		public void Insert(TipoOfertaModel x_oTipoOfertaModel)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdTactica", x_oTipoOfertaModel.IdTactica),
					new SqlParameter("@IdPalanca", x_oTipoOfertaModel.IdPalanca),
					new SqlParameter("@Valor", x_oTipoOfertaModel.Valor),
					new SqlParameter("@UsuarioCreacion", x_oTipoOfertaModel.UsuarioCreacion)
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
		public void Update(TipoOfertaModel x_oTipoOfertaModel)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdTactica", x_oTipoOfertaModel.IdTactica),
					new SqlParameter("@IdPalanca", x_oTipoOfertaModel.IdPalanca),
					new SqlParameter("@Valor", x_oTipoOfertaModel.Valor),
					new SqlParameter("@UsuarioModificacion", x_oTipoOfertaModel.UsuarioModificacion)
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
		public void DeleteAllByIdPalanca(short IdPalanca)
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
		public TipoOfertaModel Select(int IdTactica, short IdPalanca)
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
			TipoOfertaModel objTipoOferta = new TipoOfertaModel();
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
		public List<TipoOfertaModel> SelectAll(TipoOfertaModel tipoOfertaModel)
		{
            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@pii_PageIndex", tipoOfertaModel.PageIndex),
                    new SqlParameter("@pii_PageSize", tipoOfertaModel.PageSize)
                };
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }

            try
            {
				List<TipoOfertaModel> x_oTipoOfertaModelList = new List<TipoOfertaModel>();
				DataTable dtResult = new DataTable();

				using (dtResult = ejecutarDataTable("usp_gl_TipoOferta",parameters))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    TipoOfertaModel x_oTipoOfertaModel = MapDataReader(item);
					    x_oTipoOfertaModelList.Add(x_oTipoOfertaModel); 
					}

					return x_oTipoOfertaModelList;
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Creates a new instance of the TipoOfertaModel class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private TipoOfertaModel MapDataReader(DataRow x_dr)
		{

			TipoOfertaModel x_oTipoOfertaModel = new TipoOfertaModel();

			if (!x_dr.IsNull("IdTactica")) x_oTipoOfertaModel.IdTactica = (int)x_dr["IdTactica"];
			if (!x_dr.IsNull("IdPalanca")) x_oTipoOfertaModel.IdPalanca = (short)x_dr["IdPalanca"];
			if (!x_dr.IsNull("Valor")) x_oTipoOfertaModel.Valor = (short)x_dr["Valor"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oTipoOfertaModel.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oTipoOfertaModel.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oTipoOfertaModel.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oTipoOfertaModel.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oTipoOfertaModel;
		}

		#endregion
	}
}
