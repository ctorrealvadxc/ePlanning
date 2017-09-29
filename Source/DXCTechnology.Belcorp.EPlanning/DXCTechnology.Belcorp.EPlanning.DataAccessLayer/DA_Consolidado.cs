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
		public void Insert(ConsolidadoModel x_oConsolidadoModel)
		{
			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdCampanaPlaneacion", x_oConsolidadoModel.IdCampanaPlaneacion),
					new SqlParameter("@IdCampanaProceso", x_oConsolidadoModel.IdCampanaProceso),
					new SqlParameter("@IdPalanca", x_oConsolidadoModel.IdPalanca),
					new SqlParameter("@UnidadesLimite", x_oConsolidadoModel.UnidadesLimite),
					new SqlParameter("@NumeroEspacios", x_oConsolidadoModel.NumeroEspacios),
					new SqlParameter("@IdPais", x_oConsolidadoModel.IdPais),
					new SqlParameter("@CuentaOfertas", x_oConsolidadoModel.CuentaOfertas),
					new SqlParameter("@Binomio", x_oConsolidadoModel.Binomio),
					new SqlParameter("@CUVPadre", x_oConsolidadoModel.CUVPadre),
					new SqlParameter("@CUV", x_oConsolidadoModel.CUV),
					new SqlParameter("@CUCAntiguo", x_oConsolidadoModel.CUCAntiguo),
					new SqlParameter("@SAPAntiguo", x_oConsolidadoModel.SAPAntiguo),
					new SqlParameter("@BPCSGenericoAntiguo", x_oConsolidadoModel.BPCSGenericoAntiguo),
					new SqlParameter("@BPCSTonoAntiguo", x_oConsolidadoModel.BPCSTonoAntiguo),
					new SqlParameter("@DescripcionGenericoAntiguo", x_oConsolidadoModel.DescripcionGenericoAntiguo),
					new SqlParameter("@DescripcionTonoAntiguo", x_oConsolidadoModel.DescripcionTonoAntiguo),
					new SqlParameter("@Lanzamiento", x_oConsolidadoModel.Lanzamiento),
					new SqlParameter("@CUC", x_oConsolidadoModel.CUC),
					new SqlParameter("@SAP", x_oConsolidadoModel.SAP),
					new SqlParameter("@BPCSGenerico", x_oConsolidadoModel.BPCSGenerico),
					new SqlParameter("@BPCSTono", x_oConsolidadoModel.BPCSTono),
					new SqlParameter("@IndicadorGratis", x_oConsolidadoModel.IndicadorGratis),
					new SqlParameter("@DescripcionSet", x_oConsolidadoModel.DescripcionSet),
					new SqlParameter("@DescripcionProducto", x_oConsolidadoModel.DescripcionProducto),
					new SqlParameter("@DescripcionCatalogo", x_oConsolidadoModel.DescripcionCatalogo),
					new SqlParameter("@CompuestaVariable", x_oConsolidadoModel.CompuestaVariable),
					new SqlParameter("@NumeroGrupo", x_oConsolidadoModel.NumeroGrupo),
					new SqlParameter("@FactorCuadre", x_oConsolidadoModel.FactorCuadre),
					new SqlParameter("@FlagTop", x_oConsolidadoModel.FlagTop),
					new SqlParameter("@Tono", x_oConsolidadoModel.Tono),
					new SqlParameter("@Marca", x_oConsolidadoModel.Marca),
					new SqlParameter("@Categoria", x_oConsolidadoModel.Categoria),
					new SqlParameter("@Tipo", x_oConsolidadoModel.Tipo),
					new SqlParameter("@DescuentoSet", x_oConsolidadoModel.DescuentoSet),
					new SqlParameter("@ReglaSet", x_oConsolidadoModel.ReglaSet),
					new SqlParameter("@GAPMNvsImpreso", x_oConsolidadoModel.GAPMNvsImpreso),
					new SqlParameter("@GAPUSDvsImpreso", x_oConsolidadoModel.GAPUSDvsImpreso),
					new SqlParameter("@IndicadorCxC", x_oConsolidadoModel.IndicadorCxC),
					new SqlParameter("@FactoRepeticion", x_oConsolidadoModel.FactoRepeticion),
					new SqlParameter("@POUnitarioMN", x_oConsolidadoModel.POUnitarioMN),
					new SqlParameter("@POSetMN", x_oConsolidadoModel.POSetMN),
					new SqlParameter("@PNSetMN", x_oConsolidadoModel.PNSetMN),
					new SqlParameter("@PNUnitarioMN", x_oConsolidadoModel.PNUnitarioMN),
					new SqlParameter("@Unidades", x_oConsolidadoModel.Unidades),
					new SqlParameter("@P1", x_oConsolidadoModel.P1),
					new SqlParameter("@P2", x_oConsolidadoModel.P2),
					new SqlParameter("@P3", x_oConsolidadoModel.P3),
					new SqlParameter("@P4", x_oConsolidadoModel.P4),
					new SqlParameter("@P5", x_oConsolidadoModel.P5),
					new SqlParameter("@P6", x_oConsolidadoModel.P6),
					new SqlParameter("@P7", x_oConsolidadoModel.P7),
					new SqlParameter("@Comentario", x_oConsolidadoModel.Comentario),
					new SqlParameter("@CODP", x_oConsolidadoModel.CODP),
					new SqlParameter("@NumeroProductosOferta", x_oConsolidadoModel.NumeroProductosOferta),
					new SqlParameter("@TipoPlan", x_oConsolidadoModel.TipoPlan),
					new SqlParameter("@IndicadorSubcampana", x_oConsolidadoModel.IndicadorSubcampana),
                    new SqlParameter("@CantidadSAPDiferentes", x_oConsolidadoModel.CantidadSAPDiferentes),
                    new SqlParameter("@NumeroRepeticionesSAP", x_oConsolidadoModel.NumeroRepeticionesSAP),
                    new SqlParameter("@TipoOferta", x_oConsolidadoModel.TipoOferta),
                    new SqlParameter("@UsuarioCreacion", x_oConsolidadoModel.UsuarioCreacion)
				};
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error de asignación de parámetros.", ex);
			}

			try{
				x_oConsolidadoModel.IdConsolidado = (long)ejecutarScalar("usp_i_Consolidado", parameters);
			}
			catch (Exception ex)
			{
				throw controlarExcepcion("Error en operación de acceso a datos.", ex);
			}
		}

		/// <summary>
		/// Actualiza a registro de la tabla Consolidado.
		/// </summary>
		public void Update(ConsolidadoModel x_oConsolidadoModel)
		{

			SqlParameter[] parameters = null;
			try{
				parameters = new SqlParameter[]
				{
					new SqlParameter("@IdConsolidado", x_oConsolidadoModel.IdConsolidado),
					new SqlParameter("@IdCampanaPlaneacion", x_oConsolidadoModel.IdCampanaPlaneacion),
					new SqlParameter("@IdCampanaProceso", x_oConsolidadoModel.IdCampanaProceso),
					new SqlParameter("@IdPalanca", x_oConsolidadoModel.IdPalanca),
					new SqlParameter("@UnidadesLimite", x_oConsolidadoModel.UnidadesLimite),
					new SqlParameter("@NumeroEspacios", x_oConsolidadoModel.NumeroEspacios),
					new SqlParameter("@IdPais", x_oConsolidadoModel.IdPais),
					new SqlParameter("@CuentaOfertas", x_oConsolidadoModel.CuentaOfertas),
					new SqlParameter("@Binomio", x_oConsolidadoModel.Binomio),
					new SqlParameter("@CUVPadre", x_oConsolidadoModel.CUVPadre),
					new SqlParameter("@CUV", x_oConsolidadoModel.CUV),
					new SqlParameter("@CUCAntiguo", x_oConsolidadoModel.CUCAntiguo),
					new SqlParameter("@SAPAntiguo", x_oConsolidadoModel.SAPAntiguo),
					new SqlParameter("@BPCSGenericoAntiguo", x_oConsolidadoModel.BPCSGenericoAntiguo),
					new SqlParameter("@BPCSTonoAntiguo", x_oConsolidadoModel.BPCSTonoAntiguo),
					new SqlParameter("@DescripcionGenericoAntiguo", x_oConsolidadoModel.DescripcionGenericoAntiguo),
					new SqlParameter("@DescripcionTonoAntiguo", x_oConsolidadoModel.DescripcionTonoAntiguo),
					new SqlParameter("@Lanzamiento", x_oConsolidadoModel.Lanzamiento),
					new SqlParameter("@CUC", x_oConsolidadoModel.CUC),
					new SqlParameter("@SAP", x_oConsolidadoModel.SAP),
					new SqlParameter("@BPCSGenerico", x_oConsolidadoModel.BPCSGenerico),
					new SqlParameter("@BPCSTono", x_oConsolidadoModel.BPCSTono),
					new SqlParameter("@IndicadorGratis", x_oConsolidadoModel.IndicadorGratis),
					new SqlParameter("@DescripcionSet", x_oConsolidadoModel.DescripcionSet),
					new SqlParameter("@DescripcionProducto", x_oConsolidadoModel.DescripcionProducto),
					new SqlParameter("@DescripcionCatalogo", x_oConsolidadoModel.DescripcionCatalogo),
					new SqlParameter("@CompuestaVariable", x_oConsolidadoModel.CompuestaVariable),
					new SqlParameter("@NumeroGrupo", x_oConsolidadoModel.NumeroGrupo),
					new SqlParameter("@FactorCuadre", x_oConsolidadoModel.FactorCuadre),
					new SqlParameter("@FlagTop", x_oConsolidadoModel.FlagTop),
					new SqlParameter("@Tono", x_oConsolidadoModel.Tono),
					new SqlParameter("@Marca", x_oConsolidadoModel.Marca),
					new SqlParameter("@Categoria", x_oConsolidadoModel.Categoria),
					new SqlParameter("@Tipo", x_oConsolidadoModel.Tipo),
					new SqlParameter("@DescuentoSet", x_oConsolidadoModel.DescuentoSet),
					new SqlParameter("@ReglaSet", x_oConsolidadoModel.ReglaSet),
					new SqlParameter("@GAPMNvsImpreso", x_oConsolidadoModel.GAPMNvsImpreso),
					new SqlParameter("@GAPUSDvsImpreso", x_oConsolidadoModel.GAPUSDvsImpreso),
					new SqlParameter("@IndicadorCxC", x_oConsolidadoModel.IndicadorCxC),
					new SqlParameter("@FactoRepeticion", x_oConsolidadoModel.FactoRepeticion),
					new SqlParameter("@POUnitarioMN", x_oConsolidadoModel.POUnitarioMN),
					new SqlParameter("@POSetMN", x_oConsolidadoModel.POSetMN),
					new SqlParameter("@PNSetMN", x_oConsolidadoModel.PNSetMN),
					new SqlParameter("@PNUnitarioMN", x_oConsolidadoModel.PNUnitarioMN),
					new SqlParameter("@Unidades", x_oConsolidadoModel.Unidades),
					new SqlParameter("@P1", x_oConsolidadoModel.P1),
					new SqlParameter("@P2", x_oConsolidadoModel.P2),
					new SqlParameter("@P3", x_oConsolidadoModel.P3),
					new SqlParameter("@P4", x_oConsolidadoModel.P4),
					new SqlParameter("@P5", x_oConsolidadoModel.P5),
					new SqlParameter("@P6", x_oConsolidadoModel.P6),
					new SqlParameter("@P7", x_oConsolidadoModel.P7),
					new SqlParameter("@Comentario", x_oConsolidadoModel.Comentario),
					new SqlParameter("@CODP", x_oConsolidadoModel.CODP),
					new SqlParameter("@NumeroProductosOferta", x_oConsolidadoModel.NumeroProductosOferta),
					new SqlParameter("@TipoPlan", x_oConsolidadoModel.TipoPlan),
					new SqlParameter("@IndicadorSubcampana", x_oConsolidadoModel.IndicadorSubcampana),
                    new SqlParameter("@CantidadSAPDiferentes", x_oConsolidadoModel.CantidadSAPDiferentes),
                    new SqlParameter("@NumeroRepeticionesSAP", x_oConsolidadoModel.NumeroRepeticionesSAP),
                    new SqlParameter("@TipoOferta", x_oConsolidadoModel.TipoOferta),
                    new SqlParameter("@UsuarioModificacion", x_oConsolidadoModel.UsuarioModificacion)
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
        /// Elimina un registro de la tabla Consolidado por su primary key.
        /// </summary>
        public void DeleteByParameters(ArchivoModel archivoModel)
        {
            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@IdCampanaPlaneacion", archivoModel.IdCampanaPlaneacion),
                    new SqlParameter("@IdCampanaProceso", archivoModel.IdCampanaProceso),
                    new SqlParameter("@IdPalanca", archivoModel.IdPalanca),
                    new SqlParameter("@UnidadesLimite", archivoModel.UnidadesLimite),
                    new SqlParameter("@NumeroEspacios", archivoModel.NumeroEspacios)
                };
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }

            try
            {
                ejecutarNonQuery("usp_d_ConsolidadoByParameters", parameters);
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de operación de acceso a datos.", ex);
            }
        }

        /// <summary>
        /// Selecciona una registro de la tabla Consolidado por su primary key.
        /// </summary>
        public ConsolidadoModel Select(long? IdConsolidado)
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
			ConsolidadoModel objConsolidado = new ConsolidadoModel();
			try{
                objConsolidado = GetEntity<ConsolidadoModel>("usp_g_Consolidado", parameters);
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
		public List<ConsolidadoModel> SelectAll(ConsolidadoModel consolidadoModel)
		{
            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@pii_PageIndex", consolidadoModel.PageIndex),
                    new SqlParameter("@pii_PageSize", consolidadoModel.PageSize)
                };
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }
            return GetList<ConsolidadoModel>("usp_gl_Consolidado", parameters);
		}


        /// <summary>
        /// Selecciona los registros de la tabla Consolidado por los parametros de Carga.
        /// </summary>
        public List<ConsolidadoModel> SelectByParameters(ArchivoModel archivoModel)
        {
            SqlParameter[] parameters = null;
            try
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@IdCampanaPlaneacion", archivoModel.IdCampanaPlaneacion),
                    new SqlParameter("@IdCampanaProceso", archivoModel.IdCampanaProceso),
                    new SqlParameter("@IdPalanca", archivoModel.IdPalanca),
                    new SqlParameter("@UnidadesLimite", archivoModel.UnidadesLimite),
                    new SqlParameter("@NumeroEspacios", archivoModel.NumeroEspacios)
                };
            }
            catch (Exception ex)
            {
                throw controlarExcepcion("Error de asignación de parámetros.", ex);
            }

            List<ConsolidadoModel> x_oModelConsolidadoList = new List<ConsolidadoModel>();
            DataTable dtResult = new DataTable();

            try
            {
                using (dtResult = ejecutarDataTable("usp_gl_ConsolidadoByParameters", parameters))
                {
                    foreach (DataRow item in dtResult.Rows)
                    {
                        ConsolidadoModel x_oModelConsolidado = MapDataReader(item);
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
        /// Creates a new instance of the ConsolidadoModel class and populates it with data from the specified SqlDataReader.
        /// </summary>
        private ConsolidadoModel MapDataReader(DataRow x_dr)
		{

			ConsolidadoModel x_oConsolidadoModel = new ConsolidadoModel();

			if (!x_dr.IsNull("IdConsolidado")) x_oConsolidadoModel.IdConsolidado = (long)x_dr["IdConsolidado"];
			if (!x_dr.IsNull("IdCampanaPlaneacion")) x_oConsolidadoModel.IdCampanaPlaneacion = (int)x_dr["IdCampanaPlaneacion"];
			if (!x_dr.IsNull("IdCampanaProceso")) x_oConsolidadoModel.IdCampanaProceso = (int)x_dr["IdCampanaProceso"];
			if (!x_dr.IsNull("IdPalanca")) x_oConsolidadoModel.IdPalanca = (short)x_dr["IdPalanca"];
			if (!x_dr.IsNull("UnidadesLimite")) x_oConsolidadoModel.UnidadesLimite = (byte)x_dr["UnidadesLimite"];
			if (!x_dr.IsNull("NumeroEspacios")) x_oConsolidadoModel.NumeroEspacios = (byte)x_dr["NumeroEspacios"];
			if (!x_dr.IsNull("IdPais")) x_oConsolidadoModel.IdPais = (byte)x_dr["IdPais"];
			if (!x_dr.IsNull("CuentaOfertas")) x_oConsolidadoModel.CuentaOfertas = (int)x_dr["CuentaOfertas"];
			if (!x_dr.IsNull("Binomio")) x_oConsolidadoModel.Binomio = (bool)x_dr["Binomio"];
			if (!x_dr.IsNull("CUVPadre")) x_oConsolidadoModel.CUVPadre = (string)x_dr["CUVPadre"];
			if (!x_dr.IsNull("CUV")) x_oConsolidadoModel.CUV = (string)x_dr["CUV"];
			if (!x_dr.IsNull("CUCAntiguo")) x_oConsolidadoModel.CUCAntiguo = (string)x_dr["CUCAntiguo"];
			if (!x_dr.IsNull("SAPAntiguo")) x_oConsolidadoModel.SAPAntiguo = (string)x_dr["SAPAntiguo"];
			if (!x_dr.IsNull("BPCSGenericoAntiguo")) x_oConsolidadoModel.BPCSGenericoAntiguo = (string)x_dr["BPCSGenericoAntiguo"];
			if (!x_dr.IsNull("BPCSTonoAntiguo")) x_oConsolidadoModel.BPCSTonoAntiguo = (string)x_dr["BPCSTonoAntiguo"];
			if (!x_dr.IsNull("DescripcionGenericoAntiguo")) x_oConsolidadoModel.DescripcionGenericoAntiguo = (string)x_dr["DescripcionGenericoAntiguo"];
			if (!x_dr.IsNull("DescripcionTonoAntiguo")) x_oConsolidadoModel.DescripcionTonoAntiguo = (string)x_dr["DescripcionTonoAntiguo"];
			if (!x_dr.IsNull("Lanzamiento")) x_oConsolidadoModel.Lanzamiento = (bool)x_dr["Lanzamiento"];
			if (!x_dr.IsNull("CUC")) x_oConsolidadoModel.CUC = (string)x_dr["CUC"];
			if (!x_dr.IsNull("SAP")) x_oConsolidadoModel.SAP = (string)x_dr["SAP"];
			if (!x_dr.IsNull("BPCSGenerico")) x_oConsolidadoModel.BPCSGenerico = (string)x_dr["BPCSGenerico"];
			if (!x_dr.IsNull("BPCSTono")) x_oConsolidadoModel.BPCSTono = (string)x_dr["BPCSTono"];
			if (!x_dr.IsNull("IndicadorGratis")) x_oConsolidadoModel.IndicadorGratis = (bool)x_dr["IndicadorGratis"];
			if (!x_dr.IsNull("DescripcionSet")) x_oConsolidadoModel.DescripcionSet = (string)x_dr["DescripcionSet"];
			if (!x_dr.IsNull("DescripcionProducto")) x_oConsolidadoModel.DescripcionProducto = (string)x_dr["DescripcionProducto"];
			if (!x_dr.IsNull("DescripcionCatalogo")) x_oConsolidadoModel.DescripcionCatalogo = (string)x_dr["DescripcionCatalogo"];
			if (!x_dr.IsNull("CompuestaVariable")) x_oConsolidadoModel.CompuestaVariable = (bool)x_dr["CompuestaVariable"];
			if (!x_dr.IsNull("NumeroGrupo")) x_oConsolidadoModel.NumeroGrupo = (long)x_dr["NumeroGrupo"];
			if (!x_dr.IsNull("FactorCuadre")) x_oConsolidadoModel.FactorCuadre = (bool)x_dr["FactorCuadre"];
			if (!x_dr.IsNull("FlagTop")) x_oConsolidadoModel.FlagTop = (bool)x_dr["FlagTop"];
			if (!x_dr.IsNull("Tono")) x_oConsolidadoModel.Tono = (string)x_dr["Tono"];
			if (!x_dr.IsNull("IdMarca")) x_oConsolidadoModel.Marca = (string)x_dr["Marca"];
			if (!x_dr.IsNull("IdCategoria")) x_oConsolidadoModel.Categoria = (string)x_dr["Categoria"];
			if (!x_dr.IsNull("Tipo")) x_oConsolidadoModel.Tipo = (string)x_dr["Tipo"];
			if (!x_dr.IsNull("DescuentoSet")) x_oConsolidadoModel.DescuentoSet = (decimal)x_dr["DescuentoSet"];
			if (!x_dr.IsNull("ReglaSet")) x_oConsolidadoModel.ReglaSet = (decimal)x_dr["ReglaSet"];
			if (!x_dr.IsNull("GAPMNvsImpreso")) x_oConsolidadoModel.GAPMNvsImpreso = (long)x_dr["GAPMNvsImpreso"];
			if (!x_dr.IsNull("GAPUSDvsImpreso")) x_oConsolidadoModel.GAPUSDvsImpreso = (long)x_dr["GAPUSDvsImpreso"];
			if (!x_dr.IsNull("IndicadorCxC")) x_oConsolidadoModel.IndicadorCxC = (bool)x_dr["IndicadorCxC"];
			if (!x_dr.IsNull("FactoRepeticion")) x_oConsolidadoModel.FactoRepeticion = (long)x_dr["FactoRepeticion"];
			if (!x_dr.IsNull("POUnitarioMN")) x_oConsolidadoModel.POUnitarioMN = (decimal)x_dr["POUnitarioMN"];
			if (!x_dr.IsNull("POSetMN")) x_oConsolidadoModel.POSetMN = (decimal)x_dr["POSetMN"];
			if (!x_dr.IsNull("PNSetMN")) x_oConsolidadoModel.PNSetMN = (decimal)x_dr["PNSetMN"];
			if (!x_dr.IsNull("PNUnitarioMN")) x_oConsolidadoModel.PNUnitarioMN = (decimal)x_dr["PNUnitarioMN"];
			if (!x_dr.IsNull("Unidades")) x_oConsolidadoModel.Unidades = (long)x_dr["Unidades"];
			if (!x_dr.IsNull("P1")) x_oConsolidadoModel.P1 = (bool)x_dr["P1"];
			if (!x_dr.IsNull("P2")) x_oConsolidadoModel.P2 = (bool)x_dr["P2"];
			if (!x_dr.IsNull("P3")) x_oConsolidadoModel.P3 = (bool)x_dr["P3"];
			if (!x_dr.IsNull("P4")) x_oConsolidadoModel.P4 = (bool)x_dr["P4"];
			if (!x_dr.IsNull("P5")) x_oConsolidadoModel.P5 = (bool)x_dr["P5"];
			if (!x_dr.IsNull("P6")) x_oConsolidadoModel.P6 = (bool)x_dr["P6"];
			if (!x_dr.IsNull("P7")) x_oConsolidadoModel.P7 = (bool)x_dr["P7"];
			if (!x_dr.IsNull("Comentario")) x_oConsolidadoModel.Comentario = (string)x_dr["Comentario"];
			if (!x_dr.IsNull("CODP")) x_oConsolidadoModel.CODP = (string)x_dr["CODP"];
			if (!x_dr.IsNull("NumeroProductosOferta")) x_oConsolidadoModel.NumeroProductosOferta = (long)x_dr["NumeroProductosOferta"];
			if (!x_dr.IsNull("TipoPlan")) x_oConsolidadoModel.TipoPlan = (string)x_dr["TipoPlan"];
			if (!x_dr.IsNull("IndicadorSubcampana")) x_oConsolidadoModel.IndicadorSubcampana = (bool)x_dr["IndicadorSubcampana"];
            if (!x_dr.IsNull("CantidadSAPDiferentes")) x_oConsolidadoModel.CantidadSAPDiferentes = (int)x_dr["CantidadSAPDiferentes"];
			if (!x_dr.IsNull("UsuarioCreacion")) x_oConsolidadoModel.UsuarioCreacion = (string)x_dr["UsuarioCreacion"];
			if (!x_dr.IsNull("FechaCreacion")) x_oConsolidadoModel.FechaCreacion = (DateTime)x_dr["FechaCreacion"];
			if (!x_dr.IsNull("UsuarioModificacion")) x_oConsolidadoModel.UsuarioModificacion = (string)x_dr["UsuarioModificacion"];
			if (!x_dr.IsNull("FechaModificacion")) x_oConsolidadoModel.FechaModificacion = (DateTime)x_dr["FechaModificacion"];

			return x_oConsolidadoModel;
		}

		#endregion
	}
}
