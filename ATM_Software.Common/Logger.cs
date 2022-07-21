using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Software.Common
{
    public static class Logger
    {
        public static void LogMessage(string from, string message)
        {
            Console.WriteLine("[.]" + "[" + from + "]" + message);
        }
        public static void LogError(string from, string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[-]" + "[" + from + "]" + message);
            Console.ResetColor();
        }
        public static void LogSuccess(string from, string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[+]" + "[" + from + "]" + message);
            Console.ResetColor();
        }
    }
}
