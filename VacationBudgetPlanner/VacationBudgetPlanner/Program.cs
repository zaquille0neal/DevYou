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

            string name = "Vin";
            string jpn = "Japan";
            string nz = "New Zealand";

            Console.WriteLine($"Greetings, {name}! Would you like to hit the NOS, pull that e-brake, and drift your way to {jpn} or {nz}?");

            Console.ReadLine();
        }
    }
}
