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
        public static string LoginV2(string number, string pin)
        {
            if (number == File.ReadAllText(Locations.Account1Number) && pin == File.ReadAllText(Locations.Account1PIN))
            {
                configs.CurrentAccount = AccountNumberFunctions.FindAccountByNumber(number);
                LoginSucess();
            }
            else if (number == File.ReadAllText(Locations.Account2Number) && pin == File.ReadAllText(Locations.Account2PIN))
            {
                configs.CurrentAccount = AccountNumberFunctions.FindAccountByNumber(number);
                LoginSucess();
            }
            else if (number == File.ReadAllText(Locations.Account3Number) && pin == File.ReadAllText(Locations.Account3PIN))
            {
                configs.CurrentAccount = AccountNumberFunctions.FindAccountByNumber(number);
                LoginSucess();
            }
            else if (number == File.ReadAllText(Locations.Account4Number) && pin == File.ReadAllText(Locations.Account4PIN))
            {
                configs.CurrentAccount = AccountNumberFunctions.FindAccountByNumber(number);
                LoginSucess();
            }
            else
            {
                MessageBox.Show("Please check creditentials and try again!");
                Logger.LogError("ULOGIN", "Incorrect Credits!");
            }
            return null;
        }
        public static bool Login(string number, string pin)
        {
            //this needs to be redone, since any account can have any password atm, will fix it later
            if (number != File.ReadAllText(Locations.Account1Number) && number != File.ReadAllText(Locations.Account2Number) && number != File.ReadAllText(Locations.Account3Number) && number != File.ReadAllText(Locations.Account4Number))
            {
                MessageBox.Show("Please check number and try again!");
                Logger.LogError("ULOGIN", "Incorrect Number");
            }
            else 
            {
                if (pin != File.ReadAllText(Locations.Account1PIN) && pin != File.ReadAllText(Locations.Account2PIN) && pin != File.ReadAllText(Locations.Account3PIN) && pin != File.ReadAllText(Locations.Account4PIN))
                {
                    MessageBox.Show("Please check PIN and try again!");
                    Logger.LogError("ULOGIN", "Incorrect PIN");
                }
                else
                {
                    LoginSucess();
                    //configs.CurrentAccount = AccountNumberFunctions.FindAccountByNumber(number);
                }
            }
            return false;
        }

        static void LoginSucess()
        {
            if (configs.CurrentAccount == null)
            {
                MessageBox.Show("CurrentAccount is null, please restart the app");
                Logger.LogError("ULOGIN", "CurrentAccount is NULL!");
                Environment.Exit(0);
            }
            MessageBox.Show("tbd");
        }
    }
}
