using System;
using System.Collections.Generic;
using DXCTechnology.Belcorp.ePlanning.DataAccessLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;
using DXCTechnology.Belcorp.ePlanning.SharedLibreries;
using System.IO;
using OfficeOpenXml;
using Microsoft.VisualBasic;

namespace DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer
{
    public class BL_Consolidado
    {
        // IndexColumn campos obligatorios
        const int IndexColumn_CampanaPlaneacion = 1;
        const int IndexColumn_CampanaProceso = 2;
        const int IndexColumn_Palanca = 3;
        const int IndexColumn_Pais = 6;
        const int IndexColumn_CuentaOfertas = 7;
        const int IndexColumn_Binomio = 8;
        const int IndexColumn_Lanzamiento = 17;
        const int IndexColumn_CUC = 18;
        const int IndexColumn_SAP = 19;
        const int IndexColumn_BPCSGenerico = 20;
        const int IndexColumn_BPCSTono = 21;
        const int IndexColumn_DescripcionSet = 23;
        const int IndexColumn_CompuestaVariable = 26;
        const int IndexColumn_Categoria = 32;
        const int IndexColumn_POUnitarioMN = 40;
        const int IndexColumn_POSetMN = 41;
        const int IndexColumn_PNSetMN = 42;
        const int IndexColumn_PNUnitarioMN = 43;

        // IndexColumn campos opcionales
        const int IndexColumn_UnidadesLimite = 4;
        const int IndexColumn_NumeroEspacios = 5;
        const int IndexColumn_CUVPadre = 9;
        const int IndexColumn_CUV = 10;
        const int IndexColumn_CUCAntiguo = 11;
        const int IndexColumn_SAPAntiguo = 12;
        const int IndexColumn_BPCSGenericoAntiguo = 13;
        const int IndexColumn_BPCSTonoAntiguo = 14;
        const int IndexColumn_DescripcionGenericoAntiguo = 15;
        const int IndexColumn_DescripcionTonoAntiguo = 16;
        const int IndexColumn_IndicadorGratis = 22;
        const int IndexColumn_DescripcionProducto = 24;
        const int IndexColumn_DescripcionCatalogo = 25;
        const int IndexColumn_NumeroGrupo = 27;
        const int IndexColumn_FactorCuadre = 28;
        const int IndexColumn_FlagTop = 29;
        const int IndexColumn_Tono = 30;
        const int IndexColumn_Marca = 31;
        const int IndexColumn_Tipo = 33;
        const int IndexColumn_DescuentoSet = 34;
        const int IndexColumn_ReglaSet = 35;
        const int IndexColumn_GAPMNvsImpreso = 36;
        const int IndexColumn_GAPUSDvsImpreso = 37;
        const int IndexColumn_IndicadorCxC = 38;
        const int IndexColumn_FactorRepeticion = 39;
        const int IndexColumn_Unidades = 44;
        const int IndexColumn_P1 = 45;
        const int IndexColumn_P2 = 46;
        const int IndexColumn_P3 = 47;
        const int IndexColumn_P4 = 48;
        const int IndexColumn_P5 = 49;
        const int IndexColumn_P6 = 50;
        const int IndexColumn_P7 = 51;
        const int IndexColumn_Comentario = 52;
        const int IndexColumn_CODP = 53;
        const int IndexColumn_NumeroProductosOferta = 54;
        const int IndexColumn_TipoPlan = 55;
        const int IndexColumn_IndicadorSubcampana = 56;

        #region Methods

        /// <summary>
        /// Guarda un registro de la tabla Consolidado.
        /// </summary>
        public void Insert(ConsolidadoModel x_oConsolidadoModel)
        {
            new DA_Consolidado().Insert(x_oConsolidadoModel);
        }
        /// <summary>
        /// Procesa las variables del Consolidado.
        /// </summary>
        public void ProcessVariables(ArchivoModel x_oArchivoModel)
        {
            new DA_Consolidado().ProcessVariables(x_oArchivoModel);
        }
        
        /// <summary>
        /// Actualiza a registro de la tabla Consolidado.
        /// </summary>
        public void Update(ConsolidadoModel x_oConsolidadoModel)
        {
            new DA_Consolidado().Update(x_oConsolidadoModel);
        }

        /// <summary>
        /// Elimina un registro de la tabla Consolidado por su primary key.
        /// </summary>
        public void Delete(long IdConsolidado)
        {
            new DA_Consolidado().Delete(IdConsolidado);
        }

