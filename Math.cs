using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            //temperature conversion
            Console.WriteLine("Good evening, Mr. Freeze. Congratulations on your impending Canadian takeover! Please enter the temperature in\r\nFahrenheit to begin the conversion to Celsius!");
            double f = double.Parse(Console.ReadLine());
            double c = ((f - 32) * 5 / 9);
            Console.WriteLine($"Thank you, Victor! {f} degrees in Gotham City is equal to {c} degrees in Toronto!");
            Console.WriteLine("Obivously, once your takeover is complete, sales tax will be a thing of the past. For the time being though, \r\nplease press ENTER to open the sales tax calculator");
            Console.ReadLine();

            //sales tax calculator
            Console.WriteLine("Please enter the price of the liquid nitrogen before tax!");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the current sales tax rate percentage for this area?");
            double tax = double.Parse(Console.ReadLine());
            double taxPercent = (tax * .01);
            double totalCost = (price + (taxPercent * price));
            Console.WriteLine($"The total cost of the precious liquid nitrogen for your freeze gun after tax is {totalCost:c} Canadian dollars!");
            Console.WriteLine("Hey, you maybe be a supervillain but you aren't a MONSTER! Please press ENTER to open the tip calculator");
            Console.ReadLine();

            //tip calculator
            Console.WriteLine("Man, that poutine was great and the delivery was top notch! How much was the bill?");
            double bill = double.Parse(Console.ReadLine());
            Console.WriteLine("What percentage would you like to tip? Remember, the poutine was GREAT!");
            double tip = double.Parse(Console.ReadLine());
            double tipPercent = (tip * .01);
            double totalBill = (bill + (tipPercent * bill));
            Console.WriteLine($"The total cost of that DELICIOUS poutine including tip comes out to {totalBill:c}. I bet Bruce Wayne doesn't even \r\ntip that much!");
            Console.WriteLine("Ugh, the Legion of Doom is coming into town and you know they're going to want to grab dinner. Getting dinner with \r\nthose cheapskates always ends up with you paying the most! Press ENTER to open the bill divider!");
            Console.ReadLine();

            //bill divider
            Console.WriteLine("Okay, I KNOW Penguin drank way more than everyone else but WHATEVER, that's besides the point. How much was the bill \r\naltogether?");
            double dinnerBill = double.Parse(Console.ReadLine());
            Console.WriteLine("And how many supervillains, including yourself, are going to be splitting the bill?");
            int party = Int32.Parse(Console.ReadLine());
            double splitBill = (dinnerBill / party);
            Console.WriteLine($"Each person will owe {splitBill:c}. Also, let Penguin know he's getting the deal of a LIFETIME!");
            Console.WriteLine("Alright, that's all I got for ya today, Mr. Freeze. Press ENTER to exit.");

        }
    }
}
