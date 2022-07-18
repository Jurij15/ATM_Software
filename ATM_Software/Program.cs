using System;
using ATM_Software.Windows;

namespace ATM_Software // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //console will be used as a logger, window will appear on start
            Console.WriteLine("Starting App...");
            Logger.LogMessage("APPInternal", "Starting Logger...");
            Logger.LogMessage("APPInternal", "Starting UI...");
            //Logger.LogError("TEST", "Error here...");
            LoginWindow login = new LoginWindow();
            login.ShowDialog();
        }
    }
}