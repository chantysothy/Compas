using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compas.Helpers
{
    public static class ConfigDataTypeConverter
    {
        public static bool ConvertToBoolean(string Value)
        {
            bool result = false;
            if (Value.ToUpper() == "TRUE")
                result = true;
            if (Value.ToUpper() == "FALSE")
                result = false;
            return result;
        }

        public static float ConvertToFloat(string Value)
        {
            float result;
            result = (float)Convert.ToDouble(Value);
            return result;
        }
    }
}
