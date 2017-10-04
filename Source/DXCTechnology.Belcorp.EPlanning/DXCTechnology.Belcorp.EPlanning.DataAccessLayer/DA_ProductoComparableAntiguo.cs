using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
		public void Insert(ProductoComparableAntiguoModel x_oProductoComparableAntiguoModel)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdPais", x_oProductoComparableAntiguoModel.IdPais),
					new SqlParameter("@CUC", x_oProductoComparableAntiguoModel.CUC),
					new SqlParameter("@SAP", x_oProductoComparableAntiguoModel.SAP),
					new SqlParameter("@CUCAntiguo", x_oProductoComparableAntiguoModel.CUCAntiguo),
					new SqlParameter("@SAPAntiguo", x_oProductoComparableAntiguoModel.SAPAntiguo),
					new SqlParameter("@BPCSGenericoAntiguo", x_oProductoComparableAntiguoModel.BPCSGenericoAntiguo),
					new SqlParameter("@BPCSTonoAntiguo", x_oProductoComparableAntiguoModel.BPCSTonoAntiguo),
					new SqlParameter("@DescripcionGenericoAntiguo", x_oProductoComparableAntiguoModel.DescripcionGenericoAntiguo),
					new SqlParameter("@DescripcionTonoAntiguo", x_oProductoComparableAntiguoModel.DescripcionTonoAntiguo),
					new SqlParameter("@UsuarioCreacion", x_oProductoComparableAntiguoModel.UsuarioCreacion)
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
		public void Update(ProductoComparableAntiguoModel x_oProductoComparableAntiguoModel)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdPais", x_oProductoComparableAntiguoModel.IdPais),
					new SqlParameter("@CUC", x_oProductoComparableAntiguoModel.CUC),
					new SqlParameter("@SAP", x_oProductoComparableAntiguoModel.SAP),
					new SqlParameter("@CUCAntiguo", x_oProductoComparableAntiguoModel.CUCAntiguo),
					new SqlParameter("@SAPAntiguo", x_oProductoComparableAntiguoModel.SAPAntiguo),
					new SqlParameter("@BPCSGenericoAntiguo", x_oProductoComparableAntiguoModel.BPCSGenericoAntiguo),
					new SqlParameter("@BPCSTonoAntiguo", x_oProductoComparableAntiguoModel.BPCSTonoAntiguo),
					new SqlParameter("@DescripcionGenericoAntiguo", x_oProductoComparableAntiguoModel.DescripcionGenericoAntiguo),
					new SqlParameter("@DescripcionTonoAntiguo", x_oProductoComparableAntiguoModel.DescripcionTonoAntiguo),
					new SqlParameter("@UsuarioModificacion", x_oProductoComparableAntiguoModel.UsuarioModificacion)
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
		/// Selecciona una registro de la tabla ProductoComparableAntiguo por su primary key.
		/// </summary>
		public ProductoComparableAntiguoModel Select(byte IdPais, string CUC)
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
			ProductoComparableAntiguoModel objProductoComparableAntiguo = new ProductoComparableAntiguoModel();
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
		public List<ProductoComparableAntiguoModel> SelectAll(ProductoComparableAntiguoModel productoComparableAntiguoModel)
		{
            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@pii_PageIndex", productoComparableAntiguoModel.PageIndex),
                    new SqlParameter("@pii_PageSize", productoComparableAntiguoModel.PageSize)
                };
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }

            try
            {
				List<ProductoComparableAntiguoModel> x_oProductoComparableAntiguoModelList = new List<ProductoComparableAntiguoModel>();
				DataTable dtResult = new DataTable();

				using (dtResult = ejecutarDataTable("usp_gl_ProductoComparableAntiguo",parameters))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ProductoComparableAntiguoModel x_oProductoComparableAntiguoModel = MapDataReader(item);
					    x_oProductoComparableAntiguoModelList.Add(x_oProductoComparableAntiguoModel); 
					}

					return x_oProductoComparableAntiguoModelList;
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Creates a new instance of the ProductoComparableAntiguoModel class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private ProductoComparableAntiguoModel MapDataReader(DataRow x_dr)
		{

			ProductoComparableAntiguoModel x_oProductoComparableAntiguoModel = new ProductoComparableAntiguoModel();

			if (!x_dr.IsNull("IdPais")) x_oProductoComparableAntiguoModel.IdPais = (byte)x_dr["IdPais"];
			if (!x_dr.IsNull("CUC")) x_oProductoComparableAntiguoModel.CUC = (string)x_dr["CUC"];
			if (!x_dr.IsNull("SAP")) x_oProductoComparableAntiguoModel.SAP = (string)x_dr["SAP"];
			if (!x_dr.IsNull("CUCAntiguo")) x_oProductoComparableAntiguoModel.CUCAntiguo = (string)x_dr["CUCAntiguo"];
			if (!x_dr.IsNull("SAPAntiguo")) x_oProductoComparableAntiguoModel.SAPAntiguo = (string)x_dr["SAPAntiguo"];
			if (!x_dr.IsNull("BPCSGenericoAntiguo")) x_oProductoComparableAntiguoModel.BPCSGenericoAntiguo = (string)x_dr["BPCSGenericoAntiguo"];
			if (!x_dr.IsNull("BPCSTonoAntiguo")) x_oProductoComparableAntiguoModel.BPCSTonoAntiguo = (string)x_dr["BPCSTonoAntiguo"];
			if (!x_dr.IsNull("DescripcionGenericoAntiguo")) x_oProductoComparableAntiguoModel.DescripcionGenericoAntiguo = (string)x_dr["DescripcionGenericoAntiguo"];
			if (!x_dr.IsNull("DescripcionTonoAntiguo")) x_oProductoComparableAntiguoModel.DescripcionTonoAntiguo = (string)x_dr["DescripcionTonoAntiguo"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oProductoComparableAntiguoModel.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oProductoComparableAntiguoModel.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oProductoComparableAntiguoModel.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oProductoComparableAntiguoModel.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oProductoComparableAntiguoModel;
		}

		#endregion
	}
}
