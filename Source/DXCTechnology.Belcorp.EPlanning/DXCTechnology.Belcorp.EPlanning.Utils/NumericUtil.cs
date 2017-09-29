using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXCTechnology.Belcorp.ePlanning.SharedLibreries
{
    public static class NumericUtil
    {

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

    }
}
