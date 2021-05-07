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
            var rollsIndex = 0;
            
            for (var i = 0; i < 10; i++)
            {
                var frameScore = Rolls[rollsIndex] + Rolls[rollsIndex + 1];
                var scoreToAdd = frameScore;

                if (Rolls[rollsIndex] == 10) // strike
                {
                    // add next two rolls
                    scoreToAdd = 10 + Rolls[rollsIndex + 1] + Rolls[rollsIndex + 2];
                    rollsIndex++;
                }
                else if (frameScore == 10 && Rolls[rollsIndex] != 10) // spare
                {
                    // add next roll
                    scoreToAdd = 10 + Rolls[rollsIndex + 2];
                    rollsIndex +=2;
                }
                else
                {
                    rollsIndex +=2;
                }
                totalScore += scoreToAdd;
                FrameScore[i] = totalScore;
            }

            return totalScore;
        }
    }
}