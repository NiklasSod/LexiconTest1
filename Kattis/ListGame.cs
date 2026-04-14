using System;
using System.Collections.Generic;
using System.Text;

// https://open.kattis.com/problems/listgame

namespace LexiconTest1.Kattis
{
    internal class ListGame
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            string input = "127381";
            int player1Number = int.Parse(input);
            Console.WriteLine(Player2Answer(player1Number));
            Console.ReadLine();
        }

        static string Player2Answer(int number)
        {
            int restNumber = number;
            int pointsPlayer2 = 0;
            int updatedNumber = 2;

            while (updatedNumber * updatedNumber <= restNumber) {
                for (int i = updatedNumber; i < restNumber; i++)
                {
                    while (restNumber % updatedNumber == 0)
                    {
                        restNumber = restNumber / updatedNumber;
                        pointsPlayer2++;
                    }
                    updatedNumber++;
                }
            }

            if (restNumber > 1)
            {
                pointsPlayer2++;
            }

            return pointsPlayer2.ToString();
        }
    }
}
