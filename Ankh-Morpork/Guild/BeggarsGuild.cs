using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork.NPCs;

namespace Ankh_Morpork.Guild
{
    public class BeggarsGuild : IGuild
    {
        public double AmountOfMoneyForGuildMember { get; set; }
        
        private static BeggarsGuild beggarsGuild;

        private IBeggar beggar;

        public static BeggarsGuild GetBeggarsGuild()
        {
            if (beggarsGuild == null)
                beggarsGuild = new BeggarsGuild();
            else
                return beggarsGuild;

            return beggarsGuild;
        }
        public BeggarsGuild()
        {
            beggar = CreateGuildMember();
            AmountOfMoneyForGuildMember = GetCost();
        }

        public IBeggar CreateGuildMember()
        {
            Beggars blevel = GetBeggarLevel();
            return new Beggar(blevel, Roles.Beggar);
        }
        public void MeetGuildMember()
        {
            beggar.Appear();
        }
        public double GetCost()
        {
            return beggar.AmountOfWantedMoney();
        }
        public void UpdateMembersStatus()
        {
            beggar = CreateGuildMember();
            AmountOfMoneyForGuildMember = GetCost();
        }

        private Beggars GetBeggarLevel()
        {
            Random rnd = new Random();
            switch (rnd.Next(1, 12))
            {
                case 1:
                    return Beggars.Twitchers;
                case 2:
                    return Beggars.Droolers;
                case 3:
                    return Beggars.Dribblers;
                case 4:
                    return Beggars.Mumblers;
                case 5:
                    return Beggars.Mutterers;
                case 6:
                    return Beggars.WalkingAlongShouters;
                case 7:
                    return Beggars.DemandersofaChip;
                case 8:
                    return Beggars.CallOtherPeopleJimmy;
                case 9:
                    return Beggars.NeedAMeal;
                case 10:
                    return Beggars.NeedATea;
                case 11:
                    return Beggars.NeedABeer;
                default:
                    return Beggars.NeedABeer;
            }
        }
    }
}
