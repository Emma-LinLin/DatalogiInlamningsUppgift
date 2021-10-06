using System;

namespace DatalogiInlamningsUppgift.Helper
{
    class InputHelper
    {
        /// <summary>
        /// Helps to parse user input to a number,
        /// if unable to parse the user will be asked to try again
        /// </summary>
        /// <returns>the number given by the user</returns>
        public int ParseUserInput()
        {
            int userInput;

            while (true)
            {
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    return userInput;
                }
                catch (Exception)
                {
                    Console.WriteLine("Only numbers please! Try again");
                }
            }
        }
    }
}
