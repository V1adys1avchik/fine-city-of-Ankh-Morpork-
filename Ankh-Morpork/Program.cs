using System;
using System.Globalization;
using System.IO;
using System.Threading;
using Ankh_Morpork.Core;

namespace Ankh_Morpork
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.StartNew();
        }
    }
}
