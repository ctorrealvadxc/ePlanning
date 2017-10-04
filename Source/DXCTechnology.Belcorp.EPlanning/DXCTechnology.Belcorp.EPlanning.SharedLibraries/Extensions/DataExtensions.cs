using System;
using System.Collections.Generic;
using System.Data;

namespace DXCTechnology.Belcorp.ePlanning.SharedLibraries.Extensions
{
    public static class DataExtensions
    {
        public static T ToEntity<T>(this IDataReader dr)
        {
            var obj = default(T);
            var propertyInfos = typeof(T).GetProperties();
            while (dr.Read())
            {
                obj = Activator.CreateInstance<T>();
                for (var i = 0; i < dr.FieldCount; i++)
                {
                    foreach (var prop in propertyInfos)
                    {
                        if (!string.Equals(prop.Name, dr.GetName(i), StringComparison.CurrentCultureIgnoreCase)) continue;

                        if (!Equals(dr[prop.Name], DBNull.Value))
                            prop.SetValue(obj, dr[prop.Name], null);
                        break;
                    }
                }
            }
            return obj;
        }

        public static List<T> ToList<T>(this IDataReader dr)
        {
            var lst = new List<T>();
            var propertyInfos = typeof(T).GetProperties();

            while (dr.Read())
            {
                var obj = Activator.CreateInstance<T>();
                for (var i = 0; i < dr.FieldCount; i++)
                {
                    foreach (var prop in propertyInfos)
                    {
                        if (!string.Equals(prop.Name, dr.GetName(i), StringComparison.CurrentCultureIgnoreCase)) continue;

                        if (!Equals(dr[prop.Name], DBNull.Value))
                            prop.SetValue(obj, dr[prop.Name], null);
                        break;
                    }
                }
                lst.Add(obj);
            }
            return lst;
        }
    }
}
