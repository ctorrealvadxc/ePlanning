using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.DataAccessLayer
{
	public class DA_Archivo : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Archivo.
		/// </summary>
		public void Insert(ArchivoModel x_oArchivoModel)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
                    new SqlParameter("@NombreCargado", x_oArchivoModel.NombreCargado),
                    new SqlParameter("@NombreHistorico", x_oArchivoModel.NombreHistorico),
                    new SqlParameter("@IdPalanca", x_oArchivoModel.IdPalanca),
                    new SqlParameter("@IdCampanaPlaneacion", x_oArchivoModel.IdCampanaPlaneacion),
                    new SqlParameter("@IdCampanaProceso", x_oArchivoModel.IdCampanaProceso),
                    new SqlParameter("@NumeroEspacios", x_oArchivoModel.NumeroEspacios),
                    new SqlParameter("@UnidadesLimite", x_oArchivoModel.UnidadesLimite),
                    new SqlParameter("@IdEstado", x_oArchivoModel.IdEstado),
                    new SqlParameter("@UsuarioCreacion", x_oArchivoModel.UsuarioCreacion)
                };
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oArchivoModel.IdArchivo = (long)ejecutarScalar("usp_i_Archivo", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla Archivo.
		/// </summary>
		public void Update(ArchivoModel x_oArchivoModel)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdArchivo", x_oArchivoModel.IdArchivo),
					new SqlParameter("@NombreCargado", x_oArchivoModel.NombreCargado),
					new SqlParameter("@NombreHistorico", x_oArchivoModel.NombreHistorico),
					new SqlParameter("@IdEstado", x_oArchivoModel.IdEstado),
					new SqlParameter("@FechaEstado", x_oArchivoModel.FechaEstado),
					new SqlParameter("@UsuarioModificacion", x_oArchivoModel.UsuarioModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_u_Archivo", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

        /// <summary>
        /// Actualiza el estado de un registro de la tabla Archivo.
        /// </summary>
        public void UpdateIdEstado(ArchivoModel x_oArchivoModel)
        {

            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@IdArchivo", x_oArchivoModel.IdArchivo),
                    new SqlParameter("@IdEstado", x_oArchivoModel.IdEstado),
                    new SqlParameter("@UsuarioModificacion", x_oArchivoModel.UsuarioModificacion)
                };
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }

            try
            {
                ejecutarNonQuery("usp_u_Archivo_IdEstado", parameters);
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de operación de acceso a datos.", ex);
            }
        }

        /// <summary>
        /// Elimina un registro de la tabla Archivo por su primary key.
        /// </summary>
        public void Delete(long IdArchivo)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdArchivo", IdArchivo)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_Archivo", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}


		/// <summary>
		/// Selecciona una registro de la tabla Archivo por su primary key.
		/// </summary>
		public ArchivoModel Select(long IdArchivo)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdArchivo", IdArchivo)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			DataTable dtResult = new DataTable();
			ArchivoModel objArchivo = new ArchivoModel();
			try{
				using (dtResult = ejecutarDataTable("usp_g_Archivo", parameters))
				{
					if (dtResult.Rows.Count > 0)
					{
						 foreach(DataRow item in dtResult.Rows){
							objArchivo = MapDataReader(item);
						 }
					}
					else
					{
						return objArchivo;
					}
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objArchivo;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Archivo.
		/// </summary>
		public List<ArchivoModel> SelectAll(ArchivoModel archivoModel)
		{

            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@pii_PageIndex", archivoModel.PageIndex),
                    new SqlParameter("@pii_PageSize", archivoModel.PageSize)
                };
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }

            try
            {
				List<ArchivoModel> x_oArchivoModelList = new List<ArchivoModel>();
				DataTable dtResult = new DataTable();

				using (dtResult = ejecutarDataTable("usp_gl_Archivo",parameters))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ArchivoModel x_oArchivoModel = MapDataReader(item);
					    x_oArchivoModelList.Add(x_oArchivoModel); 
					}

					return x_oArchivoModelList;
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
            return GetList<ArchivoModel>("usp_gl_Archivo", parameters);
		}

		/// <summary>
		/// Creates a new instance of the ArchivoModel class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private ArchivoModel MapDataReader(DataRow x_dr)
		{

			ArchivoModel x_oArchivoModel = new ArchivoModel();

			if (!x_dr.IsNull("IdArchivo")) x_oArchivoModel.IdArchivo = (long)x_dr["IdArchivo"];
			if (!x_dr.IsNull("NombreCargado")) x_oArchivoModel.NombreCargado = (string)x_dr["NombreCargado"];
			if (!x_dr.IsNull("NombreHistorico")) x_oArchivoModel.NombreHistorico = (string)x_dr["NombreHistorico"];
			if (!x_dr.IsNull("IdEstado")) x_oArchivoModel.IdEstado = (int)x_dr["IdEstado"];
			if (!x_dr.IsNull("FechaEstado")) x_oArchivoModel.FechaEstado = (DateTime)x_dr["FechaEstado"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oArchivoModel.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oArchivoModel.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oArchivoModel.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oArchivoModel.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oArchivoModel;
		}

		#endregion
	}
}
