using System;

namespace ZooAnimalsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the animal's hunger level (1-10): ");
            int hungerLevel = int.Parse(Console.ReadLine());
            // Add code here for if else statement
            if (hungerLevel >= 8)
            {
                Console.WriteLine("Lion: Roar! I need a big meal!");
            }
            else if (hungerLevel >= 5)
            {
                Console.WriteLine("Monkey: Ooh ooh! I'll take some bananas.");
            }
            else
            {
                Console.WriteLine("Tortoise: Slow and steady-I'll have some lettuce.");
            }

            // Terenary Operator (Animal Sounds)
            string sounds = (hungerLevel >= 8) ? "Listen to the Lion: Roar!" : "Listen to the Monkey: Ooh ooh!";


            // Get input from the user for the day
            Console.WriteLine("Enter a number (1-7) to represent the day of the week. Sunday starts at 1: ");
            int day = int.Parse(Console.ReadLine());
            // Switch Statement (Zoo Days)
            switch (day)
            {
                case 1:
                    Console.WriteLine("Today is seal show Sunday!");
                    break;
                case 2:
                    Console.WriteLine("It's Monkey madness Monday!");
                    break;
                case 3:
                    Console.WriteLine("Join us for Tortoise Tuesday!");
                    break;
                case 4:
                    Console.WriteLine("Half off admission price Wednesdays!");
                    break;
                case 5:
                    Console.WriteLine("Seniors get 10% off admission on Thursdays!");
                    break;
                case 6:
                    Console.WriteLine("Today is free food Friday!!");
                    break;
                case 7:
                    Console.WriteLine("Saturday fun day!!");
                    break;
            }

        }
    }
}