using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start Here
            string appName = "Number Gusser";
            string appVersion = "1.0.0";
            string appAuthor = "Snehal Gurav";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Red;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();

            //Ask users name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            //Init correct number
            int correctNumber = 7;

            // Init guess var
            int guess = 0;
            //Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");


            //Make sure its a number
            if (!int.TryParse(inputName, out guess))
            {
                //Change text color
                Console.ForegroundColor = ConsoleColor.Yellow;

                //Tell user its not a number
                Console.WriteLine("Please enter number");

                //Reset text color
                Console.ResetColor();
            }

            // While guess is not correct
            while (guess !=correctNumber){
                //Get users input
                string input = Console.ReadLine();
                //Cast to int and put in guess
                guess = Int32.Parse(input);

                //Match guess to correct number
                if(guess != correctNumber) { 
                    //Change text color
                    Console.ForegroundColor= ConsoleColor.Yellow;

                    //Tell user its wrong number
                    Console.WriteLine("Wrong number, please try again");

                    //Reset text color
                    Console.ResetColor();
                }

            }

            //Output success message
            //Change text color
            Console.ForegroundColor = ConsoleColor.Cyan;

            //Tell user its the right number
            Console.WriteLine("You are CORRECT!!!");

            //Reset text color
            Console.ResetColor();
        }
    }
}
