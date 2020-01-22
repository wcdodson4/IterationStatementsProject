using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers"
            var numbers = new List<int>();
            //Create a variable of type int with an initializer of 0
            var i = 0;


            // Create a do-while loop
            {
                // Increment your variable by 1
                // Then add your variable to "numbers"
            }
            // While your variable is less than 100
            do
            {
                i++;
                numbers.Add(i);
            } while (i < 100);


            // Create a while loop
            // While your variable is less than 200
            {
                // Increment your variable by 1
                // Then add your variable to "numbers"
            }
            while (i < 200)
            {
                i++;
                numbers.Add(i);
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            // Write your variable to the console
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            {
                // Write to the console "numbers" at index i
            }
            for(var x = 199; x <= numbers.Count && x >= 0; x--)
            {
                Console.WriteLine(numbers[x]);
            }
        }
    }
}
