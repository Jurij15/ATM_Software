using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ATM_Software.Common;
using System.Windows.Forms;
using ATM_Software.Common.Cores;
using System.IO;

namespace ATM_Software.Common.Functions
{
    public static class AdminFunctions
    {
        public static bool ChangeAccountValidation(string currentAcc, bool newValue)
        {
            string acc1 = File.ReadAllText(Locations.Account1Valid);
            string acc2 = File.ReadAllText(Locations.Account2Valid);
            string acc3 = File.ReadAllText(Locations.Account3Valid);
            string acc4 = File.ReadAllText(Locations.Account4Valid);

            if (currentAcc.Contains("1"))
            {
                File.Delete(Locations.Account1Valid);
                using (StreamWriter sw = File.CreateText(Locations.Account1Valid))
                {
                    if (newValue)
                    {
                        //if its true
                        sw.Write("true");
                    }
                    else if (!newValue)
                    {
                        //if its false
                        sw.Write("false");
                    }
                    sw.Close();
                }
            }
            else if (currentAcc.Contains("2"))
            {
                File.Delete(Locations.Account2Valid);
                using (StreamWriter sw = File.CreateText(Locations.Account2Valid))
                {
                    if (newValue)
                    {
                        //if its true
                        sw.Write("true");
                    }
                    else if (!newValue)
                    {
                        //if its false
                        sw.Write("false");
                    }
                    sw.Close();
                }
            }
            else if (currentAcc.Contains("3"))
            {
                File.Delete(Locations.Account3Valid);
                using (StreamWriter sw = File.CreateText(Locations.Account3Valid))
                {
                    if (newValue)
                    {
                        //if its true
                        sw.Write("true");
                    }
                    else if (!newValue)
                    {
                        //if its false
                        sw.Write("false");
                    }
                    sw.Close();
                }
            }
            else if (currentAcc.Contains("4"))
            {
                File.Delete(Locations.Account4Valid);
                using (StreamWriter sw = File.CreateText(Locations.Account4Valid))
                {
                    if (newValue)
                    {
                        //if its true
                        sw.Write("true");
                    }
                    else if (!newValue)
                    {
                        //if its false
                        sw.Write("false");
                    }
                    sw.Close();
                }
            }
            else
            {
                return false;
            }
            return false;
        }

        public static bool ChangeMoneyStat(string currentAcc, int amount)
        {
            return false; //for now
        }

        public static void CreateNewAccount()
        {
            string AccountFolderNumber;
            string AccountName;
            string AccountPIN;
            string AccountNumber;
            string IsValid;
            Console.WriteLine("Create Account Command");
            Console.WriteLine("Enter the new account folder Number:");
            string newNumber = Console.ReadLine();
            AccountFolderNumber = newNumber;
            Console.WriteLine("Enter the new account name:");
            AccountName = Console.ReadLine();
            Console.WriteLine("Enter the new account pin");
            AccountPIN = Console.ReadLine();
            Console.WriteLine("Enter the new account number");
            AccountNumber = Console.ReadLine();
            Console.WriteLine("Is the new account valid (true/false)");
            IsValid = Console.ReadLine();
            if (!IsValid.Contains("true") && !IsValid.Contains("false"))
            {
                //we just assign it false, you can change it later anyway
                IsValid = "false";
            }
            Console.WriteLine("Creating new account...");
            string FullNewAccountDirectory = Locations.AccountFolderBase + AccountFolderNumber;
            //actually create a account, will be used later
            if (!Directory.Exists(FullNewAccountDirectory))
            {
                Directory.CreateDirectory(FullNewAccountDirectory);
                //we just assume that if the directory doesnt exist the files dont too
                //TODO: Finish this
            }
        }
    }
}
