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
        public static bool Login(string number, string pin)
        {
            /*
            var numbers = new List<string> {
                File.ReadAllText(Locations.Account1Number),
                File.ReadAllText(Locations.Account2Number),
                File.ReadAllText(Locations.Account3Number),
                File.ReadAllText(Locations.Account4Number)
            };
            var pins = new List<string>{
                File.ReadAllText(Locations.Account1PIN),
                File.ReadAllText(Locations.Account2PIN),
                File.ReadAllText(Locations.Account3PIN),
                File.ReadAllText(Locations.Account4PIN)
            };
            numbers.ForEach(delegate (string name)
            {
                if (number != name)
                {
                    MessageBox.Show("Please check number and try again!");
                    Logger.LogError("UI", "Incorrect Number");
                }
                else if (number == name)
                {
                    pins.ForEach(delegate (string ppins)
                    {
                        if (pin != ppins)
                        {
                            MessageBox.Show("Please check PIN and try again!");
                            Logger.LogError("UI", "Incorrect PIN");
                        }
                        else if (pin == ppins)
                        {
                            LoginSucess();
                        }
                    });
                }
            });
            */
            /*
            if (number != File.ReadAllText(Locations.Account1Number))
            {
                MessageBox.Show("Please check number and try again!");
                Logger.LogError("UI", "Incorrect Number");
            }
            else if (number != File.ReadAllText(Locations.Account2Number))
            {
                MessageBox.Show("Please check number and try again!");
                Logger.LogError("UI", "Incorrect Number");
            }
            else if (number != File.ReadAllText(Locations.Account3Number))
            {
                MessageBox.Show("Please check number and try again!");
                Logger.LogError("UI", "Incorrect Number");
            }
            else if (number != File.ReadAllText(Locations.Account4Number))
            {
                MessageBox.Show("Please check number and try again!");
                Logger.LogError("UI", "Incorrect Number");
            }
            */
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
                    configs.CurrentAccount = AccountNumberFunctions.FindAccountByNumber(number);
                }
            }
            return false;
        }

        static void LoginSucess()
        {
            MessageBox.Show("tbd");
        }
    }
}
