using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXCTechnology.Belcorp.ePlanning.Utils.Extensions
{
    public static class DataTableExtensions
    {
        private const string ExtensionExcel = @".xls";
        private const string Estilos = @"<style>.texto{text-align: left; mso-number-format:\@;} .fecha{text-align: center;} .derecha{text-align: right;} .numero{text-align: right; mso-number-format:""_ * \#\,\#\#0\.00_ \;_ * \\-\#\,\#\#0\.00_ \;_ * \0022-\0022??_ \;_ \@_ ""}</style>";
        public static void ToExcel(this DataTable dataTable, string nombreArchivo)
        {
            if (dataTable == null || dataTable.Rows.Count == 0) return;

            nombreArchivo = nombreArchivo + ExtensionExcel;

            using (var tw = new StringWriter())
            {
                var hw = new HtmlTextWriter(tw);
                var dataGrid = new DataGrid();

                dataGrid.HeaderStyle.BackColor = ColorTranslator.FromHtml("#3AC0F2");
                dataGrid.HeaderStyle.ForeColor = Color.FromName("White");
                dataGrid.HeaderStyle.Font.Bold = true;

                dataGrid.ItemStyle.BackColor = ColorTranslator.FromHtml("#A1DCF2");

                dataGrid.AlternatingItemStyle.BackColor = Color.FromName("White");
                dataGrid.AlternatingItemStyle.ForeColor = ColorTranslator.FromHtml("#000");

                dataGrid.DataSource = dataTable;
                dataGrid.DataBind();

                for (var i = 0; i < dataGrid.Items.Count; i++)
                {
                    var indiceColumna = 0;
                    foreach (TableCell celda in dataGrid.Items[i].Cells)
                    {
                        if (dataTable.Columns[indiceColumna].ColumnName.Equals(@"linea", StringComparison.InvariantCultureIgnoreCase))
                        {
                            celda.CssClass = "derecha";
                        }
                        else
                        {
                            switch (dataTable.Columns[indiceColumna].DataType.UnderlyingSystemType.Name)
                            {
                                case "Int32":
                                case "Decimal":
                                case "Double":
                                    celda.CssClass = "numero";
                                    decimal valorDecimal;
                                    if (decimal.TryParse(celda.Text, out valorDecimal))
                                    {
                                        celda.Text = valorDecimal.ToString("N2");
                                    }
                                    break;
                                case "DateTime":
                                    celda.CssClass = "fecha";
                                    DateTime valorDateTime;
                                    if (DateTime.TryParse(celda.Text, out valorDateTime))
                                    {
                                        celda.Text = valorDateTime.ToString("d");
                                    }
                                    break;
                                default:
                                    celda.CssClass = "texto";
                                    break;
                            }
                        }

                        indiceColumna++;
                    }
                }

                dataGrid.RenderControl(hw);

                HttpContext.Current.Response.Clear();
                HttpContext.Current.Response.ContentType = "application/vnd.ms-excel";
                HttpContext.Current.Response.ContentEncoding = Encoding.Unicode;
                HttpContext.Current.Response.BinaryWrite(Encoding.Unicode.GetPreamble());
                HttpContext.Current.Response.SetCookie(new HttpCookie("fileDownload", "true"));
                HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment; filename=" + nombreArchivo + "");
                HttpContext.Current.Response.Write(Estilos);
                HttpContext.Current.Response.Output.Write(tw.ToString());
                HttpContext.Current.Response.End();
            }
        }
    }
}
