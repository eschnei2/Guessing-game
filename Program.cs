using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a secret number between 1 and 100");

            string userAnswer = Console.ReadLine();
            int parseAnswer = int.Parse(userAnswer);
            int randomNum = 42;

            if (parseAnswer == randomNum)
            {
                Console.WriteLine("You got it right!");
            }
            else {
                Console.WriteLine("WRONG WRONG WRONG!");
            }


        }
    }
}
