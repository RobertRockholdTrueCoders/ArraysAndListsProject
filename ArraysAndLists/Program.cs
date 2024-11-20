using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int array and populate it with numbers 1-10
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create a list of type int
             * Name the list "evens"
             */
            var evens = new List<int>() { 1, 3, 5, 7, 9 };

            /* Create another list of type int
             * Name the list "odds"
             */
            var odds = new List<int>() { 2, 4, 6, 8, 10 };

            /* Using either a foreach or for loop,
             * iterate through the array you populated with 10 numbers.
             * Inside the scope of the loop,
             * check to see if each number in the array is even or odd.
             * If the number is even, add it to the evens list.
             * If the number is odd, add it to the odds list.
             */

            foreach (var number in numbers)
            {
             if (number % 2 == 0)
             {
              
             }
            }
             


            /* Using a foreach loop,
             * display the numbers in your "evens" list
             */

            foreach (var number in evens)
            {
             Console.WriteLine(number);
            }


            /* Using a for loop,
             * display the numbers in your "odds" list
             */

            for (int i = 0; i <= odds.Count - 1; i++)
            {
             Console.WriteLine(odds[i]);
            }
        }
    }
}
