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
		public void Insert(ModelDominio x_oModelDominio)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@DescripcionLarga", x_oModelDominio.DescripcionLarga),
					new SqlParameter("@DescripcionCorta", x_oModelDominio.DescripcionCorta),
					new SqlParameter("@IndicadorVigencia", x_oModelDominio.IndicadorVigencia),
					new SqlParameter("@Nemonico", x_oModelDominio.Nemonico),
					new SqlParameter("@CamposAdicionales", x_oModelDominio.CamposAdicionales),
					new SqlParameter("@DescripcionCampo1", x_oModelDominio.DescripcionCampo1),
					new SqlParameter("@DescripcionCampo2", x_oModelDominio.DescripcionCampo2),
					new SqlParameter("@DescripcionCampo3", x_oModelDominio.DescripcionCampo3),
					new SqlParameter("@DescripcionCampo4", x_oModelDominio.DescripcionCampo4),
					new SqlParameter("@DescripcionCampo5", x_oModelDominio.DescripcionCampo5),
					new SqlParameter("@UsuarioCreacion", x_oModelDominio.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelDominio.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelDominio.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelDominio.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oModelDominio.IdDominio = (int)ejecutarScalar("usp_i_Dominio", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla Dominio.
		/// </summary>
		public void Update(ModelDominio x_oModelDominio)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdDominio", x_oModelDominio.IdDominio),
					new SqlParameter("@DescripcionLarga", x_oModelDominio.DescripcionLarga),
					new SqlParameter("@DescripcionCorta", x_oModelDominio.DescripcionCorta),
					new SqlParameter("@IndicadorVigencia", x_oModelDominio.IndicadorVigencia),
					new SqlParameter("@Nemonico", x_oModelDominio.Nemonico),
					new SqlParameter("@CamposAdicionales", x_oModelDominio.CamposAdicionales),
					new SqlParameter("@DescripcionCampo1", x_oModelDominio.DescripcionCampo1),
					new SqlParameter("@DescripcionCampo2", x_oModelDominio.DescripcionCampo2),
					new SqlParameter("@DescripcionCampo3", x_oModelDominio.DescripcionCampo3),
					new SqlParameter("@DescripcionCampo4", x_oModelDominio.DescripcionCampo4),
					new SqlParameter("@DescripcionCampo5", x_oModelDominio.DescripcionCampo5),
					new SqlParameter("@UsuarioCreacion", x_oModelDominio.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelDominio.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelDominio.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelDominio.FechaModificacion)
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
		public ModelDominio Select(int IdDominio)
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
			ModelDominio objDominio = new ModelDominio();
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
		public List<ModelDominio> SelectAll()
		{

			try{
				List<ModelDominio> x_oModelDominioList = new List<ModelDominio>();
				DataTable dtResult = new DataTable();

				using (dtResult = ejecutarDataTable("usp_gl_DominioAll"))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelDominio x_oModelDominio = MapDataReader(item);
					    x_oModelDominioList.Add(x_oModelDominio); 
					}

					return x_oModelDominioList;
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Creates a new instance of the ModelDominio class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private ModelDominio MapDataReader(DataRow x_dr)
		{

			ModelDominio x_oModelDominio = new ModelDominio();

			if (!x_dr.IsNull("IdDominio")) x_oModelDominio.IdDominio = (int)x_dr["IdDominio"];
			if (!x_dr.IsNull("DescripcionLarga")) x_oModelDominio.DescripcionLarga = (string)x_dr["DescripcionLarga"];
			if (!x_dr.IsNull("DescripcionCorta")) x_oModelDominio.DescripcionCorta = (string)x_dr["DescripcionCorta"];
			if (!x_dr.IsNull("IndicadorVigencia")) x_oModelDominio.IndicadorVigencia = (bool)x_dr["IndicadorVigencia"];
			if (!x_dr.IsNull("Nemonico")) x_oModelDominio.Nemonico = (string)x_dr["Nemonico"];
			if (!x_dr.IsNull("CamposAdicionales")) x_oModelDominio.CamposAdicionales = (byte)x_dr["CamposAdicionales"];
			if (!x_dr.IsNull("DescripcionCampo1")) x_oModelDominio.DescripcionCampo1 = (string)x_dr["DescripcionCampo1"];
			if (!x_dr.IsNull("DescripcionCampo2")) x_oModelDominio.DescripcionCampo2 = (string)x_dr["DescripcionCampo2"];
			if (!x_dr.IsNull("DescripcionCampo3")) x_oModelDominio.DescripcionCampo3 = (string)x_dr["DescripcionCampo3"];
			if (!x_dr.IsNull("DescripcionCampo4")) x_oModelDominio.DescripcionCampo4 = (string)x_dr["DescripcionCampo4"];
			if (!x_dr.IsNull("DescripcionCampo5")) x_oModelDominio.DescripcionCampo5 = (string)x_dr["DescripcionCampo5"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oModelDominio.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oModelDominio.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oModelDominio.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oModelDominio.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oModelDominio;
		}

		#endregion
	}
}
