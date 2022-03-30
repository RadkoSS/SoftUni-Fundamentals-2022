using System;
using System.Linq;
using System.Collections.Generic;

namespace P03.ThePianist
{
    class Piece
    {
        public Piece(string piece, string composer, string key)
        {
            this.PieceName = piece;
            this.Composer = composer;
            this.Key = key;
        }

        public string PieceName { get; set; }

        public string Composer { get; set; }

        public string Key { get; set; }

        public override string ToString()
        {
            return $"{this.PieceName} -> Composer: {this.Composer}, Key: {this.Key}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            int piecesCount = int.Parse(Console.ReadLine());

            List<Piece> piecesList = new List<Piece>();

            InitializePieces(piecesCount, piecesList);

            Console.WriteLine(string.Join(Environment.NewLine, piecesList));

        }

        static List<Piece> InitializePieces(int piecesCount, List<Piece> piecesList)
        {
            for (int piece = 1; piece <= piecesCount; piece++)
            {
                string[] piecesInformation = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

                Piece newPiece = new Piece(piecesInformation[0], piecesInformation[1], piecesInformation[2]);

                piecesList.Add(newPiece);
            }

            ExecuteCommands(piecesList);

            return piecesList;
        }

        static List<Piece> ExecuteCommands(List<Piece> piecesList)
        {
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commandArgs = command.Split('|', StringSplitOptions.RemoveEmptyEntries);

                string commandType = commandArgs[0];
                string pieceName = commandArgs[1];

                if (commandType == "Add")
                {
                    string composer = commandArgs[2];
                    string key = commandArgs[3];

                    if (piecesList.Any(piece => piece.PieceName == pieceName))
                    {
                        Console.WriteLine($"{pieceName} is already in the collection!");
                    }
                    else
                    {
                        //Piece pieceToAdd = new Piece(pieceName, composer, key);
                        piecesList.Add(new Piece(pieceName, composer, key));

                        Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
                    }
                }

                else if (commandType == "Remove")
                {
                    if (piecesList.Any(piece => piece.PieceName == pieceName))
                    {
                        piecesList.Remove(piecesList.Find(piece => piece.PieceName == pieceName));

                        Console.WriteLine($"Successfully removed {pieceName}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }

                else if (commandType == "ChangeKey")
                {
                    string newKey = commandArgs[2];

                    if (piecesList.Any(piece => piece.PieceName == pieceName))
                    {
                        piecesList.Find(piece => piece.PieceName == pieceName).Key = newKey;
                        Console.WriteLine($"Changed the key of {pieceName} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }
            }
            return piecesList;
        }
    }
}
