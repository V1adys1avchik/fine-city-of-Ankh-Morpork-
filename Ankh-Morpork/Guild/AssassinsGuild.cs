using Ankh_Morpork.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ankh_Morpork.Guild
{
    public class AssassinsGuild : IGuild
    {
        public double AmountOfMoneyForGuildMember { get; set; }
        

        private static AssassinsGuild assassinsGuild;
        private List<IAssassin> assassins;//
        private bool Contract;

        public static AssassinsGuild GeAssassinsGuild()
        {
            if (assassinsGuild == null)
                assassinsGuild = new AssassinsGuild();
            else
                return assassinsGuild;

            return assassinsGuild;

        }
        public AssassinsGuild()
        {
            assassins = CreateGuildMembers().ToList();
            AmountOfMoneyForGuildMember = GetAvrgContractCost();
            Contract = false;
        }

        IEnumerable<IAssassin> CreateGuildMembers()
        {
            for (int i = 0; i < 10; i++)
            {
               yield return new Assassin(Roles.Assassin);
            }
        }

        public double GetAvrgContractCost()
        {
            return assassins.Select(x =>x.AvrgPrise()).Average();
        }
        public void UpdateMembersStatus()
        {
            foreach (var assassin in assassins)
            {
                assassin.UpdateStatus();
            }

            Contract = true;
            AmountOfMoneyForGuildMember = GetAvrgContractCost();
        }

        public bool GetAssassin(double reward)
        {
            if (reward <= 0)
                throw new ArgumentException();
            var temp = assassins.FirstOrDefault(a=>a.IsOcupied != true 
                                                   && (a.LowestReward <= reward && reward <= a.HighestReward));
            if (temp is null)
                return false;
            else
                return true;
        }
        public void MeetGuildMember()
        {
            if (!Contract)
            {
                Random rnd = new Random();

                IAssassin assassin = assassins[rnd.Next(0, 10)];

                assassin.GetWork();

                assassin.Appear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your assassin has successfully killed a competitor.");
                Console.ResetColor();
            }
            Contract = false;
        }

    }
}
