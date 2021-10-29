using System;
using System.Collections.Generic;
using System.Linq;

namespace DatalogiInlamningsUppgift.Calculator
{
    class PrimCalculator
    {
        public List<int> primNumbers = new List<int>();

        /// <summary>
        /// Checks if the number given by the user is a prim number,
        /// by checking if the number of dividers is equal to 2
        /// </summary>
        /// <param name="number">user input</param>
        /// <returns>boolean, true if prim number, false if not</returns>
        public bool Calculate(int number)
        {
            int dividers = default;

            for(int i = 1; i <= number; i++)
            {
                if(number % i == 0)
                {
                    dividers++;
                }
                if(dividers > 2)
                {
                    break;
                }
            }

            if(dividers == 2)
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
        /// Adds the closest prim number based off the highest number in the list of prim numbers.
        /// As soon as the respons is true the number found will be added to the list of prims.
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
                    Console.WriteLine($"We've added {maxNumber} to your list of prims!");
                    break;
                }
            }   
        }
    }
}
