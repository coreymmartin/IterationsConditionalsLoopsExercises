using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        public static void PrintNumbersInRange(int start, int end, int step = 0) {
            // Write a method that will print to the console all numbers 1000 through -1000
            // Write a method that will print to the console numbers 3 through 999 by 3 each time
            step = (step == 0) ? (start < end) ? 1 : -1 : step;
            if (((step > 0) && (start > end)) || ((step < 0) && (end > start))) {
                Console.WriteLine($"step({step}), start({start}), end({end}) ==> swapping start and end values");
                int temp = start;
                start = end;
                end = temp;
                }
            Console.WriteLine($"printing every {step} number from {start} to {end}");
            int numLoops = (end - start) / step;
            Console.WriteLine($"start({start}), end({end}), numLoops({numLoops})");
            ClearScreen();
            for (int x = 0; x <= numLoops; x++)
                Console.WriteLine(start + (x * step));
            ClearScreen();
        }

        public static void AreTheseTwoIntegersEqualOrNot() {
            // Write a method to accept two integers as parameterss and check whether they are equal or not
            int firstNumber = AskForInt("enter two integers to see if they are equal or not.\nPlease enter integer 1");
            int secondNumber = AskForInt("Please enter integer 2");
            Console.WriteLine((firstNumber == secondNumber) ? $"{firstNumber} and {secondNumber} are equal!" : $"{firstNumber} and {secondNumber} are not equal!");
            ClearScreen();
        }

        public static void EvenOrOdd() {
            // Write a method to check whether a given number is even or odd
            int input = AskForInt("please enter an integer and I will tell you if it is even or odd!");
            Console.WriteLine((input % 2 == 0) ? $"{input} is even" : $"{input} is odd");
            ClearScreen();
        }

        public static void AreYouPositive() {
            // Write a method to check whether a given number is positive or negative
            int input = AskForInt("please an integer and I will tell you if it is positive or negative!");
            Console.WriteLine((input >= 0) ? $"{input} is positive" : $"{input} is negative");
            ClearScreen();
        }

        public static void WillYourVoteCount() {
            // Write a method to read the age of a candidate and determine whether they can vote.
            int voterAge = AskForInt("please enter your age (number) and we will see if you can vote or not");
            Console.WriteLine((voterAge >= 18) ? "you are eligable to cast your vote" : "your vote will not be counted, child.");
            ClearScreen();
        }

        public static void CheckInRange() {
            // Write a method to check if an integer (from the user) is in the range -10 to 10
            int input = AskForInt("enter an number and we will tell you if it is in range of -10 and 10");
            Console.WriteLine(((-10 <= input) && (input <= 10)) ? $"{input} is within range" : $"{input} is out of range");
            ClearScreen();
        }

        public static void ShowMultiplicationTable() {
            // Write a method to display the multiplication table(from 1 to 12) of a given integer
            int input = AskForInt("enter an integer and we will show you the times tables from 1 to 12. neat!");
            Console.WriteLine($"displaying multiplication table (1 - 12)");
            for (int i = 1; i <= 12; i++)
                Console.WriteLine($"{input} * {i} = {input * i}");
            ClearScreen();
        }

        public static void ClearScreen() {
            Console.WriteLine("\npress enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        public static int AskForInt(string ask = "please enter input (integer)") {
            bool isInt;
            int userNumber;
            do
            {
                Console.WriteLine(ask);
                isInt = int.TryParse(Console.ReadLine(), out userNumber);
            } 
            while (!isInt);
            return userNumber;
        }
        static void Main(string[] args)
        {
            PrintNumbersInRange(1000, -1000);

            PrintNumbersInRange(3, 999, 3);

            AreTheseTwoIntegersEqualOrNot();

            EvenOrOdd();

            AreYouPositive();

            WillYourVoteCount();

            CheckInRange();

            ShowMultiplicationTable();

            Console.WriteLine("thank you! please come again!\n");
        }
    }
}
