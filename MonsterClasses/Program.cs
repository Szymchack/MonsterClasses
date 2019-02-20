using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcomeScreen();
            DisplayMenu();
            DisplayClosingScreen();
        }

        static SeaMonster InitializeSeaMonster()
        {
            return new SeaMonster()
            {
                Id = 357,
                Name = "Suzy",
                Age = 478,
                HasGills = true,
                IsActive = true,
                SeaName = "Baltic Sea"

            };
        }

        static SpaceMonster InitializeSpaceMonster()
        {
            return new SpaceMonster()
            {
                Id = 300,
                Name = "Lettuce",
                Age = 478,
                IsActive = true,
                HasSpaceship = false
            };
        }

        static ForestMonster InitializeForestMonster()
        {
            return new ForestMonster()
            {
                Id = 400,
                Name = "Jody",
                Age = 178,
                IsActive = true,
                HasCave = false
            };
        }

        private static void DisplayMenu()
        {
            bool exitMenu = false;
            SeaMonster suzy = InitializeSeaMonster();
            SpaceMonster sid = InitializeSpaceMonster();


            do
            {
                DisplayHeader("Menu");
                Console.WriteLine("1) Display Monsters");
                Console.WriteLine("2) Exit");
                Console.WriteLine("Enter Choice");
                int userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        DisplayMonsterInfoScreen(suzy, sid);
                        break;
                    case 2:
                        exitMenu = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice.");
                        DisplayContinuePrompt();
                        break;

                }

            } while (!exitMenu);
        }

        static void DisplayMonsterInfoScreen(SeaMonster seaMonster, SpaceMonster spaceMonster, ForestMonster forestMonster)
        {
            DisplayHeader("Monster Information");

            DisplaySeaMonster(seaMonster);
            Console.WriteLine();
            DisplaySpaceMonster(spaceMonster);
            Console.WriteLine();
            DisplayForestMonster(forestMonster);
            Console.WriteLine();

            DisplayContinuePrompt();
        }
        static void DisplaySeaMonster(SeaMonster seaMonster)
        {
            Console.WriteLine($"Id: {seaMonster.Id}");
            Console.WriteLine($"Name: {seaMonster.Name}");
            Console.WriteLine($"Age: {seaMonster.Age}");
            Console.WriteLine($"Active: {(seaMonster.IsActive ? "Yes" : "No")}");

            seaMonster.Greeting();

        }
        private static void DisplaySpaceMonster(SpaceMonster spaceMonster)
        {
            Console.WriteLine($"Id: {spaceMonster.Id}");
            Console.WriteLine($"Name: {spaceMonster.Name}");
            Console.WriteLine($"Age: {spaceMonster.Age}");
            Console.WriteLine($"Active: {(spaceMonster.IsActive ? "Yes" : "No")}");

            spaceMonster.Greeting();

            Console.WriteLine($"You attack {spaceMonster.Name} and they {spaceMonster.MonsterBattleResponse()}.");
        }

        private static void DisplayForestMonster(ForestMonster forestMonster)
        {
            Console.WriteLine($"Id: {forestMonster.Id}");
            Console.WriteLine($"Name: {forestMonster.Name}");
            Console.WriteLine($"Age: {forestMonster.Age}");
            Console.WriteLine($"Active: {(forestMonster.IsActive ? "Yes" : "No")}");

            forestMonster.Greeting();

            Console.WriteLine($"You attack {forestMonster.Name} and they {forestMonster.MonsterBattleResponse()}.");





        }
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press Any Key To Continue.");
            Console.ReadKey();
        }

        static void DisplayWelcomeScreen()
        {
            Console.Clear();

            Console.WriteLine("\n\nWelcome\n\n");

            DisplayContinuePrompt();
        }

        static void DisplayGreetingScreen()
        {
            DisplayHeader("Greeting Screen");

            Console.WriteLine("Hello Welcome to My Screen");
            DisplayContinuePrompt();
        }

        static void DisplayHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(headerText);
            Console.WriteLine();
        }

        static void DisplayClosingScreen()
        {
            DisplayHeader("Closing Screen");
            Console.WriteLine("It's Been Real.");
            DisplayContinuePrompt();

        }
    }
}
