using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using log4net;
using Microsoft.ApplicationBlocks.Data;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.DataAccessLayer
{
	public class DA_Pais : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Pais.
		/// </summary>
		public void Insert(PaisModel x_oPaiModel)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@Descripcion", x_oPaiModel.Descripcion),
					new SqlParameter("@Abreviatura", x_oPaiModel.Abreviatura),
					new SqlParameter("@UsuarioCreacion", x_oPaiModel.UsuarioCreacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_i_Pais", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla Pais.
		/// </summary>
		public void Update(PaisModel x_oPaiModel)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdPais", x_oPaiModel.IdPais),
					new SqlParameter("@Descripcion", x_oPaiModel.Descripcion),
					new SqlParameter("@Abreviatura", x_oPaiModel.Abreviatura),
					new SqlParameter("@UsuarioModificacion", x_oPaiModel.UsuarioModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_u_Pais", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla Pais por su primary key.
		/// </summary>
		public void Delete(byte IdPais)
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
				ejecutarNonQuery("usp_d_Pais", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla Pais por su primary key.
		/// </summary>
		public PaisModel Select(byte IdPais)
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

			DataTable dtResult = new DataTable();
			PaisModel objPais = new PaisModel();
			try{
				using (dtResult = ejecutarDataTable("usp_g_Pais", parameters))
				{
					if (dtResult.Rows.Count > 0)
					{
						 foreach(DataRow item in dtResult.Rows){
							objPais = MapDataReader(item);
						 }
					}
					else
					{
						return objPais;
					}
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objPais;
		}


        /// <summary>
        /// Selecciona una registro de la tabla Pais por su primary key.
        /// </summary>
        public PaisModel SelectByAbreviatura(string Abreviatura)
        {
            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@Abreviatura", Abreviatura)
                };
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }

            DataTable dtResult = new DataTable();
            PaisModel objPais = new PaisModel();
            try
            {
                using (dtResult = ejecutarDataTable("usp_g_PaisByAbreviatura", parameters))
                {
                    if (dtResult.Rows.Count > 0)
                    {
                        foreach (DataRow item in dtResult.Rows)
                        {
                            objPais = MapDataReader(item);
                        }
                    }
                    else
                    {
                        return objPais;
                    }
                }
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de operación de acceso a datos.", ex);
            }
            return objPais;
        }

        /// <summary>
        /// Selecciona todos los registro de la tabla Pais.
        /// </summary>
        public List<PaisModel> SelectAll(PaisModel paisModel)
		{
            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@pii_PageIndex", paisModel.PageIndex),
                    new SqlParameter("@pii_PageSize", paisModel.PageSize)
                };
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }
            return GetList<PaisModel>("usp_gl_Pais", parameters);
		}

		/// <summary>
		/// Creates a new instance of the PaiModel class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private PaisModel MapDataReader(DataRow x_dr)
		{

			PaisModel x_oPaisModel = new PaisModel();

			if (!x_dr.IsNull("IdPais")) x_oPaisModel.IdPais = (byte)x_dr["IdPais"];
			if (!x_dr.IsNull("Descripcion")) x_oPaisModel.Descripcion = (string)x_dr["Descripcion"];
			if (!x_dr.IsNull("Abreviatura")) x_oPaisModel.Abreviatura = (string)x_dr["Abreviatura"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oPaisModel.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oPaisModel.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oPaisModel.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oPaisModel.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oPaisModel;
		}

		#endregion
	}
}
