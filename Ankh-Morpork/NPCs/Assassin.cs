using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankh_Morpork.NPCs
{
    public class Assassin : IAssassin
    {
        public Roles Role { get; private set; }
        public int HighestReward { get; set; }
        public int LowestReward { get; set; }
        public bool YaZanyat { get; set; }  // Переименовать potom

        public Assassin(Roles role)
        {
            this.Role = role;
            SetRange();
            YaZanyat = false;
        }
        public Assassin()
        {
            SetRange();
            YaZanyat = false;
        }

        void SetRange()
        {
            var rnd = new Random();
            LowestReward = rnd.Next(2, 8);
            HighestReward = rnd.Next(LowestReward + 1, LowestReward + 11);
        }

        public void GetWork()
        {
            this.YaZanyat = true;
        }
        public void UpdateStatus()
        {
            var rnd = new Random();
            SetRange();

            YaZanyat = rnd.Next(0, 2) == 0 ? false : true;
        }

        public double AvrgPrise()
        {
            return HighestReward - LowestReward;
        }
        public void Appear()
        {
            Console.Write($"You meet: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Role);
            Console.ResetColor();
            Console.WriteLine("And he kill you.");
        }
    }
}
