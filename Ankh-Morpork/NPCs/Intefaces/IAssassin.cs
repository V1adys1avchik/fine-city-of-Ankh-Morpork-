using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankh_Morpork.NPCs
{
    public interface IAssassin
    {
        public void Appear();
        public void UpdateStatus();
        public void GetWork();
        public double AvrgPrise();
        public int HighestReward { get; set; }
        public int LowestReward { get; set; }
        public bool YaZanyat { get; set; }
    }
}
