using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ATM_Software.Common.Cores;

namespace ATM_Software.Common.Functions
{
    public static class AccountMoneyFunctions
    {
        public static void DepositMoney(string cAccount, int amount)
        {
            //get  the current amount of money on the account
            int currentstat = Int32.Parse(AccountGeneralFunctions.GetAccountMoneyStat(cAccount));
            //use maths to get the new stat (maybe move to a different class idk)
            int newstat = currentstat + amount;
            //delete the current stat in file
            string line = null;
            string deleteline = currentstat.ToString();
            using (StreamReader reader = new StreamReader(AccountGeneralFunctions.GetAccountMoneyStatFile(cAccount)))
            {
                using (StreamWriter writer = new StreamWriter(AccountGeneralFunctions.GetAccountMoneyStatFile(cAccount)))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (string.Compare(line, deleteline) == 0)
                            continue;
                        writer.WriteLine(line);
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter(AccountGeneralFunctions.GetAccountMoneyStatFile(cAccount)))
            {
                sw.Write(newstat.ToString());
                sw.Close();
            }
           Common.Cores.Common.OperationComplete("CoreFunctions", "DepositMoney");
        }
        public static void WithDrawalMoney(string cAccount, int amount)
        {
            //get  the current amount of money on the account
            int currentstat = Int32.Parse(AccountGeneralFunctions.GetAccountMoneyStat(cAccount));
            //use maths to get the new stat (maybe move to a different class idk)
            int newstat = currentstat - amount;
            //delete the current stat in file
            string line = null;
            string deleteline = currentstat.ToString();
            using (StreamReader reader = new StreamReader(AccountGeneralFunctions.GetAccountMoneyStatFile(cAccount)))
            {
                using (StreamWriter writer = new StreamWriter(AccountGeneralFunctions.GetAccountMoneyStatFile(cAccount)))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (string.Compare(line, deleteline) == 0)
                            continue;
                        writer.WriteLine(line);
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter(AccountGeneralFunctions.GetAccountMoneyStatFile(cAccount)))
            {
                sw.Write(newstat.ToString());
                sw.Close();
            }
            Common.Cores.Common.OperationComplete("CoreFunctions", "DepositMoney");
        }
        public static int GetMoneyStatNumber(string cAccount)
        {
            int stat = Int32.Parse(AccountGeneralFunctions.GetAccountMoneyStat(cAccount));
            return stat;
        }
    }
}
