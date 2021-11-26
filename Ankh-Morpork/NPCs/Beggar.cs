using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankh_Morpork.NPCs
{
    public class Beggar : IBeggar
    {
        public Roles Role { get; private set; }
        public Beggars BeggarType { get; private set; }

        public Beggar(Beggars beggar,Roles role)
        {
            this.Role = role;
            this.BeggarType = beggar;
        }

        public Beggar() { }

        public void SetNewBeggar(Beggars beggar)
        {
            this.BeggarType = beggar;
        }

        public double AmountOfWantedMoney()
        {
            return (double)BeggarType/100;
        }
        public void Appear()
        {
            var amount = (double)BeggarType == 0 ? 0 : (double)BeggarType / 100;
            if (amount != 0)
            {
                Console.Write($"You meet: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Role);
                Console.ResetColor();
                Console.WriteLine($"He wants: {amount}$.");

            }
            else
            {
                Console.Write($"You meet: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Role);
                Console.ResetColor();
                Console.WriteLine("He wants Beer.");
            }

        }
    }
}
