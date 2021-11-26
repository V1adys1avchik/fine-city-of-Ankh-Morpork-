using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork.Guild;

namespace Ankh_Morpork.Core
{
    public class MeetingResult
    {
        public static bool Inputter(double amount,Player player,IGuild guild)
        {
            int answer;
            if (guild == AssassinsGuild.GeAssassinsGuild())
            {
                Console.WriteLine($"Someone want to kill you\n" +
                                  $"Recomended money for contract is: {amount}$\n" +
                                  $"Will you sign contract?");
                Console.WriteLine("\nEnter: (1) for Skip or (2) to sign contract.");
                try
                {
                    answer = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine("You are to scary to even enter 1 or 2." +
                                      "\nSo u run awawy.");
                    answer = 1;
                }

                switch (answer)
                {
                    case 1:
                        guild.MeetGuildMember();
                        return false;
                    case 2:
                        return MakeContract(player, guild);
                    default:
                        Console.WriteLine("Wrong input... And know what? Assassin kill you :)");
                        return false;
                }

            }
            else
            {
                return UserChoice(amount,player,guild);
            }
        }

        private static bool UserChoice(double amount, Player player, IGuild guild)
        {
            int input = 2;

            guild.MeetGuildMember();
            Console.WriteLine("\nEnter: (1) for Skip or (2) to Accept.");

            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong input... Automatically choose 2");
                input = 2;
            }

            switch (guild)
            {
                case BeggarsGuild:
                    if (input == 2)
                    {
                        player.GetMoney(amount);
                        guild.UpdateMembersStatus();
                        return true;
                    }

                    Console.WriteLine("He chase you to death.");
                    return false;

                case GuildOfThieves:
                    if (input == 2)
                    {
                        player.GetMoney(amount);
                        guild.UpdateMembersStatus();
                        return true;
                    }

                    Console.WriteLine("They imprison you for years.");
                    return false;

                case GuildOfFools:
                    if (input == 2)
                    {
                        player.AddMoney(amount);
                        guild.UpdateMembersStatus();
                        return true;
                    }
                    return true;
                default:
                    return false;
            }


        }
        private static bool  MakeContract(Player player, IGuild guild)
        {
            var tempInfo = AssassinsGuild.GeAssassinsGuild();
            double reward = 0;

            Console.Write($"Pls Enter reward for Contract(recomended: {tempInfo.AmountOfMoneyForGuildMember} ): ");
            try
            {
                reward = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong input... So sad but assassin come and kill you");
                return false;
            }

            if (tempInfo.GetAssassin(reward))
            {
                if (player.GetMoney(reward))
                {
                    guild.UpdateMembersStatus();
                    guild.MeetGuildMember();
                    return true;
                }
                else
                {
                    return false;
                }
            }

            Console.WriteLine("There no one who can take contract :(...");
            guild.MeetGuildMember();
            return false;
        }
    }
}
