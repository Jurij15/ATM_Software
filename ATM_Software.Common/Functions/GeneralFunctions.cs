using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Software.Common.Functions
{
    public static  class GeneralFunctions
    {
        public static string GetCurrentDateTime()
        {
            return DateTime.Now.ToString();
        }
    }
}