        /// <summary>
        /// Elimina un registro de la tabla Consolidado por los parametros de su carga.
        /// </summary>
        public void DeleteByParameters(ArchivoModel archivoModel)
        {
            new DA_Consolidado().DeleteByParameters(archivoModel);
        }

        /// <summary>
        /// Selecciona una registro de la tabla Consolidado por su primary key.
        /// </summary>
        public ConsolidadoModel Select(long? IdConsolidado)
        {
            return new DA_Consolidado().Select(IdConsolidado);
        }

        /// <summary>
        /// Selecciona todos los registro de la tabla Consolidado.
        /// </summary>
        public List<ConsolidadoModel> SelectAll(ConsolidadoModel consolidadoModel)
        {
            return new DA_Consolidado().SelectAll(consolidadoModel);
        }

        /// <summary>
        /// Selecciona todos los registro de la tabla Consolidado por carga.
        /// </summary>
        public List<ConsolidadoModel> SelectByParamters(ArchivoModel archivoModel)
        {
            return new DA_Consolidado().SelectByParameters(archivoModel);
        }

        public Boolean ValidateConsolidado(ArchivoModel archivoModel)
        {
            // Validamos que exista el archivo
            if (!File.Exists(archivoModel.NombreCargado))
            {
                new DA_ArchivoLog().Insert(
                        new ArchivoLogModel(archivoModel.IdArchivo,
                        "El archivo cargado no existe.", null, archivoModel.UsuarioCreacion));
                return false;
            }

            // Validamos la extensi�n del archivo
            if (Path.GetExtension(archivoModel.NombreCargado).ToString() != ".xlsx" &&
                    Path.GetExtension(archivoModel.NombreCargado).ToString() != ".xls")
            {
                new DA_ArchivoLog().Insert(
                        new ArchivoLogModel(archivoModel.IdArchivo,
                        "El archivo tiene una extensi�n inv�lida.", null, archivoModel.UsuarioCreacion));
                return false;
            }

            // Validamos que existan registros en las columnas obligatorias
            //int MaxRows = (Path.GetExtension(archivoModel.NombreCargado).ToString() == ".xls" ? 65536 : 1048576);
            ExcelPackage excelPackage = new OfficeOpenXml.ExcelPackage();
            excelPackage.Load(File.OpenRead(archivoModel.NombreCargado));
            ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[1];
            int RowCount = 0;

            int EndRow = excelWorksheet.Dimension.End.Row;
            int EndCol = excelWorksheet.Dimension.End.Column;

            if (IndexColumn_IndicadorSubcampana > EndCol)
            {
                new DA_ArchivoLog().Insert(
                        new ArchivoLogModel(archivoModel.IdArchivo,
                        "El archivo no cuenta con la cantidad de columnas necesarias.", null, archivoModel.UsuarioCreacion));
                return false;
            }

            if (EndRow < 2)
            {
                new DA_ArchivoLog().Insert(
                        new ArchivoLogModel(archivoModel.IdArchivo,
                        "El archivo no tiene registros.", null, archivoModel.UsuarioCreacion));
                return false;
            }

            for (int Row = 2; Row <= EndRow; Row++)
            {
                if (excelWorksheet.Cells[Row, IndexColumn_CampanaPlaneacion].Value.ToString().Trim() == String.Empty ||
                        excelWorksheet.Cells[Row, IndexColumn_CampanaProceso].Value.ToString().Trim() == String.Empty ||
                        excelWorksheet.Cells[Row, IndexColumn_Palanca].Value.ToString().Trim() == String.Empty ||
                        excelWorksheet.Cells[Row, IndexColumn_Pais].Value.ToString().Trim() == String.Empty ||
                        excelWorksheet.Cells[Row, IndexColumn_CuentaOfertas].Value.ToString().Trim() == String.Empty ||
                        excelWorksheet.Cells[Row, IndexColumn_Binomio].Value.ToString().Trim() == String.Empty ||
                        excelWorksheet.Cells[Row, IndexColumn_Lanzamiento].Value.ToString().Trim() == String.Empty ||
                        excelWorksheet.Cells[Row, IndexColumn_CUC].Value.ToString().Trim() == String.Empty ||
                        excelWorksheet.Cells[Row, IndexColumn_SAP].Value.ToString().Trim() == String.Empty ||
                        excelWorksheet.Cells[Row, IndexColumn_BPCSGenerico].Value.ToString().Trim() == String.Empty ||
                        excelWorksheet.Cells[Row, IndexColumn_BPCSTono].Value.ToString().Trim() == String.Empty ||
                        excelWorksheet.Cells[Row, IndexColumn_DescripcionSet].Value.ToString().Trim() == String.Empty ||
                        excelWorksheet.Cells[Row, IndexColumn_CompuestaVariable].Value.ToString().Trim() == String.Empty ||
                        excelWorksheet.Cells[Row, IndexColumn_POUnitarioMN].Value.ToString().Trim() == String.Empty ||
                        excelWorksheet.Cells[Row, IndexColumn_POSetMN].Value.ToString().Trim() == String.Empty ||
                        excelWorksheet.Cells[Row, IndexColumn_PNSetMN].Value.ToString().Trim() == String.Empty ||
                        excelWorksheet.Cells[Row, IndexColumn_PNUnitarioMN].Value.ToString().Trim() == String.Empty)
                {
                    RowCount = Row;
                    break;
                }
            }

            if (EndRow == 1) //S�lo tiene cabecera
            {
                new DA_ArchivoLog().Insert(
                        new ArchivoLogModel(archivoModel.IdArchivo,
                        "El archivo no tiene registros.", RowCount.ToString(), archivoModel.UsuarioCreacion));
                return false;
            }

            // Carga finalizo satisfatoriamente
            new DA_ArchivoLog().Insert(
                    new ArchivoLogModel(archivoModel.IdArchivo,
                    "El archivo cargado exitosamente.", null, archivoModel.UsuarioCreacion));
            return true;
        }

