using System;

namespace Module3Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // ========================
            // Part 1: If/Else Statement
            // ========================
            Console.Write("Enter the animal's hunger level (1-10): ");
            int hungerLevel = int.Parse(Console.ReadLine());

            // Check hunger level using if-else
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
                Console.WriteLine("Tortoise: Slow and steady—I'll have some lettuce.");
            }

           
            // Part 2: Ternary Operator
            
            // Quick way to decide which animal sound to play
            string soundMessage = (hungerLevel >= 8) 
                ? "Listen to the Lion: Roar!" 
                : "Listen to the Monkey: Ooh ooh!";
            Console.WriteLine(soundMessage);

            // ============================
            // Part 3: Switch Statement
            // ============================
            Console.Write("\nEnter a day of the week (1 = Sunday, 7 = Saturday): ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday Fun Day: Free balloons for kids!");
                    break;
                case 2:
                    Console.WriteLine("Monkey Monday: Watch the monkeys swing around!");
                    break;
                case 3:
                    Console.WriteLine("Tortoise Tuesday: Slow races with our tortoises!");
                    break;
                case 4:
                    Console.WriteLine("Wildlife Wednesday: Learn about endangered species.");
                    break;
                case 5:
                    Console.WriteLine("Thrilling Thursday: Seniors get 10% off admission!");
                    break;
                case 6:
                    Console.WriteLine("Feeding Friday: Watch the zookeepers feed the animals.");
                    break;
                case 7:
                    Console.WriteLine("Safari Saturday: Take a mini-safari tour inside the zoo!");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                    break;
            }

            // End of program
            Console.WriteLine("\nThanks for visiting the Zoo Visitors App!");
        }
    }
}
