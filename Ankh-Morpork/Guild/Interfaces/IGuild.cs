using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankh_Morpork.Guild
{
    public interface IGuild
    {
        public void UpdateMembersStatus();
        public void MeetGuildMember();
        public double AmountOfMoneyForGuildMember { get; set; }

    }
}
