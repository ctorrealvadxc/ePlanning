using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using log4net;
using Microsoft.ApplicationBlocks.Data;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.DataAccessLayer
{
	public class DA_Consolidado : DAL_Execute
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Consolidado.
		/// </summary>
		public void Insert(ModelConsolidado x_oModelConsolidado)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdCampanaPlaneacion", x_oModelConsolidado.IdCampanaPlaneacion),
					new SqlParameter("@IdCampanaProceso", x_oModelConsolidado.IdCampanaProceso),
					new SqlParameter("@IdPalanca", x_oModelConsolidado.IdPalanca),
					new SqlParameter("@UnidadesLimite", x_oModelConsolidado.UnidadesLimite),
					new SqlParameter("@NumeroEspacios", x_oModelConsolidado.NumeroEspacios),
					new SqlParameter("@IdPais", x_oModelConsolidado.IdPais),
					new SqlParameter("@CuentaOfertas", x_oModelConsolidado.CuentaOfertas),
					new SqlParameter("@Binomio", x_oModelConsolidado.Binomio),
					new SqlParameter("@CUVPadre", x_oModelConsolidado.CUVPadre),
					new SqlParameter("@CUV", x_oModelConsolidado.CUV),
					new SqlParameter("@CUCAntiguo", x_oModelConsolidado.CUCAntiguo),
					new SqlParameter("@SAPAntiguo", x_oModelConsolidado.SAPAntiguo),
					new SqlParameter("@BPCSGenericoAntiguo", x_oModelConsolidado.BPCSGenericoAntiguo),
					new SqlParameter("@BPCSTonoAntiguo", x_oModelConsolidado.BPCSTonoAntiguo),
					new SqlParameter("@DescripcionGenericoAntiguo", x_oModelConsolidado.DescripcionGenericoAntiguo),
					new SqlParameter("@DescripcionTonoAntiguo", x_oModelConsolidado.DescripcionTonoAntiguo),
					new SqlParameter("@Lanzamiento", x_oModelConsolidado.Lanzamiento),
					new SqlParameter("@CUC", x_oModelConsolidado.CUC),
					new SqlParameter("@SAP", x_oModelConsolidado.SAP),
					new SqlParameter("@BPCSGenerico", x_oModelConsolidado.BPCSGenerico),
					new SqlParameter("@BPCSTono", x_oModelConsolidado.BPCSTono),
					new SqlParameter("@IndicadorGratis", x_oModelConsolidado.IndicadorGratis),
					new SqlParameter("@DescripcionSet", x_oModelConsolidado.DescripcionSet),
					new SqlParameter("@DescripcionProducto", x_oModelConsolidado.DescripcionProducto),
					new SqlParameter("@DescripcionCatalogo", x_oModelConsolidado.DescripcionCatalogo),
					new SqlParameter("@CompuestaVariable", x_oModelConsolidado.CompuestaVariable),
					new SqlParameter("@NumeroGrupo", x_oModelConsolidado.NumeroGrupo),
					new SqlParameter("@FactorCuadre", x_oModelConsolidado.FactorCuadre),
					new SqlParameter("@FlagTop", x_oModelConsolidado.FlagTop),
					new SqlParameter("@Tono", x_oModelConsolidado.Tono),
					new SqlParameter("@IdMarca", x_oModelConsolidado.IdMarca),
					new SqlParameter("@IdCategoria", x_oModelConsolidado.IdCategoria),
					new SqlParameter("@Tipo", x_oModelConsolidado.Tipo),
					new SqlParameter("@DescuentoSet", x_oModelConsolidado.DescuentoSet),
					new SqlParameter("@ReglaSet", x_oModelConsolidado.ReglaSet),
					new SqlParameter("@GAPMNvsImpreso", x_oModelConsolidado.GAPMNvsImpreso),
					new SqlParameter("@GAPUSDvsImpreso", x_oModelConsolidado.GAPUSDvsImpreso),
					new SqlParameter("@IndicadorCxC", x_oModelConsolidado.IndicadorCxC),
					new SqlParameter("@FactoRepeticion", x_oModelConsolidado.FactoRepeticion),
					new SqlParameter("@POUnitarioMN", x_oModelConsolidado.POUnitarioMN),
					new SqlParameter("@POSetMN", x_oModelConsolidado.POSetMN),
					new SqlParameter("@PNSetMN", x_oModelConsolidado.PNSetMN),
					new SqlParameter("@PNUnitarioMN", x_oModelConsolidado.PNUnitarioMN),
					new SqlParameter("@Unidades", x_oModelConsolidado.Unidades),
					new SqlParameter("@P1", x_oModelConsolidado.P1),
					new SqlParameter("@P2", x_oModelConsolidado.P2),
					new SqlParameter("@P3", x_oModelConsolidado.P3),
					new SqlParameter("@P4", x_oModelConsolidado.P4),
					new SqlParameter("@P5", x_oModelConsolidado.P5),
					new SqlParameter("@P6", x_oModelConsolidado.P6),
					new SqlParameter("@P7", x_oModelConsolidado.P7),
					new SqlParameter("@Comentario", x_oModelConsolidado.Comentario),
					new SqlParameter("@CODP", x_oModelConsolidado.CODP),
					new SqlParameter("@NumeroProductosOferta", x_oModelConsolidado.NumeroProductosOferta),
					new SqlParameter("@TipoPlan", x_oModelConsolidado.TipoPlan),
					new SqlParameter("@IndicadorSubcampana", x_oModelConsolidado.IndicadorSubcampana),
					new SqlParameter("@UsuarioCreacion", x_oModelConsolidado.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelConsolidado.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelConsolidado.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelConsolidado.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oModelConsolidado.IdConsolidado = (long)ejecutarScalar("usp_i_Consolidado", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla Consolidado.
		/// </summary>
		public void Update(ModelConsolidado x_oModelConsolidado)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdConsolidado", x_oModelConsolidado.IdConsolidado),
					new SqlParameter("@IdCampanaPlaneacion", x_oModelConsolidado.IdCampanaPlaneacion),
					new SqlParameter("@IdCampanaProceso", x_oModelConsolidado.IdCampanaProceso),
					new SqlParameter("@IdPalanca", x_oModelConsolidado.IdPalanca),
					new SqlParameter("@UnidadesLimite", x_oModelConsolidado.UnidadesLimite),
					new SqlParameter("@NumeroEspacios", x_oModelConsolidado.NumeroEspacios),
					new SqlParameter("@IdPais", x_oModelConsolidado.IdPais),
					new SqlParameter("@CuentaOfertas", x_oModelConsolidado.CuentaOfertas),
					new SqlParameter("@Binomio", x_oModelConsolidado.Binomio),
					new SqlParameter("@CUVPadre", x_oModelConsolidado.CUVPadre),
					new SqlParameter("@CUV", x_oModelConsolidado.CUV),
					new SqlParameter("@CUCAntiguo", x_oModelConsolidado.CUCAntiguo),
					new SqlParameter("@SAPAntiguo", x_oModelConsolidado.SAPAntiguo),
					new SqlParameter("@BPCSGenericoAntiguo", x_oModelConsolidado.BPCSGenericoAntiguo),
					new SqlParameter("@BPCSTonoAntiguo", x_oModelConsolidado.BPCSTonoAntiguo),
					new SqlParameter("@DescripcionGenericoAntiguo", x_oModelConsolidado.DescripcionGenericoAntiguo),
					new SqlParameter("@DescripcionTonoAntiguo", x_oModelConsolidado.DescripcionTonoAntiguo),
					new SqlParameter("@Lanzamiento", x_oModelConsolidado.Lanzamiento),
					new SqlParameter("@CUC", x_oModelConsolidado.CUC),
					new SqlParameter("@SAP", x_oModelConsolidado.SAP),
					new SqlParameter("@BPCSGenerico", x_oModelConsolidado.BPCSGenerico),
					new SqlParameter("@BPCSTono", x_oModelConsolidado.BPCSTono),
					new SqlParameter("@IndicadorGratis", x_oModelConsolidado.IndicadorGratis),
					new SqlParameter("@DescripcionSet", x_oModelConsolidado.DescripcionSet),
					new SqlParameter("@DescripcionProducto", x_oModelConsolidado.DescripcionProducto),
					new SqlParameter("@DescripcionCatalogo", x_oModelConsolidado.DescripcionCatalogo),
					new SqlParameter("@CompuestaVariable", x_oModelConsolidado.CompuestaVariable),
					new SqlParameter("@NumeroGrupo", x_oModelConsolidado.NumeroGrupo),
					new SqlParameter("@FactorCuadre", x_oModelConsolidado.FactorCuadre),
					new SqlParameter("@FlagTop", x_oModelConsolidado.FlagTop),
					new SqlParameter("@Tono", x_oModelConsolidado.Tono),
					new SqlParameter("@IdMarca", x_oModelConsolidado.IdMarca),
					new SqlParameter("@IdCategoria", x_oModelConsolidado.IdCategoria),
					new SqlParameter("@Tipo", x_oModelConsolidado.Tipo),
					new SqlParameter("@DescuentoSet", x_oModelConsolidado.DescuentoSet),
					new SqlParameter("@ReglaSet", x_oModelConsolidado.ReglaSet),
					new SqlParameter("@GAPMNvsImpreso", x_oModelConsolidado.GAPMNvsImpreso),
					new SqlParameter("@GAPUSDvsImpreso", x_oModelConsolidado.GAPUSDvsImpreso),
					new SqlParameter("@IndicadorCxC", x_oModelConsolidado.IndicadorCxC),
					new SqlParameter("@FactoRepeticion", x_oModelConsolidado.FactoRepeticion),
					new SqlParameter("@POUnitarioMN", x_oModelConsolidado.POUnitarioMN),
					new SqlParameter("@POSetMN", x_oModelConsolidado.POSetMN),
					new SqlParameter("@PNSetMN", x_oModelConsolidado.PNSetMN),
					new SqlParameter("@PNUnitarioMN", x_oModelConsolidado.PNUnitarioMN),
					new SqlParameter("@Unidades", x_oModelConsolidado.Unidades),
					new SqlParameter("@P1", x_oModelConsolidado.P1),
					new SqlParameter("@P2", x_oModelConsolidado.P2),
					new SqlParameter("@P3", x_oModelConsolidado.P3),
					new SqlParameter("@P4", x_oModelConsolidado.P4),
					new SqlParameter("@P5", x_oModelConsolidado.P5),
					new SqlParameter("@P6", x_oModelConsolidado.P6),
					new SqlParameter("@P7", x_oModelConsolidado.P7),
					new SqlParameter("@Comentario", x_oModelConsolidado.Comentario),
					new SqlParameter("@CODP", x_oModelConsolidado.CODP),
					new SqlParameter("@NumeroProductosOferta", x_oModelConsolidado.NumeroProductosOferta),
					new SqlParameter("@TipoPlan", x_oModelConsolidado.TipoPlan),
					new SqlParameter("@IndicadorSubcampana", x_oModelConsolidado.IndicadorSubcampana),
					new SqlParameter("@UsuarioCreacion", x_oModelConsolidado.UsuarioCreacion),
					new SqlParameter("@FechaCreacion", x_oModelConsolidado.FechaCreacion),
					new SqlParameter("@UsuarioModificacion", x_oModelConsolidado.UsuarioModificacion),
					new SqlParameter("@FechaModificacion", x_oModelConsolidado.FechaModificacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_u_Consolidado", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Elimina un registro de la tabla Consolidado por su primary key.
		/// </summary>
		public void Delete(long IdConsolidado)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdConsolidado", IdConsolidado)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_Consolidado", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the Consolidado table by a foreign key.
		/// </summary>
		public void ByIdCampanaPlaneacion(int IdCampanaPlaneacion)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdCampanaPlaneacion", IdCampanaPlaneacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_ConsolidadoByIdCampanaPlaneacion", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the Consolidado table by a foreign key.
		/// </summary>
		public void ByIdCampanaProceso(int IdCampanaProceso)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdCampanaProceso", IdCampanaProceso)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_ConsolidadoByIdCampanaProceso", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the Consolidado table by a foreign key.
		/// </summary>
		public void ByIdCategoria(int IdCategoria)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdCategoria", IdCategoria)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_ConsolidadoByIdCategoria", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the Consolidado table by a foreign key.
		/// </summary>
		public void ByIdMarca(int IdMarca)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdMarca", IdMarca)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				ejecutarNonQuery("usp_d_ConsolidadoByIdMarca", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the Consolidado table by a foreign key.
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
				ejecutarNonQuery("usp_d_ConsolidadoByIdPais", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Deletes a record from the Consolidado table by a foreign key.
		/// </summary>
		public void ByIdPalanca(short IdPalanca)
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
				ejecutarNonQuery("usp_d_ConsolidadoByIdPalanca", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Selecciona una registro de la tabla Consolidado por su primary key.
		/// </summary>
		public ModelConsolidado Select(long IdConsolidado)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdConsolidado", IdConsolidado)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			DataTable dtResult = new DataTable();
			ModelConsolidado objConsolidado = new ModelConsolidado();
			try{
				using (dtResult = ejecutarDataTable("usp_g_Consolidado", parameters))
				{
					if (dtResult.Rows.Count > 0)
					{
						 foreach(DataRow item in dtResult.Rows){
							objConsolidado = MapDataReader(item);
						 }
					}
					else
					{
						return objConsolidado;
					}
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de operación de acceso a datos.", ex);
			}
			return objConsolidado;
		}

		/// <summary>
		/// Selecciona todos los registro de la tabla Consolidado.
		/// </summary>
		public List<ModelConsolidado> SelectAll()
		{

			try{
				List<ModelConsolidado> x_oModelConsolidadoList = new List<ModelConsolidado>();
				DataTable dtResult = new DataTable();

				using (dtResult = ejecutarDataTable("usp_gl_ConsolidadoAll"))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelConsolidado x_oModelConsolidado = MapDataReader(item);
					    x_oModelConsolidadoList.Add(x_oModelConsolidado); 
					}

					return x_oModelConsolidadoList;
				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
		}

		/// <summary>
		/// Selecciona los registros de la tabla Consolidado por un foreign key.
		/// </summary>
		public List<ModelConsolidado> AllByIdCampanaPlaneacion(int IdCampanaPlaneacion)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@IdCampanaPlaneacion", IdCampanaPlaneacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ModelConsolidado> x_oModelConsolidadoList = new List<ModelConsolidado>();
			DataTable dtResult = new DataTable();

			try{
				using (dtResult = ejecutarDataTable("usp_gl_ConsolidadoAllByIdCampanaPlaneacion", parameters))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelConsolidado x_oModelConsolidado = MapDataReader(item);
					    x_oModelConsolidadoList.Add(x_oModelConsolidado); 
					}

				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oModelConsolidadoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla Consolidado por un foreign key.
		/// </summary>
		public List<ModelConsolidado> AllByIdCampanaProceso(int IdCampanaProceso)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@IdCampanaProceso", IdCampanaProceso)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ModelConsolidado> x_oModelConsolidadoList = new List<ModelConsolidado>();
			DataTable dtResult = new DataTable();

			try{
				using (dtResult = ejecutarDataTable("usp_gl_ConsolidadoAllByIdCampanaProceso", parameters))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelConsolidado x_oModelConsolidado = MapDataReader(item);
					    x_oModelConsolidadoList.Add(x_oModelConsolidado); 
					}

				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oModelConsolidadoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla Consolidado por un foreign key.
		/// </summary>
		public List<ModelConsolidado> AllByIdCategoria(int IdCategoria)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@IdCategoria", IdCategoria)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ModelConsolidado> x_oModelConsolidadoList = new List<ModelConsolidado>();
			DataTable dtResult = new DataTable();

			try{
				using (dtResult = ejecutarDataTable("usp_gl_ConsolidadoAllByIdCategoria", parameters))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelConsolidado x_oModelConsolidado = MapDataReader(item);
					    x_oModelConsolidadoList.Add(x_oModelConsolidado); 
					}

				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oModelConsolidadoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla Consolidado por un foreign key.
		/// </summary>
		public List<ModelConsolidado> AllByIdMarca(int IdMarca)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
				new SqlParameter("@IdMarca", IdMarca)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			List<ModelConsolidado> x_oModelConsolidadoList = new List<ModelConsolidado>();
			DataTable dtResult = new DataTable();

			try{
				using (dtResult = ejecutarDataTable("usp_gl_ConsolidadoAllByIdMarca", parameters))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelConsolidado x_oModelConsolidado = MapDataReader(item);
					    x_oModelConsolidadoList.Add(x_oModelConsolidado); 
					}

				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oModelConsolidadoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla Consolidado por un foreign key.
		/// </summary>
		public List<ModelConsolidado> AllByIdPais(byte IdPais)
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

			List<ModelConsolidado> x_oModelConsolidadoList = new List<ModelConsolidado>();
			DataTable dtResult = new DataTable();

			try{
				using (dtResult = ejecutarDataTable("usp_gl_ConsolidadoAllByIdPais", parameters))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelConsolidado x_oModelConsolidado = MapDataReader(item);
					    x_oModelConsolidadoList.Add(x_oModelConsolidado); 
					}

				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oModelConsolidadoList;
		}

		/// <summary>
		/// Selecciona los registros de la tabla Consolidado por un foreign key.
		/// </summary>
		public List<ModelConsolidado> AllByIdPalanca(short IdPalanca)
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

			List<ModelConsolidado> x_oModelConsolidadoList = new List<ModelConsolidado>();
			DataTable dtResult = new DataTable();

			try{
				using (dtResult = ejecutarDataTable("usp_gl_ConsolidadoAllByIdPalanca", parameters))
				{
					foreach (DataRow item in dtResult.Rows)
					{
					    ModelConsolidado x_oModelConsolidado = MapDataReader(item);
					    x_oModelConsolidadoList.Add(x_oModelConsolidado); 
					}

				}
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}
			return x_oModelConsolidadoList;
		}

		/// <summary>
		/// Creates a new instance of the ModelConsolidado class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private ModelConsolidado MapDataReader(DataRow x_dr)
		{

			ModelConsolidado x_oModelConsolidado = new ModelConsolidado();

			if (!x_dr.IsNull("IdConsolidado")) x_oModelConsolidado.IdConsolidado = (long)x_dr["IdConsolidado"];
			if (!x_dr.IsNull("IdCampanaPlaneacion")) x_oModelConsolidado.IdCampanaPlaneacion = (int)x_dr["IdCampanaPlaneacion"];
			if (!x_dr.IsNull("IdCampanaProceso")) x_oModelConsolidado.IdCampanaProceso = (int)x_dr["IdCampanaProceso"];
			if (!x_dr.IsNull("IdPalanca")) x_oModelConsolidado.IdPalanca = (short)x_dr["IdPalanca"];
			if (!x_dr.IsNull("UnidadesLimite")) x_oModelConsolidado.UnidadesLimite = (byte)x_dr["UnidadesLimite"];
			if (!x_dr.IsNull("NumeroEspacios")) x_oModelConsolidado.NumeroEspacios = (byte)x_dr["NumeroEspacios"];
			if (!x_dr.IsNull("IdPais")) x_oModelConsolidado.IdPais = (byte)x_dr["IdPais"];
			if (!x_dr.IsNull("CuentaOfertas")) x_oModelConsolidado.CuentaOfertas = (int)x_dr["CuentaOfertas"];
			if (!x_dr.IsNull("Binomio")) x_oModelConsolidado.Binomio = (bool)x_dr["Binomio"];
			if (!x_dr.IsNull("CUVPadre")) x_oModelConsolidado.CUVPadre = (string)x_dr["CUVPadre"];
			if (!x_dr.IsNull("CUV")) x_oModelConsolidado.CUV = (string)x_dr["CUV"];
			if (!x_dr.IsNull("CUCAntiguo")) x_oModelConsolidado.CUCAntiguo = (string)x_dr["CUCAntiguo"];
			if (!x_dr.IsNull("SAPAntiguo")) x_oModelConsolidado.SAPAntiguo = (string)x_dr["SAPAntiguo"];
			if (!x_dr.IsNull("BPCSGenericoAntiguo")) x_oModelConsolidado.BPCSGenericoAntiguo = (string)x_dr["BPCSGenericoAntiguo"];
			if (!x_dr.IsNull("BPCSTonoAntiguo")) x_oModelConsolidado.BPCSTonoAntiguo = (string)x_dr["BPCSTonoAntiguo"];
			if (!x_dr.IsNull("DescripcionGenericoAntiguo")) x_oModelConsolidado.DescripcionGenericoAntiguo = (string)x_dr["DescripcionGenericoAntiguo"];
			if (!x_dr.IsNull("DescripcionTonoAntiguo")) x_oModelConsolidado.DescripcionTonoAntiguo = (string)x_dr["DescripcionTonoAntiguo"];
			if (!x_dr.IsNull("Lanzamiento")) x_oModelConsolidado.Lanzamiento = (bool)x_dr["Lanzamiento"];
			if (!x_dr.IsNull("CUC")) x_oModelConsolidado.CUC = (string)x_dr["CUC"];
			if (!x_dr.IsNull("SAP")) x_oModelConsolidado.SAP = (string)x_dr["SAP"];
			if (!x_dr.IsNull("BPCSGenerico")) x_oModelConsolidado.BPCSGenerico = (string)x_dr["BPCSGenerico"];
			if (!x_dr.IsNull("BPCSTono")) x_oModelConsolidado.BPCSTono = (string)x_dr["BPCSTono"];
			if (!x_dr.IsNull("IndicadorGratis")) x_oModelConsolidado.IndicadorGratis = (bool)x_dr["IndicadorGratis"];
			if (!x_dr.IsNull("DescripcionSet")) x_oModelConsolidado.DescripcionSet = (string)x_dr["DescripcionSet"];
			if (!x_dr.IsNull("DescripcionProducto")) x_oModelConsolidado.DescripcionProducto = (string)x_dr["DescripcionProducto"];
			if (!x_dr.IsNull("DescripcionCatalogo")) x_oModelConsolidado.DescripcionCatalogo = (string)x_dr["DescripcionCatalogo"];
			if (!x_dr.IsNull("CompuestaVariable")) x_oModelConsolidado.CompuestaVariable = (bool)x_dr["CompuestaVariable"];
			if (!x_dr.IsNull("NumeroGrupo")) x_oModelConsolidado.NumeroGrupo = (long)x_dr["NumeroGrupo"];
			if (!x_dr.IsNull("FactorCuadre")) x_oModelConsolidado.FactorCuadre = (bool)x_dr["FactorCuadre"];
			if (!x_dr.IsNull("FlagTop")) x_oModelConsolidado.FlagTop = (bool)x_dr["FlagTop"];
			if (!x_dr.IsNull("Tono")) x_oModelConsolidado.Tono = (string)x_dr["Tono"];
			if (!x_dr.IsNull("IdMarca")) x_oModelConsolidado.IdMarca = (int)x_dr["IdMarca"];
			if (!x_dr.IsNull("IdCategoria")) x_oModelConsolidado.IdCategoria = (int)x_dr["IdCategoria"];
			if (!x_dr.IsNull("Tipo")) x_oModelConsolidado.Tipo = (string)x_dr["Tipo"];
			if (!x_dr.IsNull("DescuentoSet")) x_oModelConsolidado.DescuentoSet = (decimal)x_dr["DescuentoSet"];
			if (!x_dr.IsNull("ReglaSet")) x_oModelConsolidado.ReglaSet = (decimal)x_dr["ReglaSet"];
			if (!x_dr.IsNull("GAPMNvsImpreso")) x_oModelConsolidado.GAPMNvsImpreso = (long)x_dr["GAPMNvsImpreso"];
			if (!x_dr.IsNull("GAPUSDvsImpreso")) x_oModelConsolidado.GAPUSDvsImpreso = (long)x_dr["GAPUSDvsImpreso"];
			if (!x_dr.IsNull("IndicadorCxC")) x_oModelConsolidado.IndicadorCxC = (bool)x_dr["IndicadorCxC"];
			if (!x_dr.IsNull("FactoRepeticion")) x_oModelConsolidado.FactoRepeticion = (long)x_dr["FactoRepeticion"];
			if (!x_dr.IsNull("POUnitarioMN")) x_oModelConsolidado.POUnitarioMN = (decimal)x_dr["POUnitarioMN"];
			if (!x_dr.IsNull("POSetMN")) x_oModelConsolidado.POSetMN = (decimal)x_dr["POSetMN"];
			if (!x_dr.IsNull("PNSetMN")) x_oModelConsolidado.PNSetMN = (decimal)x_dr["PNSetMN"];
			if (!x_dr.IsNull("PNUnitarioMN")) x_oModelConsolidado.PNUnitarioMN = (decimal)x_dr["PNUnitarioMN"];
			if (!x_dr.IsNull("Unidades")) x_oModelConsolidado.Unidades = (long)x_dr["Unidades"];
			if (!x_dr.IsNull("P1")) x_oModelConsolidado.P1 = (bool)x_dr["P1"];
			if (!x_dr.IsNull("P2")) x_oModelConsolidado.P2 = (bool)x_dr["P2"];
			if (!x_dr.IsNull("P3")) x_oModelConsolidado.P3 = (bool)x_dr["P3"];
			if (!x_dr.IsNull("P4")) x_oModelConsolidado.P4 = (bool)x_dr["P4"];
			if (!x_dr.IsNull("P5")) x_oModelConsolidado.P5 = (bool)x_dr["P5"];
			if (!x_dr.IsNull("P6")) x_oModelConsolidado.P6 = (bool)x_dr["P6"];
			if (!x_dr.IsNull("P7")) x_oModelConsolidado.P7 = (bool)x_dr["P7"];
			if (!x_dr.IsNull("Comentario")) x_oModelConsolidado.Comentario = (string)x_dr["Comentario"];
			if (!x_dr.IsNull("CODP")) x_oModelConsolidado.CODP = (string)x_dr["CODP"];
			if (!x_dr.IsNull("NumeroProductosOferta")) x_oModelConsolidado.NumeroProductosOferta = (long)x_dr["NumeroProductosOferta"];
			if (!x_dr.IsNull("TipoPlan")) x_oModelConsolidado.TipoPlan = (string)x_dr["TipoPlan"];
			if (!x_dr.IsNull("IndicadorSubcampana")) x_oModelConsolidado.IndicadorSubcampana = (bool)x_dr["IndicadorSubcampana"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oModelConsolidado.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oModelConsolidado.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oModelConsolidado.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oModelConsolidado.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oModelConsolidado;
		}

		#endregion
	}
}
