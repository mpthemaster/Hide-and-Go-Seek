using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HideAndGoSeek
{
    class Program
    {
        Location myCurrentLocation;
        static Room hallway;
        static Room stairwayToSecondFloor;
        static Room stairwayToBasement;
        static Room stairwayToAttic;
        static RoomWithHidingPlace bathroom;
        static RoomWithHidingPlace kitchen;
        static RoomWithHidingPlace livingroom;
        static RoomWithHidingPlace masterBedroom;
        static RoomWithHidingPlace basement;
        static RoomWithHidingPlace attic;
        static RoomWithHidingPlace kidsBedroom;
        static RoomWithHidingPlace guestBedroom;
        static Outside frontyard;
        static OutsideWithHidingPlace garage;
        static OutsideWithHidingPlace backyard;
        static Outside garden;

        static void Main(string[] args)
        {
            string userName;

            Introduction(out userName);
            CreateLocations();
        }

        /// <summary>
        /// Instantiates all the locations and sets their exits.
        /// </summary>
        private static void CreateLocations()
        {
            attic = new RoomWithHidingPlace("Attic", "a lot of old, dusty boxes.", "behind the boxes.");
            stairwayToAttic = new Room("Stairway to the Attic", "rickety old steps.");
            hallway = new Room("Hallway", "an ancient, antique rug.");
            bathroom = new RoomWithHidingPlace("Bathroom", "a gold-plated toilet.", "in the shower.");
            masterBedroom = new RoomWithHidingPlace("Master Bedroom", "a king-sized bed.", "in the walk-in closet.");
            kidsBedroom = new RoomWithHidingPlace("Kids' Bedroom", "a colorful room with a bunkbed.", "in the toy chest.");
            guestBedroom = new RoomWithHidingPlace("Guest Bedroom", "nothing unique here.", "under the bed.");
            stairwayToSecondFloor = new Room("Stairway to the 2nd Floor", "a crystal chandelier.");

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
                Console.Write("\nAre you ready? ");
                Console.Read();
            }
            Console.Clear();
            Console.WriteLine("Get ready!");
        }
    }
}
