using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork.NPCs;

namespace Ankh_Morpork.Guild
{
    public class GuildOfFools : IGuild
    {
        public double AmountOfMoneyForGuildMember { get; set; }
        
        private static GuildOfFools guildOfFools;
        private IFool fool;

        public static GuildOfFools GeGuildOfFools()
        {
            if (guildOfFools == null)
                guildOfFools = new GuildOfFools();
            else
                return guildOfFools;

            return guildOfFools;
        }
        public GuildOfFools()
        {
            fool = CreateGuildMember();
            AmountOfMoneyForGuildMember = Salary();
        }
        public IFool CreateGuildMember()
        {
            Fools flevel = GetFoolLevel();
            return new Fool(flevel, Roles.Fool);
        }
        public void MeetGuildMember()
        {
            fool.Appear();
        }

        public double Salary()
        {
            return fool.Salary();
        }

        public void UpdateMembersStatus()
        {
            fool.SetNewFool(GetFoolLevel());
            AmountOfMoneyForGuildMember = fool.Salary();
        }
        private Fools GetFoolLevel()
        {
            Random rnd = new Random();
            switch (rnd.Next(1, 10))
            {
                case 1:
                    return Fools.Muggins;
                case 2:
                    return Fools.Gull;
                case 3:
                    return Fools.Dupe;
                case 4:
                    return Fools.Butt;
                case 5:
                    return Fools.Fool;
                case 6:
                    return Fools.Tomfool;
                case 7:
                    return Fools.StupidFool;
                case 8:
                    return Fools.ArchFool;
                case 9:
                    return Fools.CompleteFool;
                default:
                    return Fools.CompleteFool;
            }
        }
    }
}
