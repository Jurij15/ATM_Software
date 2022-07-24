using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM_Software.Common.Cores;
using System.IO;

namespace ATM_Software.Common.Functions
{
    public static class AccountTransactionsFunctions
    {
        public static string GetAccountTransactions(string cAccount) //returns a string with all transactions
        {
            string acc1 = File.ReadAllText(Locations.Account1Transactions);
            string acc2 = File.ReadAllText(Locations.Account2Transactions);
            string acc3 = File.ReadAllText(Locations.Account3Transactions);
            string acc4 = File.ReadAllText(Locations.Account4Transactions);

            if (cAccount.Contains("1"))
            {
                return acc1;
            }
            else if (cAccount.Contains("2"))
            {
                return acc2;
            }
            else if (cAccount.Contains("3"))
            {
                return acc3;
            }
            else if (cAccount.Contains("4"))
            {
                return acc4;
            }

            return null;
        }

        public static bool AddAccountTransactions(string cAccount, string transaction)
        {
            string acc1 = Locations.Account1Transactions;
            string acc2 = Locations.Account2Transactions;
            string acc3 = Locations.Account3Transactions;
            string acc4 = Locations.Account4Transactions;

            string text = "[" + GeneralFunctions.GetCurrentDateTime() + "]" + transaction;

            if (cAccount.Contains("1"))
            {
                using (StreamWriter sw = new StreamWriter(acc1))
                {
                    sw.WriteLine(text);
                    sw.Close();
                }
                return true;
            }
            else if (cAccount.Contains("2"))
            {
                using (StreamWriter sw = new StreamWriter(acc2))
                {
                    sw.WriteLine(text);
                    sw.Close();
                }
                return true;
            }
            else if (cAccount.Contains("3"))
            {
                using (StreamWriter sw = new StreamWriter(acc3))
                {
                    sw.WriteLine(text);
                    sw.Close();
                }
                return true;
            }
            else if (cAccount.Contains("4"))
            {
                using (StreamWriter sw = new StreamWriter(acc4))
                {
                    sw.WriteLine(text);
                    sw.Close();
                }
                return true;
            }

            return false;
        }
    }
}
