using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNum = 7; //new Random().Next(1,100);

            int GuessCount = 0;

            Console.WriteLine("Guess the Secret Number");
            Console.WriteLine("Enter a number between 1-100");

            while (GuessCount < 4)
            {
                int guess = int.Parse(Console.ReadLine());

                if (guess == secretNum )
                {
                    Console.WriteLine("Nice Guess! Can you get it twice though??");
                } 
                else if (guess < secretNum) {
                    Console.WriteLine("Aim higher");
                    GuessCount++;
                }
                else if (guess > secretNum) {
                    Console.WriteLine("Chill out, it aint that big");
                    GuessCount++;
                }
                
            }

        }
    }
}
