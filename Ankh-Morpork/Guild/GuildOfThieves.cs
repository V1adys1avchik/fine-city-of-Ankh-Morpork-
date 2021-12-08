using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork.NPCs;

namespace Ankh_Morpork.Guild
{
    public class GuildOfThieves : IGuild
    {
        public double AmountOfMoneyForGuildMember { get; set; }
        
        private static GuildOfThieves guildOfThieves;
        public static int thefts = 6;
        private IThief thief;

        public static GuildOfThieves GetGuildOfThieves()
        {
            if (guildOfThieves == null)
                guildOfThieves = new GuildOfThieves();
            else
                return guildOfThieves;

            return guildOfThieves;
        }
        public GuildOfThieves()
        {
            thief = CreateGuildMember();
            AmountOfMoneyForGuildMember = thief.Fee;
        }

        public void MeetGuildMember()
        {
            thefts--;
            thief.Appear();
        }

        public void UpdateMembersStatus()
        {
            thief = CreateGuildMember();
            AmountOfMoneyForGuildMember = thief.Fee;
        }

        private IThief CreateGuildMember()
        {
            return new Thief(Roles.Thief);
        }
    }
}
