using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Diagnostics;
using ATM_Software.Cores;

namespace ATM_Software.Functions
{
    public static class AccountNumberFunctions
    {
        public static string FindAccountByNumber(string accountNumber) //this will find the account from 1/2/3/4 based on the accountnumber
        {
            string acc1 = File.ReadAllText(Locations.Account1Number);
            string acc2 = File.ReadAllText(Locations.Account2Number);
            string acc3 = File.ReadAllText(Locations.Account3Number);
            string acc4 = File.ReadAllText(Locations.Account4Number);

            if (acc1 == accountNumber)
            {
                return "Account1";
            }
            else if (acc2 == accountNumber)
            {
                return "Account2";
            }
            else if (acc3 == accountNumber)
            {
                return "Account3";
            }
            else if (acc4 == accountNumber)
            {
                return "Account4";
            }
            else
            {
                return null;
            }
            return null;
        }
        public static string FindAccountByPIN(string accountPIN) //this will find the account from 1/2/3/4 based on the accountpin
        {
            string acc1 = File.ReadAllText(Locations.Account1PIN);
            string acc2 = File.ReadAllText(Locations.Account2PIN);
            string acc3 = File.ReadAllText(Locations.Account3PIN);
            string acc4 = File.ReadAllText(Locations.Account4PIN);

            if (acc1 == accountPIN)
            {
                return "Account1";
            }
            else if (acc2 == accountPIN)
            {
                return "Account2";
            }
            else if (acc3 == accountPIN)
            {
                return "Account3";
            }
            else if (acc4 == accountPIN)
            {
                return "Account4";
            }
            else
            {
                return null;
            }
            return null;
        }
    }
}
