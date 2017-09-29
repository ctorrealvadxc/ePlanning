using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using log4net;
using Microsoft.ApplicationBlocks.Data;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;




namespace DXCTechnology.Belcorp.ePlanning.DataAccessLayer
{
	public class DA_Palanca : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Palanca.
		/// </summary>
		public void Insert(PalancaModel x_oPalancaModel)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@Descripcion", x_oPalancaModel.Descripcion),
					new SqlParameter("@Abreviatura", x_oPalancaModel.Abreviatura),
					new SqlParameter("@UsuarioCreacion", x_oPalancaModel.UsuarioCreacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_i_Palanca", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla Palanca.
		/// </summary>
		public void Update(PalancaModel x_oPalancaModel)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdPalanca", x_oPalancaModel.IdPalanca),
					new SqlParameter("@Descripcion", x_oPalancaModel.Descripcion),
					new SqlParameter("@Abreviatura", x_oPalancaModel.Abreviatura),
					new SqlParameter("@UsuarioModificacion", x_oPalancaModel.UsuarioModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_u_Palanca", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla Palanca por su primary key.
		/// </summary>
		public void Delete(short IdPalanca)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdPalanca", IdPalanca)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_Palanca", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla Palanca por su primary key.
		/// </summary>
		public PalancaModel Select(short IdPalanca)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdPalanca", IdPalanca)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			DataTable dtResult = new DataTable();
			PalancaModel objPalanca = new PalancaModel();
			try{
				using (dtResult = ejecutarDataTable("usp_g_Palanca", parameters))
				{
					if (dtResult.Rows.Count > 0)
					{
						 foreach(DataRow item in dtResult.Rows){
							objPalanca = MapDataReader(item);
						 }
					}
					else
					{
						return objPalanca;
					}
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objPalanca;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Palanca.
		/// </summary>
		public List<PalancaModel> SelectAll(PalancaModel palancaModel)
		{
            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@pii_PageIndex", palancaModel.PageIndex),
                    new SqlParameter("@pii_PageSize", palancaModel.PageSize)
                };
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }

            return GetList<PalancaModel>("usp_gl_Palanca", parameters);            
        }

		/// <summary>
		/// Creates a new instance of the PalancaModel class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private PalancaModel MapDataReader(DataRow x_dr)
		{

			PalancaModel x_oPalancaModel = new PalancaModel();

			if (!x_dr.IsNull("IdPalanca")) x_oPalancaModel.IdPalanca = (short)x_dr["IdPalanca"];
			if (!x_dr.IsNull("Descripcion")) x_oPalancaModel.Descripcion = (string)x_dr["Descripcion"];
			if (!x_dr.IsNull("Abreviatura")) x_oPalancaModel.Abreviatura = (string)x_dr["Abreviatura"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oPalancaModel.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oPalancaModel.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oPalancaModel.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oPalancaModel.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oPalancaModel;
		}

		#endregion
	}
}
