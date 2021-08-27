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
            bool done = false;
            int guessCount = 1;


            while (guessCount < 4 && done == false)

            if (parseAnswer == randomNum)
            {
                Console.WriteLine("You got it right!");
                done = true;
            }
            else {
                Console.WriteLine("WRONG WRONG WRONG!");
                guessCount++;
                Console.WriteLine("You have guessed " + guessCount + " times. Try again." );
                parseAnswer = int.Parse(Console.ReadLine());
            }


        }
    }
}
