using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double runningTotal = 0;

            while (true)
            {
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
                var entry = Console.ReadLine();

                if (entry.ToLower() == "quit" || entry == "q")
                {
                    break;
                }               
                try
                {
                    var minutes = double.Parse(entry);

                    if (minutes <= 0)
                    {
                        Console.WriteLine(minutes + " is not a valid number");
                        continue;
                    }
                    else if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothing I guess.");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Now your talkin'");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("Kicking butt!");
                    }
                    else
                    {
                        Console.WriteLine("Now you're just showing off!");
                    }
                    runningTotal = runningTotal + minutes;
                }
                catch(FormatException)
                {
                    Console.WriteLine("That is not valid input.");
                    continue;
                }
                    Console.WriteLine("You've exercised a total of " + runningTotal + " minutes!");
                    Console.ReadLine();                                      
            }
        }
    }
}
