using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.DataAccessLayer
{
	public class DA_Campana : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Campana.
		/// </summary>
		public void Insert(CampanaModel x_oCampanaModel)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdCampana", x_oCampanaModel.IdCampana),
					new SqlParameter("@UsuarioCreacion", x_oCampanaModel.UsuarioCreacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_i_Campana", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla Campana.
		/// </summary>
		public void Update(CampanaModel x_oCampanaModel)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdCampana", x_oCampanaModel.IdCampana),
					new SqlParameter("@UsuarioModificacion", x_oCampanaModel.UsuarioModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_u_Campana", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla Campana por su primary key.
		/// </summary>
		public void Delete(int IdCampana)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdCampana", IdCampana)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_Campana", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla Campana por su primary key.
		/// </summary>
		public CampanaModel Select(int IdCampana)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdCampana", IdCampana)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			DataTable dtResult = new DataTable();
			CampanaModel objCampana = new CampanaModel();
			try{
				using (dtResult = ejecutarDataTable("usp_g_Campana", parameters))
				{
					if (dtResult.Rows.Count > 0)
					{
						 foreach(DataRow item in dtResult.Rows){
							objCampana = MapDataReader(item);
						 }
					}
					else
					{
						return objCampana;
					}
				} 
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objCampana;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Campana.
		/// </summary>
		public List<CampanaModel> SelectAll(CampanaModel campanaModel)
		{

            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@pii_PageIndex", campanaModel.PageIndex),
                    new SqlParameter("@pii_PageSize", campanaModel.PageSize)
                };
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }
            return GetList<CampanaModel>("usp_gl_Campana", parameters);
		}

        /// <summary>
		/// Selecciona todos los registro de la tabla Campana.
		/// </summary>
		public List<CampanaModel> SelectProceso(CampanaModel campanaModel)
        {

            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@pii_IdCampanaPlaneacion", campanaModel.IdCampana),
                    new SqlParameter("@pii_PageIndex", campanaModel.PageIndex),
                    new SqlParameter("@pii_PageSize", campanaModel.PageSize)
                };
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }
            return GetList<CampanaModel>("usp_gl_CampanaProceso", parameters);
        }

        /// <summary>
        /// Creates a new instance of the CampanaModel class and populates it with data from the specified SqlDataReader.
        /// </summary>
        private CampanaModel MapDataReader(DataRow x_dr)
		{

			CampanaModel x_oCampanaModel = new CampanaModel();

			if (!x_dr.IsNull("IdCampana")) x_oCampanaModel.IdCampana = (int)x_dr["IdCampana"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oCampanaModel.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oCampanaModel.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oCampanaModel.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oCampanaModel.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oCampanaModel;
		}

		#endregion
	}
}
