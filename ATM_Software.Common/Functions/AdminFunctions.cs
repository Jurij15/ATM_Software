using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ATM_Software.Common;
using System.Windows.Forms;
using ATM_Software.Common.Cores;

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
    }
}
