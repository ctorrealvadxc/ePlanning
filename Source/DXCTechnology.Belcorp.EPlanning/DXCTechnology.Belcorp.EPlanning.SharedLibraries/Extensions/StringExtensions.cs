using System;

namespace DXCTechnology.Belcorp.ePlanning.SharedLibraries.Extensions
{
    public static class StringExtensions
    {
        public static string Left(this string s, int length)
        {
            length = Math.Max(length, 0);

            return s.Length > length ? s.Substring(0, length) : s;
        }

        public static string Right(this string s, int length)
        {
            length = Math.Max(length, 0);

            return s.Length > length ? s.Substring(s.Length - length, length) : s;
        }

        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        public static bool ToBoolean(this string s)
        {
            return bool.Parse(s);
        }
    }
}
