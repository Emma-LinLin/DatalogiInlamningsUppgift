using DatalogiInlamningsUppgift.Calculator;
using DatalogiInlamningsUppgift.Helper;
using System;

namespace DatalogiInlamningsUppgift.ProgramLogic
{
    class MenuHandler
    {
        PrimCalculator calc = new PrimCalculator();

        /// <summary>
        /// Greets the user
        /// </summary>
        public void Introduction()
        {
            Console.WriteLine("Welcome to the prim calculator!");
            MainMenu();
        }

        /// <summary>
        /// Main menu with instructions for the user
        /// </summary>
        public void MainMenu()
        {
            InputHelper helper = new InputHelper();
            while (true)
            {
                Console.WriteLine("Please enter a number: ");
                int input = helper.ParseUserInput();
                bool respons = calc.Calculate(input);
                if (respons)
                {
                    Console.WriteLine("That's a prim, we added it to your list!");
                }
                else
                {
                    Console.WriteLine("That's not a prim number");
                }
                
                Console.WriteLine();
                Console.WriteLine("To print list enter [P]");
                Console.WriteLine("To add next prim number to your list enter [A]");
                Console.WriteLine("To quit enter [Q]");

                string userInput = Console.ReadLine().ToLower();
                if (userInput == "q")
                {
                    break;
                }
                else if (userInput == "p")
                {
                    calc.Print();
                }
                else if (userInput == "a")
                {
                    calc.AddPrim();
                }
            }
        }
    }
}
