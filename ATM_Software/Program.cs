using System;
using ATM_Software.Common;

namespace ATM_Software // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //console will be used as a logger, window will appear on start
            Console.WriteLine("This will be the admin console...");
        }
    }
}