        public void CalculateConsolidado(ArchivoModel archivoModel)
        {
            Boolean IndicadorError = false;
            int MaxRows = (Path.GetExtension(archivoModel.NombreCargado).ToString() == ".xlsx" ? 1048576 : 65536);
            ExcelPackage excelPackage = new OfficeOpenXml.ExcelPackage();
            excelPackage.Load(File.OpenRead(archivoModel.NombreCargado));
            ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[1];
            int EndRow = excelWorksheet.Dimension.End.Row;
            List<ConsolidadoModel> listConsolidadoModel = new List<ConsolidadoModel>();

            for (int Row = 2; Row <= excelWorksheet.Dimension.End.Row; Row++)
            {
                ConsolidadoModel consolidadoModel = new ConsolidadoModel();

                // Parametros
                consolidadoModel.IdCampanaPlaneacion = archivoModel.IdCampanaPlaneacion;
                consolidadoModel.IdCampanaProceso = archivoModel.IdCampanaProceso;
                consolidadoModel.IdPalanca = archivoModel.IdPalanca;
                consolidadoModel.UnidadesLimite = archivoModel.UnidadesLimite;
                consolidadoModel.NumeroEspacios = archivoModel.NumeroEspacios;

                PaisModel paisModel = new BL_Pais().SelectByAbreviatura(excelWorksheet.Cells[Row, IndexColumn_Pais].Value.ToString());
                consolidadoModel.IdPais = paisModel.IdPais;

                try
                {
                    consolidadoModel.CuentaOfertas = Convert.ToInt32(excelWorksheet.Cells[Row, IndexColumn_CuentaOfertas].Value.ToString().Trim());
                }
                catch
                {
                }



                try
                {
                    consolidadoModel.Binomio = Convert.ToBoolean(excelWorksheet.Cells[Row, IndexColumn_Binomio].Value);
                }
                catch (Exception)
                {
                    new BL_ArchivoLog().Insert(
                       new ArchivoLogModel(archivoModel.IdArchivo,
                       "Error en la columna [Binomio]. Valor inv�lido.", Row.ToString(), archivoModel.UsuarioCreacion));
                    IndicadorError = true;
                    break;
                }



                consolidadoModel.CUVPadre = excelWorksheet.Cells[Row, IndexColumn_CUVPadre].Value.ToString().Trim();
                consolidadoModel.CUV = excelWorksheet.Cells[Row, IndexColumn_CUV].Value.ToString().Trim();

                // Productos Antiguos

                try { consolidadoModel.CUCAntiguo = excelWorksheet.Cells[Row, IndexColumn_CUCAntiguo].Value.ToString().Trim(); } catch { }
                try { consolidadoModel.SAPAntiguo = excelWorksheet.Cells[Row, IndexColumn_SAPAntiguo].Value.ToString().Trim(); } catch { }
                try { consolidadoModel.BPCSGenericoAntiguo = excelWorksheet.Cells[Row, IndexColumn_BPCSGenericoAntiguo].Value.ToString().Trim(); } catch { }
                try { consolidadoModel.BPCSTonoAntiguo = excelWorksheet.Cells[Row, IndexColumn_BPCSTonoAntiguo].Value.ToString().Trim(); } catch { }
                try { consolidadoModel.DescripcionGenericoAntiguo = excelWorksheet.Cells[Row, IndexColumn_DescripcionGenericoAntiguo].Value.ToString().Trim(); } catch { }
                try { consolidadoModel.DescripcionTonoAntiguo = excelWorksheet.Cells[Row, IndexColumn_DescripcionTonoAntiguo].Value.ToString().Trim(); } catch { }
                try { consolidadoModel.Lanzamiento = Convert.ToBoolean(excelWorksheet.Cells[Row, IndexColumn_Lanzamiento].Value); } catch { }
                try { consolidadoModel.CUC = excelWorksheet.Cells[Row, IndexColumn_CUC].Value.ToString().Trim(); } catch { }
                try { consolidadoModel.SAP = excelWorksheet.Cells[Row, IndexColumn_SAP].Value.ToString().Trim(); } catch { }
                try { consolidadoModel.BPCSGenerico = excelWorksheet.Cells[Row, IndexColumn_BPCSGenerico].Value.ToString().Trim(); } catch { }
                try { consolidadoModel.BPCSTono = excelWorksheet.Cells[Row, IndexColumn_BPCSTono].Value.ToString().Trim(); } catch { }
                try { consolidadoModel.IndicadorGratis = Convert.ToBoolean(excelWorksheet.Cells[Row, IndexColumn_IndicadorGratis].Value); } catch { }
                try { consolidadoModel.DescripcionProducto = excelWorksheet.Cells[Row, IndexColumn_DescripcionProducto].Value.ToString().Trim(); } catch { }
                try { consolidadoModel.DescripcionCatalogo = excelWorksheet.Cells[Row, IndexColumn_DescripcionCatalogo].Value.ToString().Trim(); } catch { }
                try { consolidadoModel.CompuestaVariable = Convert.ToBoolean(excelWorksheet.Cells[Row, IndexColumn_CompuestaVariable].Value); } catch { }
                try { consolidadoModel.NumeroGrupo = Convert.ToInt32(excelWorksheet.Cells[Row, IndexColumn_NumeroGrupo].Value.ToString().Trim()); } catch { }
                try { consolidadoModel.FlagTop = Convert.ToBoolean(excelWorksheet.Cells[Row, IndexColumn_FlagTop].Value); } catch { }
                try { consolidadoModel.Tono = excelWorksheet.Cells[Row, IndexColumn_Tono].Value.ToString().Trim(); } catch { }
                try { consolidadoModel.Marca = excelWorksheet.Cells[Row, IndexColumn_Marca].Value.ToString().Trim(); } catch { }


                try { consolidadoModel.Categoria = excelWorksheet.Cells[Row, IndexColumn_Categoria].Value.ToString().Trim(); } catch { }

                try { consolidadoModel.DescripcionSet = excelWorksheet.Cells[Row, IndexColumn_DescripcionSet].Value.ToString().Trim(); } catch { }
                try { consolidadoModel.Tipo = excelWorksheet.Cells[Row, IndexColumn_Tipo].Value.ToString().Trim(); } catch { }
                try
                {
                    if (Information.IsNumeric(excelWorksheet.Cells[Row, IndexColumn_DescuentoSet].Value.ToString().Trim()))
                        if (Convert.ToDecimal(excelWorksheet.Cells[Row, IndexColumn_DescuentoSet].Value.ToString().Trim()) <= 100)
                            consolidadoModel.DescuentoSet = Convert.ToDecimal(excelWorksheet.Cells[Row, IndexColumn_DescuentoSet].Value);
                }
                catch { }
                try
                {
                    if (Information.IsNumeric(excelWorksheet.Cells[Row, IndexColumn_ReglaSet].Value.ToString().Trim()))
                        if (Convert.ToDecimal(excelWorksheet.Cells[Row, IndexColumn_ReglaSet].Value.ToString().Trim()) <= 100)
                            consolidadoModel.ReglaSet = Convert.ToDecimal(excelWorksheet.Cells[Row, IndexColumn_ReglaSet].Value);
                }
                catch (Exception)
                {

                }
                try { consolidadoModel.GAPMNvsImpreso = Convert.ToInt64(excelWorksheet.Cells[Row, IndexColumn_GAPMNvsImpreso].Value); } catch { }
                try { consolidadoModel.GAPUSDvsImpreso = Convert.ToInt64(excelWorksheet.Cells[Row, IndexColumn_GAPUSDvsImpreso].Value); } catch { }
                try { consolidadoModel.IndicadorCxC = Convert.ToBoolean(excelWorksheet.Cells[Row, IndexColumn_IndicadorCxC].Value); } catch { }
                try { consolidadoModel.FactoRepeticion = Convert.ToInt64(excelWorksheet.Cells[Row, IndexColumn_FactorRepeticion].Value); } catch { }
                try { consolidadoModel.POUnitarioMN = Convert.ToDecimal(excelWorksheet.Cells[Row, IndexColumn_POUnitarioMN].Value); } catch { }
                try { consolidadoModel.POSetMN = Convert.ToDecimal(excelWorksheet.Cells[Row, IndexColumn_POSetMN].Value); } catch { }
                try { consolidadoModel.PNSetMN = Convert.ToDecimal(excelWorksheet.Cells[Row, IndexColumn_PNSetMN].Value); } catch { }
                try { consolidadoModel.PNUnitarioMN = Convert.ToDecimal(excelWorksheet.Cells[Row, IndexColumn_PNUnitarioMN].Value.ToString().Trim()); } catch { }
                try { consolidadoModel.Unidades = Convert.ToInt64(excelWorksheet.Cells[Row, IndexColumn_Unidades].Value.ToString().Trim()); } catch { }
                try { consolidadoModel.P1 = Convert.ToBoolean(excelWorksheet.Cells[Row, IndexColumn_P1].Value); } catch { }
                try { consolidadoModel.P2 = Convert.ToBoolean(excelWorksheet.Cells[Row, IndexColumn_P2].Value); } catch { }
                try { consolidadoModel.P3 = Convert.ToBoolean(excelWorksheet.Cells[Row, IndexColumn_P3].Value); } catch { }
                try { consolidadoModel.P4 = Convert.ToBoolean(excelWorksheet.Cells[Row, IndexColumn_P4].Value); } catch { }
                try { consolidadoModel.P5 = Convert.ToBoolean(excelWorksheet.Cells[Row, IndexColumn_P5].Value); } catch { }
                try { consolidadoModel.P6 = Convert.ToBoolean(excelWorksheet.Cells[Row, IndexColumn_P6].Value); } catch { }
                try { consolidadoModel.P7 = Convert.ToBoolean(excelWorksheet.Cells[Row, IndexColumn_P7].Value); } catch { }
                try { consolidadoModel.Comentario = excelWorksheet.Cells[Row, IndexColumn_Comentario].Value.ToString().Trim(); } catch { }
                try { consolidadoModel.CODP = excelWorksheet.Cells[Row, IndexColumn_CODP].Value.ToString().Trim(); } catch { }
                try { consolidadoModel.NumeroProductosOferta = Convert.ToInt64(excelWorksheet.Cells[Row, IndexColumn_NumeroProductosOferta].Value); } catch { }
                try { consolidadoModel.IndicadorSubcampana = Convert.ToBoolean(excelWorksheet.Cells[Row, IndexColumn_IndicadorSubcampana].Value); } catch { }
                try { consolidadoModel.TipoPlan = excelWorksheet.Cells[Row, IndexColumn_TipoPlan].Value.ToString().Trim(); } catch { }


                consolidadoModel.UsuarioCreacion = archivoModel.UsuarioCreacion;

                listConsolidadoModel.Add(consolidadoModel);
            }

            if (IndicadorError)
            {
                new BL_ArchivoLog().Insert(
                        new ArchivoLogModel(archivoModel.IdArchivo,
                        "El archivo cargado contiene errores.", null, archivoModel.UsuarioCreacion));
                archivoModel.IdEstado = Estados.ArchivoConError;
                archivoModel.UsuarioModificacion = archivoModel.UsuarioCreacion;
                new BL_Archivo().UpdateIdEstado(archivoModel);
                return;
            }

            BL_Consolidado bl_Consolidado = new BL_Consolidado();
            foreach (ConsolidadoModel consolidadoM in listConsolidadoModel)
            {
                new BL_Consolidado().Insert(consolidadoM);
            }

            new BL_ArchivoLog().Insert(
                    new ArchivoLogModel(archivoModel.IdArchivo,

                    "Se guardo el Consolidado de manera satisfactoria. [" + listConsolidadoModel.Count.ToString() + "] filas cargados.", null, archivoModel.UsuarioCreacion));

        }

        #endregion
    }
}
