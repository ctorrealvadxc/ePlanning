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
		public void Insert(ModelParametro x_oModelParametro)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdDominio", x_oModelParametro.IdDominio),
					new SqlParameter("@DescripcionLarga", x_oModelParametro.DescripcionLarga),
					new SqlParameter("@DescripcionCorta", x_oModelParametro.DescripcionCorta),
					new SqlParameter("@IndicadorVigencia", x_oModelParametro.IndicadorVigencia),
					new SqlParameter("@Nemonico", x_oModelParametro.Nemonico),
					new SqlParameter("@OrdenPresentacion", x_oModelParametro.OrdenPresentacion),
					new SqlParameter("@ValorCampo1", x_oModelParametro.ValorCampo1),
					new SqlParameter("@ValorCampo2", x_oModelParametro.ValorCampo2),
					new SqlParameter("@ValorCampo3", x_oModelParametro.ValorCampo3),
					new SqlParameter("@ValorCampo4", x_oModelParametro.ValorCampo4),
					new SqlParameter("@ValorCampo5", x_oModelParametro.ValorCampo5),
					new SqlParameter("@UsuarioCreacion", x_oModelParametro.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelParametro.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelParametro.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelParametro.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oModelParametro.IdParametro = (int)ejecutarScalar("usp_i_Parametro", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla Parametro.
		/// </summary>
		public void Update(ModelParametro x_oModelParametro)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdParametro", x_oModelParametro.IdParametro),
					new SqlParameter("@IdDominio", x_oModelParametro.IdDominio),
					new SqlParameter("@DescripcionLarga", x_oModelParametro.DescripcionLarga),
					new SqlParameter("@DescripcionCorta", x_oModelParametro.DescripcionCorta),
					new SqlParameter("@IndicadorVigencia", x_oModelParametro.IndicadorVigencia),
					new SqlParameter("@Nemonico", x_oModelParametro.Nemonico),
					new SqlParameter("@OrdenPresentacion", x_oModelParametro.OrdenPresentacion),
					new SqlParameter("@ValorCampo1", x_oModelParametro.ValorCampo1),
					new SqlParameter("@ValorCampo2", x_oModelParametro.ValorCampo2),
					new SqlParameter("@ValorCampo3", x_oModelParametro.ValorCampo3),
					new SqlParameter("@ValorCampo4", x_oModelParametro.ValorCampo4),
					new SqlParameter("@ValorCampo5", x_oModelParametro.ValorCampo5),
					new SqlParameter("@UsuarioCreacion", x_oModelParametro.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelParametro.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelParametro.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelParametro.FechaModificacion)
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
		/// Deletes a record from the Parametro table by a foreign key.
		/// </summary>
		public void ByIdDominio(int IdDominio)
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
				ejecutarNonQuery("usp_d_ParametroByIdDominio", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla Parametro por su primary key.
		/// </summary>
		public ModelParametro Select(int IdParametro)
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
			ModelParametro objParametro = new ModelParametro();
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
		public List<ModelParametro> SelectAll()
		{

			try{
				List<ModelParametro> x_oModelParametroList = new List<ModelParametro>();
				DataTable dtResult = new DataTable();

				using (dtResult = ejecutarDataTable("usp_gl_ParametroAll"))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelParametro x_oModelParametro = MapDataReader(item);
					    x_oModelParametroList.Add(x_oModelParametro); 
					}

					return x_oModelParametroList;
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Selecciona los registros de la tabla Parametro por un foreign key.
		/// </summary>
		public List<ModelParametro> AllByIdDominio(int IdDominio)
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

			List<ModelParametro> x_oModelParametroList = new List<ModelParametro>();
			DataTable dtResult = new DataTable();

			try{
				using (dtResult = ejecutarDataTable("usp_gl_ParametroAllByIdDominio", parameters))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelParametro x_oModelParametro = MapDataReader(item);
					    x_oModelParametroList.Add(x_oModelParametro); 
					}

				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oModelParametroList;
		}

		/// <summary>
		/// Creates a new instance of the ModelParametro class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private ModelParametro MapDataReader(DataRow x_dr)
		{

			ModelParametro x_oModelParametro = new ModelParametro();

			if (!x_dr.IsNull("IdParametro")) x_oModelParametro.IdParametro = (int)x_dr["IdParametro"];
			if (!x_dr.IsNull("IdDominio")) x_oModelParametro.IdDominio = (int)x_dr["IdDominio"];
			if (!x_dr.IsNull("DescripcionLarga")) x_oModelParametro.DescripcionLarga = (string)x_dr["DescripcionLarga"];
			if (!x_dr.IsNull("DescripcionCorta")) x_oModelParametro.DescripcionCorta = (string)x_dr["DescripcionCorta"];
			if (!x_dr.IsNull("IndicadorVigencia")) x_oModelParametro.IndicadorVigencia = (bool)x_dr["IndicadorVigencia"];
			if (!x_dr.IsNull("Nemonico")) x_oModelParametro.Nemonico = (string)x_dr["Nemonico"];
			if (!x_dr.IsNull("OrdenPresentacion")) x_oModelParametro.OrdenPresentacion = (short)x_dr["OrdenPresentacion"];
			if (!x_dr.IsNull("ValorCampo1")) x_oModelParametro.ValorCampo1 = (string)x_dr["ValorCampo1"];
			if (!x_dr.IsNull("ValorCampo2")) x_oModelParametro.ValorCampo2 = (string)x_dr["ValorCampo2"];
			if (!x_dr.IsNull("ValorCampo3")) x_oModelParametro.ValorCampo3 = (string)x_dr["ValorCampo3"];
			if (!x_dr.IsNull("ValorCampo4")) x_oModelParametro.ValorCampo4 = (string)x_dr["ValorCampo4"];
			if (!x_dr.IsNull("ValorCampo5")) x_oModelParametro.ValorCampo5 = (string)x_dr["ValorCampo5"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oModelParametro.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oModelParametro.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oModelParametro.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oModelParametro.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oModelParametro;
		}

		#endregion
	}
}
