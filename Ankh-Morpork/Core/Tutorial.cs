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
            var path = @"..\..\..\Resources\Welcome.txt";

            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write($"{Environment.UserName} ");

            Console.ResetColor();

            ReadALLText(path);

            Console.WriteLine("\nPress any key to continue...");

            Console.ReadKey();

            Console.Clear();
        }

        public void Rules()
        {
            var path = @"..\..\..\Resources\Rules.txt";

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\t\tRules");

            Console.ResetColor();

            var str = File.ReadAllLines(path);

            ReadALLText(path);

            Console.WriteLine("\nPress any key to continue...");

            Console.ReadKey();

            Console.Clear();
        }
        private void ReadALLText(string path)
        {
            var str = File.ReadAllLines(path);
            foreach (var line in str)
            {
                Console.WriteLine(line);

            }
        }
    }
}
