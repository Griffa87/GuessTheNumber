using System;
using System.Threading;

namespace GuessTheNumber
{

    public class Program
    {
        public static void Main()
        {
            //Initialising Random class and variables followed by introduction.
            var rand = new Random();
            int result = rand.Next(1, 100);
            int answer = 0;

            Console.WriteLine("Welcome to Guess The Number with Console!");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("I will think of a number between 1 and 100.");
            Console.WriteLine("\nCan you guess what it is? ");
            Console.WriteLine("\nPress any key to begin...");
            Console.WriteLine("-----------------------------------------");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choosing random number...");
            Thread.Sleep(5000);
            Console.ResetColor();
            Console.WriteLine("Enter a number and press <ENTER>");

            //Game logic.
            while (answer != result)
            {
                answer = Convert.ToInt32(Console.ReadLine());

                if (answer > result)
                {
                    Console.WriteLine("Lower");
                }
                else if (answer < result)
                {
                    Console.WriteLine("Higher");
                }
            }
            //Game closure
            Console.WriteLine("-----------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Well done! you guessed right.");
            Console.ResetColor();
            Console.WriteLine("Thanks for playing.");
            Console.WriteLine();
        }
    }
}
