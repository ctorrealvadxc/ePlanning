using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using log4net;
using Microsoft.ApplicationBlocks.Data;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.DataAccessLayer
{
	public class DA_Parametro : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Parametro.
		/// </summary>
		public void Insert(ParametroModel x_oParametroModel)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdDominio", x_oParametroModel.IdDominio),
					new SqlParameter("@DescripcionLarga", x_oParametroModel.DescripcionLarga),
					new SqlParameter("@DescripcionCorta", x_oParametroModel.DescripcionCorta),
					new SqlParameter("@IndicadorVigencia", x_oParametroModel.IndicadorVigencia),
					new SqlParameter("@Nemonico", x_oParametroModel.Nemonico),
					new SqlParameter("@OrdenPresentacion", x_oParametroModel.OrdenPresentacion),
					new SqlParameter("@ValorCampo1", x_oParametroModel.ValorCampo1),
					new SqlParameter("@ValorCampo2", x_oParametroModel.ValorCampo2),
					new SqlParameter("@ValorCampo3", x_oParametroModel.ValorCampo3),
					new SqlParameter("@ValorCampo4", x_oParametroModel.ValorCampo4),
					new SqlParameter("@ValorCampo5", x_oParametroModel.ValorCampo5),
					new SqlParameter("@UsuarioCreacion", x_oParametroModel.UsuarioCreacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oParametroModel.IdParametro = (int)ejecutarScalar("usp_i_Parametro", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla Parametro.
		/// </summary>
		public void Update(ParametroModel x_oParametroModel)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdParametro", x_oParametroModel.IdParametro),
					new SqlParameter("@IdDominio", x_oParametroModel.IdDominio),
					new SqlParameter("@DescripcionLarga", x_oParametroModel.DescripcionLarga),
					new SqlParameter("@DescripcionCorta", x_oParametroModel.DescripcionCorta),
					new SqlParameter("@IndicadorVigencia", x_oParametroModel.IndicadorVigencia),
					new SqlParameter("@Nemonico", x_oParametroModel.Nemonico),
					new SqlParameter("@OrdenPresentacion", x_oParametroModel.OrdenPresentacion),
					new SqlParameter("@ValorCampo1", x_oParametroModel.ValorCampo1),
					new SqlParameter("@ValorCampo2", x_oParametroModel.ValorCampo2),
					new SqlParameter("@ValorCampo3", x_oParametroModel.ValorCampo3),
					new SqlParameter("@ValorCampo4", x_oParametroModel.ValorCampo4),
					new SqlParameter("@ValorCampo5", x_oParametroModel.ValorCampo5),
					new SqlParameter("@UsuarioModificacion", x_oParametroModel.UsuarioModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_u_Parametro", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla Parametro por su primary key.
		/// </summary>
		public void Delete(int IdParametro)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdParametro", IdParametro)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_Parametro", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla Parametro por su primary key.
		/// </summary>
		public ParametroModel Select(int IdParametro)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdParametro", IdParametro)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			DataTable dtResult = new DataTable();
			ParametroModel objParametro = new ParametroModel();
			try{
				using (dtResult = ejecutarDataTable("usp_g_Parametro", parameters))
				{
					if (dtResult.Rows.Count > 0)
					{
						 foreach(DataRow item in dtResult.Rows){
							objParametro = MapDataReader(item);
						 }
					}
					else
					{
						return objParametro;
					}
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objParametro;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Parametro.
		/// </summary>
		public List<ParametroModel> SelectAll(ParametroModel parametroModel)
		{
            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@pii_PageIndex", parametroModel.PageIndex),
                    new SqlParameter("@pii_PageSize", parametroModel.PageSize)
                };
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }

            try
            {
				List<ParametroModel> x_oParametroModelList = new List<ParametroModel>();
				DataTable dtResult = new DataTable();

				using (dtResult = ejecutarDataTable("usp_gl_Parametro",parameters))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ParametroModel x_oParametroModel = MapDataReader(item);
					    x_oParametroModelList.Add(x_oParametroModel); 
					}

					return x_oParametroModelList;
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}


		/// <summary>
		/// Creates a new instance of the ParametroModel class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private ParametroModel MapDataReader(DataRow x_dr)
		{

			ParametroModel x_oParametroModel = new ParametroModel();

			if (!x_dr.IsNull("IdParametro")) x_oParametroModel.IdParametro = (int)x_dr["IdParametro"];
			if (!x_dr.IsNull("IdDominio")) x_oParametroModel.IdDominio = (int)x_dr["IdDominio"];
			if (!x_dr.IsNull("DescripcionLarga")) x_oParametroModel.DescripcionLarga = (string)x_dr["DescripcionLarga"];
			if (!x_dr.IsNull("DescripcionCorta")) x_oParametroModel.DescripcionCorta = (string)x_dr["DescripcionCorta"];
			if (!x_dr.IsNull("IndicadorVigencia")) x_oParametroModel.IndicadorVigencia = (bool)x_dr["IndicadorVigencia"];
			if (!x_dr.IsNull("Nemonico")) x_oParametroModel.Nemonico = (string)x_dr["Nemonico"];
			if (!x_dr.IsNull("OrdenPresentacion")) x_oParametroModel.OrdenPresentacion = (short)x_dr["OrdenPresentacion"];
			if (!x_dr.IsNull("ValorCampo1")) x_oParametroModel.ValorCampo1 = (string)x_dr["ValorCampo1"];
			if (!x_dr.IsNull("ValorCampo2")) x_oParametroModel.ValorCampo2 = (string)x_dr["ValorCampo2"];
			if (!x_dr.IsNull("ValorCampo3")) x_oParametroModel.ValorCampo3 = (string)x_dr["ValorCampo3"];
			if (!x_dr.IsNull("ValorCampo4")) x_oParametroModel.ValorCampo4 = (string)x_dr["ValorCampo4"];
			if (!x_dr.IsNull("ValorCampo5")) x_oParametroModel.ValorCampo5 = (string)x_dr["ValorCampo5"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oParametroModel.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oParametroModel.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oParametroModel.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oParametroModel.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oParametroModel;
		}

		#endregion
	}
}
