using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankh_Morpork
{
    public class Player
    {
        public double Money { get; private set; } = 100;
        public bool Alive { get;private set; }
        public Player(double money)
        {
            if (money < 0)
                throw new ArgumentException("Money can't be less than 0");
            this.Money = money;
            this.Alive = true;
        }

        public Player() { this.Alive = true; }

        public void Killed() //**
        {
            this.Alive = false;
        }
        public void ShowBalnace()
        {
            Console.Write("Your current amount of money: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Money}$");
            Console.ResetColor();
        }

        public void AddMoney(double money) //**
        {
            if (money < 0)
                throw new ArgumentException("Money can't be less than 0");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nYou earn {money}$\n");
            Console.ResetColor();
            this.Money += money;
        }

        public bool GetMoney(double money) //**
        {
            if (money < 0)
                throw new ArgumentException("Money can't be less than 0");
            if (Money - money <= 0)
            {
                this.Money = 0;
                Console.WriteLine("You are out of money...");
                ShowBalnace();
                Killed();
                return false;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nYou give away {money}$.\n");
            Console.ResetColor();
            this.Money -= money;
            return true;
        }
    }
}
