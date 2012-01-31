using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HideAndGoSeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;

            Introduction(out userName);
        }

        /// <summary>
        /// Introduces the player to the game.
        /// </summary>
        /// <param name="userName">The name of the user.</param>
        static void Introduction(out string userName)
        {
            string chosenOption = " ";

            Console.Write("Hello and welcome to Hide and Go Seek v0.001 . \nPlease enter your name: ");
            userName = Console.ReadLine();

            Console.Write("\nThank you, " + userName + ". Type \"start\" to begin or \"help\" for more information: ");
            chosenOption = Console.ReadLine();

            while (chosenOption != "start" && chosenOption != "help")
            {
                Console.Write("Please enter an acceptable command: ");
                chosenOption = Console.ReadLine();
            }

            if (chosenOption == "help")
            {
                Console.WriteLine("\nThe object of the game is  to find your opponent. When the game begins you need to count to 10 while your opponent hides. Then you must" +
                    " search throughout the   house in order to find him. Type \"goto\" plus the name of the location you want  to go to. I.E. goto kitchen . If you would " +
                    "like to check a hiding spot, type    \"check\".");
                Console.WriteLine("Are you ready? ");
                Console.Read();
            }
            Console.Clear();
            Console.WriteLine("Get ready!");
        }
    }
}
