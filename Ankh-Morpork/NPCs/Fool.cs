using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankh_Morpork.NPCs
{
    public class Fool : IFool
    {
        public Roles Role { get; private set; }
        public Fools FoolType { get; private set; }

        public Fool(Fools fool,Roles role)
        {
            this.Role = role;
            this.FoolType = fool;
        }

        public Fool() { }

        public void SetNewFool(Fools fool)
        {
            this.FoolType = fool;
        }

        public double Salary()
        {
            return (double)FoolType/100;
        }
        public void Appear()
        {
            Console.Write($"You meet: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Role);
            Console.ResetColor();
            Console.WriteLine($"It's your friend, and you can work like {FoolType}" +
                              $" and get paid: {(double)FoolType / 100}$.");
        }
    }
}
