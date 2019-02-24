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
            WelcomeScreen();
            InitializeSpaceMonster();
            InititializeSeaMonster();
            InitializeForestMonster();
            MainMenu();
            ClosingScreen();

        }

        static SeaMonster InititializeSeaMonster()
        {
            return new SeaMonster()
            {
                Id = 357,
                Name = "Suzy",
                Age = 478,
                HasGills = true,
                IsActive = true,
                SeaName = "Baltic Sea",
                Length = 100,
                Weight = 2500
            };
        }
        static SpaceMonster InitializeSpaceMonster()
        {
            return new SpaceMonster()
            {
                Id = 299,
                Name = "Lettuce",
                Age = 9,
                IsActive = true,
                Spaceship = false,
                Length = 1259,
                Galaxy = "Ford",
                CanBreathInSpace = true
            };
        }
        static ForestMonster InitializeForestMonster()
        {
            return new ForestMonster()
            {
                Id = 4,
                Name = "Jodi",
                Age = 2000,
                IsActive = true,
                Continent = "North America",
                Weight = 9000.01,
                HasLegs = false,
                EatsMeat = true
            };
        }

        //MAIN MENU
        static void MainMenu()
        {
            bool exitMenu = false;
            SeaMonster suzy = InititializeSeaMonster();
            SpaceMonster lettuce = InitializeSpaceMonster();
            ForestMonster jodi = InitializeForestMonster();
            ForestMonster forestMonster = new ForestMonster();

            do
            {

                DisplayHeader("\n\t\t\tMain Menu\n");
                Console.WriteLine();
                Console.WriteLine("\t1) Display Monsters");
                Console.WriteLine("\t2) Add Monster");
                Console.WriteLine("\t3) Edit Monster");
                Console.WriteLine("\t4) Exit");
                Console.WriteLine();
                Console.Write("Enter a Menu choice:");
                int userChoice;
                if (!int.TryParse(Console.ReadLine(), out userChoice))
                {
                    Console.WriteLine("Please only enter a number");
                    DisplayContinuePrompt();
                }
                else if (userChoice > 4)
                {
                    Console.WriteLine("Please only enter a number that is listed.");
                    DisplayContinuePrompt();
                }
                else
                {
                    switch (userChoice)
                    {
                        case 1:
                            DisplayMonsterInfoScreen(suzy, lettuce, jodi, forestMonster);
                            break;
                        case 2:
                            AddNewForestMonster(forestMonster);
                            break;
                        case 3:
                            EditMonsterInfo(suzy);
                            break;
                        case 4:
                            exitMenu = true;
                            break;
                        default:
                            Console.WriteLine("Please Enter a Menu Choice");
                            break;
                    }
                };
            } while (!exitMenu);

        }

        static SeaMonster EditMonsterInfo(SeaMonster suzy)
        {

            DisplayHeader("\t\tEdit SeaMonster\n");
            int userChoice;
            double userResponse;
            Console.WriteLine();
            Console.WriteLine("Edit SeaMonster Suzy");
            Console.WriteLine("Id: ");
            if (!int.TryParse(Console.ReadLine(), out userChoice))
            {
                Console.WriteLine("please enter a number");
                DisplayContinuePrompt();
            }
            else
            {
                userChoice = suzy.Id;
            }
            Console.WriteLine();
            Console.WriteLine("Name: ");
            suzy.Name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Age: ");
            if (!int.TryParse(Console.ReadLine(), out userChoice))
            {
                Console.WriteLine("please enter a number");
                DisplayContinuePrompt();
            }
            else
            {
                userChoice = suzy.Age;
            }
            Console.WriteLine();
            Console.WriteLine("Is Active? [YES or NO]: ");
            if (Console.ReadLine().ToUpper() == "YES")
            {
                suzy.IsActive = true;
            }
            else if (Console.ReadLine().ToUpper() == "NO")
            {
                suzy.IsActive = false;
            }
            else
            {
                Console.WriteLine("You did not enter a valid input");
                DisplayContinuePrompt();
            }
            Console.WriteLine();
            Console.WriteLine("Length: ");
            if (!int.TryParse(Console.ReadLine(), out userChoice))
            {
                Console.WriteLine("please enter a number");
                DisplayContinuePrompt();
            }
            else
            {
                userChoice = suzy.Length;
            }
            Console.WriteLine();
            Console.WriteLine("Weight: ");
            if (!double.TryParse(Console.ReadLine(), out userResponse))
            {
                Console.WriteLine("please enter a number");
                DisplayContinuePrompt();
            }
            else
            {
                userResponse = suzy.Weight;
            }
            Console.WriteLine();
            Console.WriteLine("Has Gills? [YES or NO]: ");
            if (Console.ReadLine().ToUpper() == "YES")
            {
                suzy.HasGills = true;
            }
            else if (Console.ReadLine().ToUpper() == "NO")
            {
                suzy.HasGills = false;
            }
            else
            {
                Console.WriteLine("You did not enter a valid input");
                DisplayContinuePrompt();
            }
            Console.WriteLine();
            Console.WriteLine("Sea Name: ");
            suzy.SeaName = Console.ReadLine();
            suzy.IsHappy();
            DisplayContinuePrompt();
            return suzy;



        }

        static ForestMonster AddNewForestMonster(ForestMonster forestMonster)
        {
            int userCoice;
            double userResponse;
            DisplayHeader("\t\tAdd New Land Monster\n");

            Console.WriteLine("Id: ");
            if (!int.TryParse(Console.ReadLine(), out userCoice))
            {
                Console.WriteLine("please enter a number");
                DisplayContinuePrompt();
            }
            else
            {
                userCoice = forestMonster.Id;
            }
            Console.WriteLine();
            Console.WriteLine("Name: ");
            forestMonster.Name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Age: ");
            if (!int.TryParse(Console.ReadLine(), out userCoice))
            {
                Console.WriteLine("please enter a number");
                DisplayContinuePrompt();
            }
            else
            {
                userCoice = forestMonster.Age;
            }
            Console.WriteLine();
            Console.WriteLine("Is Active? [YES or NO]: ");
            if (Console.ReadLine().ToUpper() == "YES")
            {
                forestMonster.IsActive = true;
            }
            else if (Console.ReadLine().ToUpper() == "NO")
            {
                forestMonster.IsActive = false;
            }
            else
            {
                Console.WriteLine("You did not enter a valid input");
                DisplayContinuePrompt();
            }
            Console.WriteLine();
            Console.WriteLine("Continent: ");
            forestMonster.Continent = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Has Legs? [YES or NO]: ");
            if (Console.ReadLine().ToUpper() == "YES")
            {
                forestMonster.HasLegs = true;
            }
            else if (Console.ReadLine().ToUpper() == "NO")
            {
                forestMonster.HasLegs = false;
            }
            else
            {
                Console.WriteLine("You did not enter a valid input");
                DisplayContinuePrompt();
            }
            Console.WriteLine();
            Console.WriteLine("Weight: ");
            if (!double.TryParse(Console.ReadLine(), out userResponse))
            {
                Console.WriteLine("please enter a number");
                DisplayContinuePrompt();
            }
            else
            {
                userResponse = forestMonster.Weight;
            }
            Console.WriteLine();
            Console.WriteLine("Eats Meat? [YES or NO]: ");
            if (Console.ReadLine().ToUpper() == "YES")
            {
                forestMonster.EatsMeat = true;
            }
            else if (Console.ReadLine().ToUpper() == "NO")
            {
                forestMonster.EatsMeat = false;
            }
            else
            {
                Console.WriteLine("You did not enter a valid input");
                DisplayContinuePrompt();
            }

            forestMonster.IsHappy();

            DisplayContinuePrompt();
            return forestMonster;
        }

        static void DisplayMonsterInfoScreen(SeaMonster suzy, SpaceMonster lettuce, ForestMonster jodi, ForestMonster landMonster)
        {
            DisplayHeader("\t\tMonster Information\n");


            DisplaySeaMonster(suzy);
            Console.WriteLine();
            DisplaySpaceMonster(lettuce);
            Console.WriteLine();
            DisplayForestMonster(jodi);
            Console.WriteLine();
            DisplayContinuePrompt();


        }

        private static void DisplaySpaceMonster(SpaceMonster spaceMonster)
        {

            spaceMonster.Greeting();
            Console.WriteLine($"ID: {spaceMonster.Id}");
            Console.WriteLine($"Name: {spaceMonster.Name}");
            Console.WriteLine($"Age(Earth Years): {spaceMonster.Age}");
            Console.WriteLine($"Length(Feet): {spaceMonster.Length}");
            Console.WriteLine($"Galaxy: {spaceMonster.Galaxy}");
            Console.WriteLine($"Can Breathe in Space: {(spaceMonster.CanBreathInSpace ? "Yes" : "No")}");
            Console.WriteLine($"Active: {(spaceMonster.IsActive ? "Yes" : "No")}");
            Console.WriteLine($"Spaceship: {(spaceMonster.Spaceship ? "Yes" : "No")}");
            Console.WriteLine($"Happy: {(spaceMonster.IsHappy() ? "Yes" : "No")}");

            Console.WriteLine($"You attack {spaceMonster.Name} and they {spaceMonster.MonsterBattleResponse()} ");
        }
        static void DisplaySeaMonster(SeaMonster seaMonster)
        {

            Console.WriteLine($"ID: {seaMonster.Id}");
            Console.WriteLine($"Name: {seaMonster.Name}");
            Console.WriteLine($"Age: {seaMonster.Age}");
            Console.WriteLine($"Length(Feet): {seaMonster.Length}");
            Console.WriteLine($"Weight(Pounds): {seaMonster.Weight}");
            Console.WriteLine($"Active: {(seaMonster.IsActive ? "Yes" : "No")}");
            Console.WriteLine($"Gills: {(seaMonster.HasGills ? "Yes" : "No")}");
            Console.WriteLine($"Sea Name: {seaMonster.SeaName}");
            Console.WriteLine($"Happy: {(seaMonster.IsHappy() ? "Yes" : "No")}");
            Console.WriteLine($"You approach {seaMonster.Name} and say Hi and {seaMonster.Name} {seaMonster.MonsterInteraction()} at you.");
            seaMonster.Greeting();

        }
        static void DisplayForestMonster(ForestMonster forestMonster)
        {
            Console.WriteLine($"ID: {forestMonster.Id}");
            Console.WriteLine($"Name: {forestMonster.Name}");
            Console.WriteLine($"Age: {forestMonster.Age}");
            Console.WriteLine($"Weight(Pounds): {forestMonster.Weight}");
            Console.WriteLine($"Continent: {forestMonster.Continent}");
            Console.WriteLine($"Active: {(forestMonster.IsActive ? "Yes" : "No")}");
            Console.WriteLine($"Eats Meat: {(forestMonster.EatsMeat ? "Yes" : "No")}");
            Console.WriteLine($"Happy: {(forestMonster.IsHappy() ? "Yes" : "No")}");
            Console.WriteLine($"Has Legs: {(forestMonster.HasLegs ? "Yes" : "No")}");
            forestMonster.Greeting();
            Console.WriteLine($"You attack {forestMonster.Name} and they {forestMonster.MonsterBattleResponse()} ");
        }

        #region HELPERS 
        //CONTINUE PROMPT      
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\n\n\t\tPress enter to conitinue\n");
            Console.ReadLine();
        }


        //WELCOME SCREEN
        static void WelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine("\n\n\t\tThank You for using the Monster App\n");
            DisplayContinuePrompt();
        }


        //HEADER        
        static void DisplayHeader(string headerText)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(headerText);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }


        //CLOSING SCREEN     
        static void ClosingScreen()
        {

            DisplayHeader("\t\tClosing Screen");
            Console.WriteLine("It's been real!");
            Console.WriteLine();
            Console.WriteLine("Press enter key to exit");
            Console.ReadLine();
        }
        #endregion

    }
}
