using System;
using System.Collections.Generic;
using System.Text;

// https://open.kattis.com/problems/1dfroggereasy

namespace LexiconTest1.Kattis
{
    internal class Frogger
    {
        public record GameData(int StartingSquare, int MagicNumber, int[] Board);

        static void Main(string[] args)
        {

            GameData? data = ParseInput();
            if (data == null) return;

            // store the outcome for Kattis to read
            Outcome(data);
        }

        static GameData? ParseInput()
        {
            string? gameInfo = Console.ReadLine();
            if (string.IsNullOrEmpty(gameInfo)) return null;

            string[] gameInfoParts = gameInfo.Split();
            if (gameInfoParts.Length < 3) return null;

            int amountOfSquares = int.Parse(gameInfoParts[0]);
            int startingSquare = int.Parse(gameInfoParts[1]);
            int magicNumber = int.Parse(gameInfoParts[2]);

            string? numberOnSquaresStringLine = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(numberOnSquaresStringLine)) return null;

            string[] stringBoardParts = numberOnSquaresStringLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (stringBoardParts.Length == 0) return null;

            int[] boardParts = new int[stringBoardParts.Length];

            for (int i = 0; i < stringBoardParts.Length; i++)
            {
                boardParts[i] = int.Parse(stringBoardParts[i]);
            }

            if (boardParts.Length != amountOfSquares) return null;

            // amountOfSquares not needed anymore, boardParts has extra information now (position and value)
            return new GameData(startingSquare, magicNumber, boardParts);
        }

        public struct FrogResult
        {
            public string StatusOfGame;
            public int NumberOfJumps;
        }

        static FrogResult Outcome(GameData data)
        {
            int start = data.StartingSquare;
            int magic = data.MagicNumber;
            int[] board = data.Board;

            return new FrogResult { StatusOfGame = "magic", NumberOfJumps = 5 }; // example return
        }
    }
}
