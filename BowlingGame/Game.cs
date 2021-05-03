using System.Collections.Generic;

namespace BowlingGame
{
    public class Game
    {
        private readonly List<int> _rolls = new();

        public void Roll(int pins)
        {
            _rolls.Add(pins);
        }

        public int Score()
        {
            var score = 0;
            
            for (var i = 0; i < 10; i++)
            {
                int scoreToAdd;
                
                if (i == 9)
                {
                    scoreToAdd = GetScoreInLastFrame();
                }
                
                // add a zero if there was a strike
                if (_rolls[2 * i] == 10)
                {
                    _rolls.Insert(2 * i + 1, 0);
                }
                
                var frameScore = _rolls[2 * i] + _rolls[2 * i + 1];
                scoreToAdd = frameScore;
                if (_rolls[2 * i] == 10) // strike
                {
                    // add next two rolls
                    scoreToAdd = 10 + _rolls[2 * i + 2] + _rolls[2 * i + 3];
                }
                if (frameScore == 10 && _rolls[2 * i] != 10) // spare
                {
                    // add next roll
                    scoreToAdd = 10 + _rolls[2 * i + 2];
                }
                score += scoreToAdd;
            }

            return score;
        }

        private int GetScoreInLastFrame()
        {
            int scoreInLastFrame;
            if (_rolls[18] == 10)
            {
                if (_rolls[19] == 10)
                {
                    scoreInLastFrame = 20 + _rolls[20];
                }
                scoreInLastFrame = 10 + _rolls[19] + _rolls[20];
            }

            if (_rolls[18] + _rolls[19] == 10)
            {
                scoreInLastFrame = 10 + _rolls[20];
            }
            scoreInLastFrame = _rolls[18] + _rolls[19];

            return scoreInLastFrame;
        }
    }
}