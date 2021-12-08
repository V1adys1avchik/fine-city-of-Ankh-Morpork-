using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ankh_Morpork.Guild;

namespace Ankh_Morpork.Core
{
    public class Game
    {
        private Tutorial tutorial;
        private Player player;
        private Random rnd;
        public Game() { }

        public void StartNew()
        {
             tutorial = new Tutorial();

             player = new Player();

             rnd = new Random();

             IGuild guild;

            tutorial.Weclome();

            tutorial.Rules();

            while (player.Alive)
            {
                guild = GetGuid();
                if (guild == null)
                {
                    int luckyDayMoney = rnd.Next(1, 6);
                    player.AddMoney(luckyDayMoney);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Today is your lucky day! You found {luckyDayMoney}$");
                    Console.ResetColor();
                    player.ShowBalnace();
                }
                else
                {
                    if (MeetingResult.Inputter(guild.AmountOfMoneyForGuildMember,player,guild))
                    {
                        player.ShowBalnace();
                    }
                    else
                    {
                        player.Killed();
                        Console.WriteLine("You are dead...\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("End Game.");
                        Console.ResetColor();
                        break;
                    }
                }
                Console.WriteLine("\nGame process...\nPress any key.");

                Console.ReadKey();
                
                Console.Clear();
            }
        }

        private IGuild GetGuid()
        {
            switch (rnd.Next(1, 5))
            {
                case 1:
                    return AssassinsGuild.GeAssassinsGuild();
                case 2:
                    return BeggarsGuild.GetBeggarsGuild();
                case 3:
                    return GuildOfFools.GeGuildOfFools();
                case 4:
                    if (GuildOfThieves.thefts > 0)
                        return GuildOfThieves.GetGuildOfThieves();
                    else
                        return null;
                default:
                    return new GuildOfFools();
            }
        }
    }
}
