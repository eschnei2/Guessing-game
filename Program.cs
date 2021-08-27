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
            Random ranN = new Random();
            int randomNum = ranN.Next(1, 101);
            bool done = false;
            int guessCount = 0;
            int guessAmount = 4;


            while (guessCount != guessAmount && done == false)

            if (parseAnswer == randomNum)
            {
                Console.WriteLine("You got it right!");
                done = true;
            }
            else {
                if(randomNum > parseAnswer){
                Console.WriteLine("WRONG WRONG WRONG!");
                guessCount++;
                Console.WriteLine("You have " + (4-guessCount) + " guesses left"  );
                Console.WriteLine("You guessed too low"+randomNum);
                }
                else{
                Console.WriteLine("WRONG WRONG WRONG!");
                guessCount++;
                Console.WriteLine("You have " + (4-guessCount) + " guesses left"  );
                Console.WriteLine("You guessed too high"+randomNum);
                }
                if(guessCount != guessAmount){
                parseAnswer = int.Parse(Console.ReadLine());
                }

            }

        }
    }
}
