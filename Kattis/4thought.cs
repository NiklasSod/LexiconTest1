using System;
using System.Collections.Generic;
using System.Text;

namespace LexiconTest1.Kattis
{
    internal class _4thought
    {
        static void Main(string[] args)
        {
            int[] solutions = PreComputeAll();
            string testLength = Console.ReadLine();
            if (int.TryParse(testLength, out int testCases)) {
                for (int i = 0; i < testCases; i++)
                {
                    string testCase = Console.ReadLine();
                    int number = int.Parse(testCase);
                    // check solutions array and answer in Console.WriteLine

                }
            }
        }
        static int[] PreComputeAll()
        {
            // calculate all solutions between the number -60 and 256
            // sound solution -> save startNum (8) and solution "4 + 4 - 4 + 4 = 8"
            // return array 
        }
    }
}
