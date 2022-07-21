using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ATM_Software.Common.Cores
{
    public static class Common
    {
        public static void OperationComplete(string from, string operationName)
        {
            string text = "Operation " + operationName + "completed succesfully!";
            System.Windows.Forms.MessageBox.Show(text);
            Logger.LogSuccess(from, text);
        }
    }
}
