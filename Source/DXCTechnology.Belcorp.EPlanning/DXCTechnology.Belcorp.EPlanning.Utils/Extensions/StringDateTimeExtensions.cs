using System;

namespace DXCTechnology.Belcorp.ePlanning.Utils.Extensions
{
    public static class StringDateTimeExtensions
    {
        public static string ToCustomString(this DateTime fecha, string formato = "yyyyMMdd")
        {
            return fecha.ToString(formato);
        }

        public static string ToStringDate(this string cadena)
        {
            DateTime fecha;

            return DateTime.TryParse(cadena, out fecha) ? fecha.ToCustomString() : "";
        }
    }
}
