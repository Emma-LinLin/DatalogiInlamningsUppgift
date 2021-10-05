using DatalogiInlamningsUppgift.Calculator;
using DatalogiInlamningsUppgift.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatalogiInlamningsUppgift.ProgramLogic
{
    class PrimNumbers
    {
        PrimCalculator calc = new PrimCalculator();

        public void Introduction()
        {
            
            Console.WriteLine("Welcome to the prim calculator!");
            MainMenu();
            
        }

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

                Console.WriteLine("To print list enter [P]");
                Console.WriteLine("To add next prim number to your list enter [A]");
                Console.WriteLine("To quit enter [Q]");

                string userInput = Console.ReadLine();
                if (userInput == "Q" || userInput == "q")
                {
                    break;
                }
                if (userInput == "P" || userInput == "p")
                {
                    calc.Print();
                }
                if (userInput == "A" || userInput == "a")
                {
                    calc.AddPrim();
                }
            }
            

        }
    }
}
