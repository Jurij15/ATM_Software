using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Software
{
    public static class CommandSyxtem
    {
        public static void Start()
        {
            Console.WriteLine("Enter a command:");
            string input = Console.ReadLine();

            while (input == input)
            {
                if (input.Contains(Commands.ChangeValidCommand))
                {
                    Console.WriteLine("tbd");
                }
            }
        }
    }
}
