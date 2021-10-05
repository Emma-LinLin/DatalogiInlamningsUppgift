using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatalogiInlamningsUppgift.Calculator
{
    class PrimCalculator
    {
        public List<int> primNumbers = new List<int>();

        /// <summary>
        /// Checks if the number given by the user is a prim number
        /// </summary>
        /// <param name="number">user input</param>
        /// <returns>boolean, true if prim number, false if not</returns>
        public bool Calculate(int number)
        {
            if(number < 1)
            {
                return false;
            }
            if(number == 2 || number == 5)
            {
                primNumbers.Add(number);
                return true;
            }

            int lastDigit = number % 10;
            if(lastDigit == 1 || lastDigit == 3 || lastDigit == 7 || lastDigit == 9)
            {
                primNumbers.Add(number);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Prints the numbers added to the list of prim numbers
        /// </summary>
        public void Print()
        {
            if(primNumbers.Count == 0)
            {
                Console.WriteLine("The list is empty");
                return;
            }

            foreach(var number in primNumbers)
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Adds the closest prim number based off the highest number in the list of prim numbers
        /// </summary>
        public void AddPrim()
        {
            if (primNumbers.Count == 0)
            {
                Console.WriteLine("The list is empty");
                return;
            }

            int maxNumber = primNumbers.Max();
            while (true)
            {
                maxNumber += 1;
                bool respons = Calculate(maxNumber);
                if (respons)
                {
                    break;
                }
            }   
        }
    }
}
