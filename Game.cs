using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roll_Game_2
{
    internal class Game
    {
        public Dice dice;
        public int maxAttempts;

        public Game(int maxAttempts)
        {
            this.maxAttempts = maxAttempts;
            dice = new Dice();
        }

        public void Start()
        {
            int randomNumber = dice.Roll();
            bool isCorrectGuess = false;
            int attemptsLeft = maxAttempts;

            Console.WriteLine("Dice rolled! Guess what number it shows in 3 tries.");

            while (!isCorrectGuess && attemptsLeft > 0)
            {
                Console.WriteLine("Enter a number (1-6): ");
                var userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int guess))
                {
                    if (guess < 1 || guess > 6)
                    {
                        Console.WriteLine("Please enter a number between 1 and 6.");
                        continue;
                    }


                     attemptsLeft--;

                    if (guess == randomNumber)
                    {
                        Console.WriteLine("You Win!");
                        isCorrectGuess = true;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Number");
                        if (attemptsLeft > 0)
                        {
                            Console.WriteLine($"Attempts remaining: {attemptsLeft}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            if (!isCorrectGuess)
            {
                Console.WriteLine($"You lost! The correct number was {randomNumber}.");
            }
        }
    }

   
}
