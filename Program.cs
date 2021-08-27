using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNum = new Random().Next(1,101);

            int GuessCount = 0;
            int Difficulty = 0;
            
            Console.WriteLine("Enter Difficutly: 1-4");
            while (Difficulty == 0)
            {
                switch(int.Parse(Console.ReadLine()))
                    {
                        case 1: 
                            Difficulty = 1;
                            GuessCount = 8;
                            Console.WriteLine("You've Selected Easy. You have 8 guesses");
                            break;
                        case 2: 
                            Difficulty = 2;
                            GuessCount = 6;
                            Console.WriteLine("You've Selected Medium. You have 6 guesses");
                            break;
                        case 3: 
                            Difficulty = 3;
                            GuessCount = 4;
                            Console.WriteLine("You've Selected Hard. You have 4 guesses");
                            break;
                        case 4:
                            Difficulty = 4;
                            GuessCount = 101;
                            Console.WriteLine("You're a little cheater aren't you?");
                            break;
                        default: 
                            Console.WriteLine("Please select dificulty 1-3");
                            break;
                    }
            }

            Console.WriteLine("Guess the Secret Number");
            Console.WriteLine($"Enter a number between 1-100 you have {GuessCount} guesses");
            
            int guess = int.Parse(Console.ReadLine());

            while (GuessCount > 1)
            {
                if (guess == secretNum) 
                    {
                        Console.WriteLine("You Got it!");
                        break;
                    }
                else
                    {
                        string HighLowString = "too high";
                        string GuessString = "guesses";
                        if ((GuessCount) == 1)
                        {
                            GuessString = "guess";
                        }
                        if (guess < secretNum)
                        {
                            HighLowString = "too low";
                        }
                        Console.WriteLine($"Sorry, {guess} is {HighLowString}. You have {GuessCount -1} {GuessString} left, Please Try again");
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
