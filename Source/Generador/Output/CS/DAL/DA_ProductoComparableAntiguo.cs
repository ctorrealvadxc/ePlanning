using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using log4net;
using Microsoft.ApplicationBlocks.Data;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.DataAccessLayer
{
	public class DA_ProductoComparableAntiguo : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla ProductoComparableAntiguo.
		/// </summary>
		public void Insert(ModelProductoComparableAntiguo x_oModelProductoComparableAntiguo)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdPais", x_oModelProductoComparableAntiguo.IdPais),
					new SqlParameter("@CUC", x_oModelProductoComparableAntiguo.CUC),
					new SqlParameter("@SAP", x_oModelProductoComparableAntiguo.SAP),
					new SqlParameter("@CUCAntiguo", x_oModelProductoComparableAntiguo.CUCAntiguo),
					new SqlParameter("@SAPAntiguo", x_oModelProductoComparableAntiguo.SAPAntiguo),
					new SqlParameter("@BPCSGenericoAntiguo", x_oModelProductoComparableAntiguo.BPCSGenericoAntiguo),
					new SqlParameter("@BPCSTonoAntiguo", x_oModelProductoComparableAntiguo.BPCSTonoAntiguo),
					new SqlParameter("@DescripcionGenericoAntiguo", x_oModelProductoComparableAntiguo.DescripcionGenericoAntiguo),
					new SqlParameter("@DescripcionTonoAntiguo", x_oModelProductoComparableAntiguo.DescripcionTonoAntiguo),
					new SqlParameter("@UsuarioCreacion", x_oModelProductoComparableAntiguo.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelProductoComparableAntiguo.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelProductoComparableAntiguo.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelProductoComparableAntiguo.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_i_ProductoComparableAntiguo", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla ProductoComparableAntiguo.
		/// </summary>
		public void Update(ModelProductoComparableAntiguo x_oModelProductoComparableAntiguo)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdPais", x_oModelProductoComparableAntiguo.IdPais),
					new SqlParameter("@CUC", x_oModelProductoComparableAntiguo.CUC),
					new SqlParameter("@SAP", x_oModelProductoComparableAntiguo.SAP),
					new SqlParameter("@CUCAntiguo", x_oModelProductoComparableAntiguo.CUCAntiguo),
					new SqlParameter("@SAPAntiguo", x_oModelProductoComparableAntiguo.SAPAntiguo),
					new SqlParameter("@BPCSGenericoAntiguo", x_oModelProductoComparableAntiguo.BPCSGenericoAntiguo),
					new SqlParameter("@BPCSTonoAntiguo", x_oModelProductoComparableAntiguo.BPCSTonoAntiguo),
					new SqlParameter("@DescripcionGenericoAntiguo", x_oModelProductoComparableAntiguo.DescripcionGenericoAntiguo),
					new SqlParameter("@DescripcionTonoAntiguo", x_oModelProductoComparableAntiguo.DescripcionTonoAntiguo),
					new SqlParameter("@UsuarioCreacion", x_oModelProductoComparableAntiguo.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelProductoComparableAntiguo.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelProductoComparableAntiguo.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelProductoComparableAntiguo.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_u_ProductoComparableAntiguo", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla ProductoComparableAntiguo por su primary key.
		/// </summary>
		public void Delete(byte IdPais, string CUC)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdPais", IdPais),
					new SqlParameter("@CUC", CUC)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_ProductoComparableAntiguo", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the ProductoComparableAntiguo table by a foreign key.
		/// </summary>
		public void ByIdPais(byte IdPais)
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
				ejecutarNonQuery("usp_d_ProductoComparableAntiguoByIdPais", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla ProductoComparableAntiguo por su primary key.
		/// </summary>
		public ModelProductoComparableAntiguo Select(byte IdPais, string CUC)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdPais", IdPais),
					new SqlParameter("@CUC", CUC)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			DataTable dtResult = new DataTable();
			ModelProductoComparableAntiguo objProductoComparableAntiguo = new ModelProductoComparableAntiguo();
			try{
				using (dtResult = ejecutarDataTable("usp_g_ProductoComparableAntiguo", parameters))
				{
					if (dtResult.Rows.Count > 0)
					{
						 foreach(DataRow item in dtResult.Rows){
							objProductoComparableAntiguo = MapDataReader(item);
						 }
					}
					else
					{
						return objProductoComparableAntiguo;
					}
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objProductoComparableAntiguo;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla ProductoComparableAntiguo.
		/// </summary>
		public List<ModelProductoComparableAntiguo> SelectAll()
		{

			try{
				List<ModelProductoComparableAntiguo> x_oModelProductoComparableAntiguoList = new List<ModelProductoComparableAntiguo>();
				DataTable dtResult = new DataTable();

				using (dtResult = ejecutarDataTable("usp_gl_ProductoComparableAntiguoAll"))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelProductoComparableAntiguo x_oModelProductoComparableAntiguo = MapDataReader(item);
					    x_oModelProductoComparableAntiguoList.Add(x_oModelProductoComparableAntiguo); 
					}

					return x_oModelProductoComparableAntiguoList;
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Selecciona los registros de la tabla ProductoComparableAntiguo por un foreign key.
		/// </summary>
		public List<ModelProductoComparableAntiguo> AllByIdPais(byte IdPais)
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

			List<ModelProductoComparableAntiguo> x_oModelProductoComparableAntiguoList = new List<ModelProductoComparableAntiguo>();
			DataTable dtResult = new DataTable();

			try{
				using (dtResult = ejecutarDataTable("usp_gl_ProductoComparableAntiguoAllByIdPais", parameters))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelProductoComparableAntiguo x_oModelProductoComparableAntiguo = MapDataReader(item);
					    x_oModelProductoComparableAntiguoList.Add(x_oModelProductoComparableAntiguo); 
					}

				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oModelProductoComparableAntiguoList;
		}

		/// <summary>
		/// Creates a new instance of the ModelProductoComparableAntiguo class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private ModelProductoComparableAntiguo MapDataReader(DataRow x_dr)
		{

			ModelProductoComparableAntiguo x_oModelProductoComparableAntiguo = new ModelProductoComparableAntiguo();

			if (!x_dr.IsNull("IdPais")) x_oModelProductoComparableAntiguo.IdPais = (byte)x_dr["IdPais"];
			if (!x_dr.IsNull("CUC")) x_oModelProductoComparableAntiguo.CUC = (string)x_dr["CUC"];
			if (!x_dr.IsNull("SAP")) x_oModelProductoComparableAntiguo.SAP = (string)x_dr["SAP"];
			if (!x_dr.IsNull("CUCAntiguo")) x_oModelProductoComparableAntiguo.CUCAntiguo = (string)x_dr["CUCAntiguo"];
			if (!x_dr.IsNull("SAPAntiguo")) x_oModelProductoComparableAntiguo.SAPAntiguo = (string)x_dr["SAPAntiguo"];
			if (!x_dr.IsNull("BPCSGenericoAntiguo")) x_oModelProductoComparableAntiguo.BPCSGenericoAntiguo = (string)x_dr["BPCSGenericoAntiguo"];
			if (!x_dr.IsNull("BPCSTonoAntiguo")) x_oModelProductoComparableAntiguo.BPCSTonoAntiguo = (string)x_dr["BPCSTonoAntiguo"];
			if (!x_dr.IsNull("DescripcionGenericoAntiguo")) x_oModelProductoComparableAntiguo.DescripcionGenericoAntiguo = (string)x_dr["DescripcionGenericoAntiguo"];
			if (!x_dr.IsNull("DescripcionTonoAntiguo")) x_oModelProductoComparableAntiguo.DescripcionTonoAntiguo = (string)x_dr["DescripcionTonoAntiguo"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oModelProductoComparableAntiguo.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oModelProductoComparableAntiguo.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oModelProductoComparableAntiguo.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oModelProductoComparableAntiguo.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oModelProductoComparableAntiguo;
		}

		#endregion
	}
}
