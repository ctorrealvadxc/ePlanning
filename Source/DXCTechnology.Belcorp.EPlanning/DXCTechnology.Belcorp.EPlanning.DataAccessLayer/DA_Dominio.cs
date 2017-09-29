using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using log4net;
using Microsoft.ApplicationBlocks.Data;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.DataAccessLayer
{
	public class DA_Dominio : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Dominio.
		/// </summary>
		public void Insert(DominioModel x_oDominioModel)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@DescripcionLarga", x_oDominioModel.DescripcionLarga),
					new SqlParameter("@DescripcionCorta", x_oDominioModel.DescripcionCorta),
					new SqlParameter("@IndicadorVigencia", x_oDominioModel.IndicadorVigencia),
					new SqlParameter("@Nemonico", x_oDominioModel.Nemonico),
					new SqlParameter("@CamposAdicionales", x_oDominioModel.CamposAdicionales),
					new SqlParameter("@DescripcionCampo1", x_oDominioModel.DescripcionCampo1),
					new SqlParameter("@DescripcionCampo2", x_oDominioModel.DescripcionCampo2),
					new SqlParameter("@DescripcionCampo3", x_oDominioModel.DescripcionCampo3),
					new SqlParameter("@DescripcionCampo4", x_oDominioModel.DescripcionCampo4),
					new SqlParameter("@DescripcionCampo5", x_oDominioModel.DescripcionCampo5),
					new SqlParameter("@UsuarioCreacion", x_oDominioModel.UsuarioCreacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oDominioModel.IdDominio = (int)ejecutarScalar("usp_i_Dominio", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla Dominio.
		/// </summary>
		public void Update(DominioModel x_oDominioModel)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdDominio", x_oDominioModel.IdDominio),
					new SqlParameter("@DescripcionLarga", x_oDominioModel.DescripcionLarga),
					new SqlParameter("@DescripcionCorta", x_oDominioModel.DescripcionCorta),
					new SqlParameter("@IndicadorVigencia", x_oDominioModel.IndicadorVigencia),
					new SqlParameter("@Nemonico", x_oDominioModel.Nemonico),
					new SqlParameter("@CamposAdicionales", x_oDominioModel.CamposAdicionales),
					new SqlParameter("@DescripcionCampo1", x_oDominioModel.DescripcionCampo1),
					new SqlParameter("@DescripcionCampo2", x_oDominioModel.DescripcionCampo2),
					new SqlParameter("@DescripcionCampo3", x_oDominioModel.DescripcionCampo3),
					new SqlParameter("@DescripcionCampo4", x_oDominioModel.DescripcionCampo4),
					new SqlParameter("@DescripcionCampo5", x_oDominioModel.DescripcionCampo5),
					new SqlParameter("@UsuarioModificacion", x_oDominioModel.UsuarioModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_u_Dominio", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla Dominio por su primary key.
		/// </summary>
		public void Delete(int IdDominio)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdDominio", IdDominio)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_Dominio", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla Dominio por su primary key.
		/// </summary>
		public DominioModel Select(int IdDominio)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdDominio", IdDominio)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			DataTable dtResult = new DataTable();
			DominioModel objDominio = new DominioModel();
			try{
				using (dtResult = ejecutarDataTable("usp_g_Dominio", parameters))
				{
					if (dtResult.Rows.Count > 0)
					{
						 foreach(DataRow item in dtResult.Rows){
							objDominio = MapDataReader(item);
						 }
					}
					else
					{
						return objDominio;
					}
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objDominio;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Dominio.
		/// </summary>
		public List<DominioModel> SelectAll(DominioModel dominioModel)
		{
            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@pii_PageIndex", dominioModel.PageIndex),
                    new SqlParameter("@pii_PageSize", dominioModel.PageSize)
                };
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }

            try
            {
				List<DominioModel> x_oDominioModelList = new List<DominioModel>();
				DataTable dtResult = new DataTable();

				using (dtResult = ejecutarDataTable("usp_gl_Dominio",parameters))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    DominioModel x_oDominioModel = MapDataReader(item);
					    x_oDominioModelList.Add(x_oDominioModel); 
					}

					return x_oDominioModelList;
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Creates a new instance of the DominioModel class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private DominioModel MapDataReader(DataRow x_dr)
		{

			DominioModel x_oDominioModel = new DominioModel();

			if (!x_dr.IsNull("IdDominio")) x_oDominioModel.IdDominio = (int)x_dr["IdDominio"];
			if (!x_dr.IsNull("DescripcionLarga")) x_oDominioModel.DescripcionLarga = (string)x_dr["DescripcionLarga"];
			if (!x_dr.IsNull("DescripcionCorta")) x_oDominioModel.DescripcionCorta = (string)x_dr["DescripcionCorta"];
			if (!x_dr.IsNull("IndicadorVigencia")) x_oDominioModel.IndicadorVigencia = (bool)x_dr["IndicadorVigencia"];
			if (!x_dr.IsNull("Nemonico")) x_oDominioModel.Nemonico = (string)x_dr["Nemonico"];
			if (!x_dr.IsNull("CamposAdicionales")) x_oDominioModel.CamposAdicionales = (byte)x_dr["CamposAdicionales"];
			if (!x_dr.IsNull("DescripcionCampo1")) x_oDominioModel.DescripcionCampo1 = (string)x_dr["DescripcionCampo1"];
			if (!x_dr.IsNull("DescripcionCampo2")) x_oDominioModel.DescripcionCampo2 = (string)x_dr["DescripcionCampo2"];
			if (!x_dr.IsNull("DescripcionCampo3")) x_oDominioModel.DescripcionCampo3 = (string)x_dr["DescripcionCampo3"];
			if (!x_dr.IsNull("DescripcionCampo4")) x_oDominioModel.DescripcionCampo4 = (string)x_dr["DescripcionCampo4"];
			if (!x_dr.IsNull("DescripcionCampo5")) x_oDominioModel.DescripcionCampo5 = (string)x_dr["DescripcionCampo5"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oDominioModel.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oDominioModel.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oDominioModel.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oDominioModel.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oDominioModel;
		}

		#endregion
	}
}
