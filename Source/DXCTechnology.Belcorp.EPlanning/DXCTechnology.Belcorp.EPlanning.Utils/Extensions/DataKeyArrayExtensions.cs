using System;
using System.Web.UI.WebControls;

namespace DXCTechnology.Belcorp.ePlanning.Utils.Extensions
{
    public static class DataKeyArrayExtensions
    {
        public static T ObtenerValor<T>(this DataKeyArray dataKeyArray, int fila, string nombreDataKey)
        {
            var datakeys = dataKeyArray[fila];
            if (datakeys == null)
            {
                throw new NullReferenceException("No existe ningún DataKeys en la fila seleccionada");
            }

            var dataKey = datakeys[nombreDataKey];
            if (dataKey == null)
            {
                throw new NullReferenceException("No existe ningún DataKey con dicho nombre");
            }

            if (dataKey is T)
            {
                return (T)dataKey;
            }

            try
            {
                return (T)Convert.ChangeType(dataKey, typeof(T));
            }
            catch (InvalidCastException)
            {
                return default(T);
            }
        }
    }
}
