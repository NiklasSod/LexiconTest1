using System;
using System.Collections.Generic;
using System.Text;

namespace LexiconTest1.Kattis
{
    internal class FizzBuzz
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzzSolver(i));
            }
            Console.ReadLine();
        }

        static string FizzBuzzSolver(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0)) return "FizzBuzz";
            else if (number % 3 == 0) return "Fizz";
            else if (number % 5 == 0) return "Buzz";
            else return number.ToString();
        }
    }
}
