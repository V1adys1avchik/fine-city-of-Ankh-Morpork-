using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork.NPCs.Intefaces;

namespace Ankh_Morpork.NPCs
{
    public interface IBeggar : INPC
    {
        public void SetNewBeggar(Beggars beggar);
        public double AmountOfWantedMoney();
    }
}
