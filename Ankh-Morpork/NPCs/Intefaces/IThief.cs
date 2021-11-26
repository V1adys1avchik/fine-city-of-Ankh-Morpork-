using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankh_Morpork.NPCs
{
    public interface IThief
    {
        public void Appear();
        public double Fee { get; set; }
    }
}
