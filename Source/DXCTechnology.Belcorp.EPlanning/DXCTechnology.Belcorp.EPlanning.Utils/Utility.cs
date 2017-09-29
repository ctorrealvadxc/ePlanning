using System;
using System.IO;
using System.Xml.Serialization;

namespace DXCTechnology.Belcorp.ePlanning.SharedLibreries
{ 
    public static class Utility
    {
        public static string ObtenerContentTypeExcel(string extension)
        {
            switch (extension)
            {
                case ".xls":
                    return "application/vnd.ms-excel";
                case ".xlsx":
                    return "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                default:
                    return String.Empty;
            }
        }

        public static string GetConnectionStringExcel(string extension, string rutaArchivo)
        {
            switch (extension)
            {
                case ".xls":
                    return String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=Yes;IMEX=0""", rutaArchivo); ;
                case ".xlsx":
                    return String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=Yes;IMEX=0""", rutaArchivo);
                default:
                    return String.Empty; ;
            }
        }

        public static String FormartoException(String Mensaje)
        {
            Mensaje = Mensaje.Replace(Convert.ToChar("'"), Convert.ToChar(" ")).Trim();
            Mensaje = Mensaje.Replace("\r", "").Trim();
            Mensaje = Mensaje.Replace("\n", "").Trim();
            Mensaje = Mensaje.Replace("|", "\\n ").Trim();
            return Mensaje;
        }

        public static bool IsDate(string Fecha)
        {
            bool IsDate = true;
            try
            {
                DateTime date = DateTime.Parse(Fecha);
            }
            catch
            {
                IsDate = false;
            }
            return IsDate;
        }

        public static bool IsNumeric(string Numero)
        {
            bool IsNumeric = true;
            try
            {
                Int32 iNum = Convert.ToInt32(Numero);
            }
            catch
            {
                IsNumeric = false;
            }
            return IsNumeric;
        }

        /// <summary>
        /// Serializa un objeto
        /// </summary>
        /// <param name="obj">Objeto</param>
        /// <returns></returns>
        public static string SerializarToXml(object obj)
        {
            //Serializar a XML (UTF-16) un objeto cualquiera
            try
            {
                string ResultXmlFinal = null;
                StringWriter strWriter = new StringWriter();
                XmlSerializer serializer = new XmlSerializer(obj.GetType());

                serializer.Serialize(strWriter, obj);
                string resultXml = strWriter.ToString();
                strWriter.Close();
                ResultXmlFinal = resultXml.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");
                ResultXmlFinal = ResultXmlFinal.TrimEnd();
                return ResultXmlFinal;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

    }
}
