using DatalogiInlamningsUppgift.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatalogiInlamningsUppgift.ProgramLogic
{
    class PrimNumbers
    {
        public void Introduction()
        {
            InputHelper helper = new InputHelper();

            Console.WriteLine("Please enter a number: ");
            int userInput = helper.ParseUserInput();
        }
    }
}
