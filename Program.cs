using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a difficutly 1 = easy, 2 = Medium, 3 = hard, 4 = cheater ");
            int guessAmount = 0;
            string difficulty = Console.ReadLine();
            int guessCount = 0;

            if(difficulty == "1"){
                guessAmount = 8;
            }
            else if(difficulty == "2"){
                guessAmount = 6;
            }
            else if(difficulty == "3"){
                guessAmount = 4;
            }
            else {
                guessAmount = -1;
            }
        


            Console.WriteLine("Guess a secret number between 1 and 100");

            string userAnswer = Console.ReadLine();
            int parseAnswer = int.Parse(userAnswer);
            Random ranN = new Random();
            int randomNum = ranN.Next(1, 101);
            bool done = false;


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
                Console.WriteLine("You have " + (guessAmount-guessCount) + " guesses left"  );
                Console.WriteLine("You guessed too low");
                }
                else{
                Console.WriteLine("WRONG WRONG WRONG!");
                guessCount++;
                Console.WriteLine("You have " + (guessAmount-guessCount) + " guesses left"  );
                Console.WriteLine("You guessed too high");
                }
                if(guessCount != guessAmount){
                Console.WriteLine("WRONG WRONG WRONG!");
                parseAnswer = int.Parse(Console.ReadLine());
                }

            }

        }
    }
}
