using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using log4net;
using Microsoft.ApplicationBlocks.Data;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.DataAccessLayer
{
	public class DA_ArchivoLog : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla ArchivoLog.
		/// </summary>
		public void Insert(ArchivoLogModel x_oArchivoLogModel)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdArchivo", x_oArchivoLogModel.IdArchivo),
					new SqlParameter("@Observacion", x_oArchivoLogModel.Observacion),
					new SqlParameter("@Linea", x_oArchivoLogModel.Linea),
					new SqlParameter("@UsuarioCreacion", x_oArchivoLogModel.UsuarioCreacion),
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_i_ArchivoLog", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla ArchivoLog.
		/// </summary>
		public List<ArchivoLogModel> SelectAll(ArchivoLogModel archivoLogModel)
		{
            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@IdArchivo", archivoLogModel.IdArchivo),
                    new SqlParameter("@pii_PageIndex", archivoLogModel.PageIndex),
                    new SqlParameter("@pii_PageSize", archivoLogModel.PageSize)
                };
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }

            try
            {
				List<ArchivoLogModel> x_oArchivoLogModelList = new List<ArchivoLogModel>();
				DataTable dtResult = new DataTable();

				using (dtResult = ejecutarDataTable("usp_gl_ArchivoLog",parameters))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ArchivoLogModel x_oArchivoLogModel = MapDataReader(item);
					    x_oArchivoLogModelList.Add(x_oArchivoLogModel); 
					}

					return x_oArchivoLogModelList;
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Creates a new instance of the ArchivoLogModel class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private ArchivoLogModel MapDataReader(DataRow x_dr)
		{

			ArchivoLogModel x_oArchivoLogModel = new ArchivoLogModel();

			if (!x_dr.IsNull("IdArchivoLog")) x_oArchivoLogModel.IdArchivoLog = (long)x_dr["IdArchivoLog"];
			if (!x_dr.IsNull("IdArchivo")) x_oArchivoLogModel.IdArchivo = (long)x_dr["IdArchivo"];
			if (!x_dr.IsNull("Observacion")) x_oArchivoLogModel.Observacion = (string)x_dr["Observacion"];
			if (!x_dr.IsNull("Linea")) x_oArchivoLogModel.Linea = (string)x_dr["Linea"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oArchivoLogModel.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oArchivoLogModel.FechaCreacion = (DateTime)x_dr["FechaCreacion"];

			return x_oArchivoLogModel;
		}

		#endregion
	}
}
