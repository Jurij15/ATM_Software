using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace ATM_Software.Cores.Common
{
    public static class Common
    {
        public static void OperaionComplete(string from, string operationName)
        {
            string text = "Operation " + operationName + "completed succesfully!";
            MessageBox.Show(text);
            Logger.LogSuccess(from , text);
        }
    }
}
