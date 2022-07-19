using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ATM_Software.Windows;
using System.IO;
using ATM_Software.Functions;

namespace ATM_Software.Cores
{
    public static class LoginSystem
    {
        //static LoginWindow login = new LoginWindow();
        static MainWindow main = new MainWindow();
        public static string LoginV2(string number, string pin)
        {
            if (number == File.ReadAllText(Locations.Account1Number) && pin == File.ReadAllText(Locations.Account1PIN))
            {
                configs.CurrentAccount = AccountGeneralFunctions.FindAccountByNumber(number);
                LoginSucess();
            }
            else if (number == File.ReadAllText(Locations.Account2Number) && pin == File.ReadAllText(Locations.Account2PIN))
            {
                configs.CurrentAccount = AccountGeneralFunctions.FindAccountByNumber(number);
                LoginSucess();
            }
            else if (number == File.ReadAllText(Locations.Account3Number) && pin == File.ReadAllText(Locations.Account3PIN))
            {
                configs.CurrentAccount = AccountGeneralFunctions.FindAccountByNumber(number);
                LoginSucess();
            }
            else if (number == File.ReadAllText(Locations.Account4Number) && pin == File.ReadAllText(Locations.Account4PIN))
            {
                configs.CurrentAccount = AccountGeneralFunctions.FindAccountByNumber(number);
                LoginSucess();
            }
            else
            {
                Logger.LogError("ULOGIN", "Incorrect Credits!");
                MessageBox.Show("Please check creditentials and try again!");
            }
            return null;
        }

        public static void LoginSucess()
        {
            if (configs.CurrentAccount == null)
            {
                Logger.LogError("ULOGIN", "CurrentAccount is NULL!");
                MessageBox.Show("CurrentAccount is null, please restart the app");
                Environment.Exit(0);
            }
            Logger.LogSuccess("ULOGIN", "Login Successfull!");
            //LoginWindow login = new LoginWindow();
            //MainWindow main = new MainWindow();
            //login.HideLogin();
            main.Show();
            //MessageBox.Show(configs.CurrentAccount);
        }
    }
}
