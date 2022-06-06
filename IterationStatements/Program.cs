using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1 - write the for loop 15 times.
            Console.WriteLine("Exercise 1:\n");
            for (int j = 0; j < 15; j++) {
                for (int i = 0; i < 5; i++)
                    Console.WriteLine($"{i}"); }


            // Exercise 2 - fork the project 
            Console.WriteLine("Exercise 2:\n");


                                                    //TODO - Read each comment and complete its instruction
                                                    // like the example below
                                                    //Create a List called "numbers" - DONE!
            var numbers = new List<int>();

                                                    //-----START HERE------------------------------------------
                                                    //Create a variable of type int and name it num
                                                    //initialize the variable with a value of 0
            int num = 0;
                                                    // Create a do-while loop and use the template below:
            do
            {
                num++;                              // Increment num by 1
                                                    // Then add num to the collection - numbers
                                                    // Hint: reference num inside of the Add method's parentheses
                numbers.Add(num);

            } while (num < 100);                    // <---- While your variable is less than 100
                                                    // Create a while loop
            while (num < 200)                       // <--- While num is less than 200
            {
                num++;                              // Increment num by 1
                numbers.Add(num);                   // Then add num to the collection numbers
                                                    //HINT: copy how this was done in the do while loop
            }
                                                    // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");
            foreach (var entry in numbers)          // Create a foreach loop using the collection - numbers
                Console.WriteLine(entry);           //In the scope of the foreach loop, print each number in numbers
            Console.WriteLine("\nDecrease:");
                                                    // Create a for loop - this will print the numbers in reverse order - from 200 to 1
                                                        // in your initializer set the value of i to 199
                                                        // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
                                                        // AND as long as i is greater than or equal to 0
                                                        // Decrement i by 1
                                                    //start for loop here
            for (int i = 199; 0 <= i && i <= numbers.Count; i--){
                Console.WriteLine(numbers[i]);      // place numbers[i] inside of the Console.WriteLine() method
            }
                                                    //------------End of exercise
        }
    }
}
