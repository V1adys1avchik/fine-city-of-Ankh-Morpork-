using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankh_Morpork.NPCs
{
    public interface IBeggar
    {
        public void Appear();
        public void SetNewBeggar(Beggars beggar);
        public double AmountOfWantedMoney();
    }
}
