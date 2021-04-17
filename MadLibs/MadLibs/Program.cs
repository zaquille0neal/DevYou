using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        { 
            string adj1 = "crisp";
            string noun1 = "grandma";
            string verbPast1 = "shoveled";
            string adverb1 = "blindly";
            string adj2 = "sour";
            string noun2 = "pig";
            string noun3 = "chicken";
            string adj3= "gangly";
            string verb1 = "race";
            string adverb2 = "violently";
            string verbPast2 = "floated";
            string adj4 = "puffy";

            Console.WriteLine($"Today I went to the zoo. I saw a {adj1} {noun1} jumping up and down in its tree. He {verbPast1} {adverb1} through the large tunnel that led to its {adj2} {noun2}. I got some peanuts and passed them through the cage to a gigantic gray {noun3} towering above my head. Feeding that animal made me hungry. I went to get a {adj3} scoop of ice cream. It filled my stomach. Afterwards I had to {verb1} {adverb2} to catch our bus. When I got home I {verbPast2} my mom for a {adj4} day at the zoo.");

            Console.ReadLine();
        


        }
    }
}
