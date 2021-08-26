using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNum = new Random().Next(1,100);

            int GuessCount = 3;
            
            Console.WriteLine("Guess the Secret Number");
            Console.WriteLine("Enter a number between 1-100 you have 4 guesses");
            
            int guess = int.Parse(Console.ReadLine());
            
            while (GuessCount < 4)
            {
                if (guess == secretNum) 
                {
                    Console.WriteLine("You Got it");
                    break;
                }
                else
                {
                    string HighLowString = "too high";
                    string GuessString = "guesses";
                    if ((GuessCount) == 2)
                    {
                        GuessString = "guess";
                    }
                    if (guess < secretNum)
                    {
                        HighLowString = "too low";
                    }
                    Console.WriteLine($"Sorry {guess} is {HighLowString}. You have {GuessCount} {GuessString} left, Please Try again");
                    guess = int.Parse(Console.ReadLine());
                    GuessCount--;
                }
                if (GuessCount == 0)
                    {
                        break;
                    }
            }
            if (guess != secretNum)
            {
                Console.WriteLine("Sorry, you're out of guesses");
            }
        }
    }
}
