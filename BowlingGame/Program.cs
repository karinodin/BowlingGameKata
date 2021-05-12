using System;
using System.Runtime.CompilerServices;

namespace BowlingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var score = SimulatedGame();

            Console.WriteLine($"\nTotal score: {score}");
        }

        private static int SimulatedGame()
        {
            var game = new Game();
            var pins = 5;
            
            for (var i = 0; i < 21; i++)
            {
                game.Roll(pins);
            }

            var score = game.Score();
            
            foreach (var roll in game.Rolls)
            {
                Console.Write($"{roll}  ");
            }
            Console.WriteLine();
            
            foreach (var frameScore in game.FrameScore)
            {
                Console.Write($"{frameScore}    ");
            }

            return score;
        }
    }
}