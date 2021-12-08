using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankh_Morpork.NPCs
{
    public class Thief : IThief
    {
        public Roles Role { get; private set; }
        public double Fee { get; set; } = 10;
        public Thief(Roles role)
        {
            this.Role = role;
        }

        public Thief() { }
        public void Appear()
        {
            Console.Write($"You meet: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Role);
            Console.ResetColor();
            Console.WriteLine($"You need to pay: {Fee}$ fee.");
        }
    }
}
