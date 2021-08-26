using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNum = 7; //new Random().Next(1,100);

            Console.WriteLine("Guess the Secret Number");
            Console.WriteLine("Enter a number between 1-100");

            int guess = int.Parse(Console.ReadLine());

            if (guess == secretNum )
            {
                Console.WriteLine("Nice Guess! Can you get it twice though??");
            } 
            else {
                Console.WriteLine("Lol, not even close! Try again?");
            }


        }
    }
}
