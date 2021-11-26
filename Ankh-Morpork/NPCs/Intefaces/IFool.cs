using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankh_Morpork.NPCs
{
    public interface IFool
    {
        public void Appear();
        public void SetNewFool(Fools fool);
        public double Salary();
    }
}
