using System;
using System.Runtime.CompilerServices;

namespace BowlingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var score = SimulatedGame();

            Console.WriteLine($"Total score: {score}");
        }

        private static int SimulatedGame()
        {
            // read a value between 1-10
            
            var game = new Game();

            game.Roll(3);
            game.Roll(4);

            game.Roll(5);
            game.Roll(5);
            
            game.Roll(10);
            
            game.Roll(4);
            game.Roll(3);
            
            game.Roll(3);
            game.Roll(4);
            
            game.Roll(5);
            game.Roll(5);
            
            game.Roll(10);
            
            game.Roll(4);
            game.Roll(3);
            
            game.Roll(6);
            game.Roll(3);
            
            game.Roll(3);
            game.Roll(5);

            var score = game.Score();
            
            foreach (var frameScore in game.FrameScore)
            {
                Console.Write($"{frameScore}   ");
            }
            Console.WriteLine();
            
            foreach (var roll in game.Rolls)
            {
                Console.Write($"{roll}  ");
            }
            
            return score;
        }
    }
}