using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ATM_Software.Common.Cores;
using ATM_Software.Common.Functions;
using System.Windows.Forms;

namespace ATM_Software.Common.Cores
{
    public static class LoginSystem
    {
        public static bool LoginV2(string number, string pin)
        {
            if (number == File.ReadAllText(Locations.Account1Number) && pin == File.ReadAllText(Locations.Account1PIN))
            {
                configs.CurrentAccount = AccountGeneralFunctions.FindAccountByNumber(number);
                LoginSucess();
                return true;
            }
            else if (number == File.ReadAllText(Locations.Account2Number) && pin == File.ReadAllText(Locations.Account2PIN))
            {
                configs.CurrentAccount = AccountGeneralFunctions.FindAccountByNumber(number);
                LoginSucess();
                return true;
            }
            else if (number == File.ReadAllText(Locations.Account3Number) && pin == File.ReadAllText(Locations.Account3PIN))
            {
                configs.CurrentAccount = AccountGeneralFunctions.FindAccountByNumber(number);
                LoginSucess();
                return true;
            }
            else if (number == File.ReadAllText(Locations.Account4Number) && pin == File.ReadAllText(Locations.Account4PIN))
            {
                configs.CurrentAccount = AccountGeneralFunctions.FindAccountByNumber(number);
                LoginSucess();
                return true;
            }
            else
            {
                Logger.LogError("ULOGIN", "Incorrect Credits!");
                return false;
                //MessageBox.Show("Please check creditentials and try again!");
            }
            return false;
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
        }
    }
}
