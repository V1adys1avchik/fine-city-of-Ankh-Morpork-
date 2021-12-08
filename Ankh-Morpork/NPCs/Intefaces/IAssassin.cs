using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork.NPCs.Intefaces;

namespace Ankh_Morpork.NPCs
{
    public interface IAssassin : INPC
    {
        public void UpdateStatus();
        public void GetWork();
        public double AvrgPrise();
        public int HighestReward { get; set; }
        public int LowestReward { get; set; }
        public bool IsOcupied { get; set; }
    }
}
