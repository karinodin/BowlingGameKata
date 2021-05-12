using System.Collections.Generic;

namespace BowlingGame
{
    public class Game : IGame
    {
        public List<int> Rolls { get; }
        public int[] FrameScore { get; }

        public Game()
        {
            Rolls = new List<int>();
            FrameScore = new int[10];
        }

        public void Roll(int pins)
        {
            Rolls.Add(pins);
        }

        public int Score()
        {
            var totalScore = 0;
            var index = 0;
            
            for (var frame = 0; frame < 10; frame++)
            {
                var frameScore = Rolls[index] + Rolls[index + 1];

                if (Strike(Rolls[index]))
                {
                    totalScore += 10 + Rolls[index + 1] + Rolls[index + 2];
                    index++;
                }
                else if (Spare(frameScore, Rolls[index]))
                {
                    totalScore += 10 + Rolls[index + 2];
                    index +=2;
                }
                else
                {
                    totalScore += frameScore;
                    index +=2;
                }
                FrameScore[frame] = totalScore;
            }

            return totalScore;
        }

        private bool Spare(int frameScore, int roll)
        {
            return frameScore == 10 && roll != 10;
        }
        
        private bool Strike(int roll)
        {
            return roll == 10;
        }
    }
}