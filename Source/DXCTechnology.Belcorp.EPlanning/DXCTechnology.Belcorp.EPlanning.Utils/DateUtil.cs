using System;
using System.Globalization;

namespace DXCTechnology.Belcorp.ePlanning.SharedLibreries
{
    public class DateUtil
    {
        public static int ObtenerNumeroSemana(DateTime x_dFecha)
        {
            CultureInfo myCI = new CultureInfo("es-ES");
            Calendar myCal = myCI.Calendar;

            // Gets the DTFI properties required by GetWeekOfYear.
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;

            // Displays the number of the current week relative to the beginning of the year.
            return myCal.GetWeekOfYear(x_dFecha, myCWR, myFirstDOW);

            //TODO: evaluar en el caso de fin de año
        }

        public static string ConvertDateTimeToString(DateTime x_fecha)
        {
            string cFecha = string.Empty;
            cFecha = x_fecha.ToString("yyyyMMdd HH:mm");
            if (x_fecha.Year == 1)
                cFecha = "20000101 00:00";

            return cFecha;
        }

        public static string ConvertDateToString(DateTime x_fecha)
        {
            string cFecha = string.Empty;
            cFecha = x_fecha.ToString("yyyyMMdd");
            if (x_fecha.Year == 1)
                cFecha = "20000101";

            return cFecha;
        }

        public static int ConvertDateToInt(DateTime x_fecha)
        {
            int nFecha = 0;
            if (!int.TryParse(x_fecha.ToString("yyyyMMdd"), out nFecha))
                nFecha = 20000101;

            return nFecha;
        }

        public static int DaysBetween(DateTime d1, DateTime d2)
        {
            TimeSpan span = d2.Subtract(d1);
            return (int)span.TotalDays;
        }

        /// <summary>
        /// Devuelve un registro de error
        /// </summary>
        /// <param name="x_Fila">fila del DataTable</param>
        /// <param name="x_Columna">Nombre de la columna</param>
        /// <param name="x_Valor">Valor en la Columna</param>
        /// <param name="x_Solucion">Comentario</param>
        /// <returns>Array de error</returns>
        public static object[] SetError(string x_Ticket, string x_Columna, string x_Valor, string x_Solucion)
        {
            object[] oErrores = new object[4];

            oErrores[0] = x_Ticket;
            oErrores[1] = x_Columna.ToString();
            oErrores[2] = x_Valor.ToString();
            oErrores[3] = x_Solucion.ToString();

            return oErrores;
        }


        public static string formatFecha(object valor)
        {
            string rr = "";
            if (valor.ToString()!="")
            { rr = valor.ToString().Substring(6, 2) + "/" + valor.ToString().Substring(4, 2) + "/" + valor.ToString().Substring(0, 4); }
            return rr;
        }
    }
}
