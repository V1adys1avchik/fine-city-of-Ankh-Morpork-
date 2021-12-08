using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankh_Morpork.Core
{
    public class Tutorial
    {
        public void Weclome()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write($"{Environment.UserName} ");

            Console.ResetColor();

            var strWelcome = Properties.Resources.Welcome;

            Console.WriteLine(strWelcome);

            Console.WriteLine("\nPress any key to continue...");

            Console.ReadKey();

            Console.Clear();
        }

        public void Rules()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\t\tRules");

            Console.ResetColor();

            var strRules = Properties.Resources.Rules;

            Console.WriteLine(strRules);

            Console.WriteLine("\nPress any key to continue...");

            Console.ReadKey();

            Console.Clear();
        }
    }
}
