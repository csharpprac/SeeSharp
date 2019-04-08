using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            //Number Guessing Game

            //Instantiating a random number
            Random rand = new Random();
            int number = rand.Next(1, 11);

            Console.WriteLine("Welcome to number guessing game\nTell me your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi {0}", name);
            Console.WriteLine("Guess a number between 1 and 10");

            //Treating exception
            try
            {
                while (true)
                {
                    //User input
                    int userGuess = Convert.ToInt32(Console.ReadLine());

                    if (userGuess < number)
                    {
                        Console.WriteLine("Guess Higher");
                    }
                    else if (userGuess > number)
                    {
                        Console.WriteLine("Guess Lower");

                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                        break;
                    }

                }
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("That is not a number!", ex.Message);
               
            }

               
        }

        
    }
}
