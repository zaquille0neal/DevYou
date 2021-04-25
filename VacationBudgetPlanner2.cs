using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dominic Toretto's Diesel-powered Vacation Budget Planner! Could I please get your name?");
            string name = (Console.ReadLine());
            string destination1 = "Japan";
            string destination2 = "New Zealand";

            Console.WriteLine($"Greetings, {name}! Would you like to hit the NOS, pull that e-brake, and drift your way to {destination1} or {destination2}? Please \r\nnote that {destination1} is currently overrun with murderous snow monkeys and you WILL DIE if you choose to go there!");
            string destinationChoice = (Console.ReadLine());
            Console.WriteLine($"How many days would you like to spend in {destinationChoice}?");
            int days = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"How much spending money would you like to bring to {destinationChoice}?");
            double money = Double.Parse(Console.ReadLine());
            double dailyMoney = (money / days);
            Console.WriteLine($"If you are going to be spending {days} days with a grand total of {money:c} you can spend {dailyMoney:c} per day!");
            Console.WriteLine("Please press ENTER to exit.");
            Console.ReadLine();




            Console.ReadLine();
        }
    }
}
