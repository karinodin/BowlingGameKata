using System;
using System.Security.Cryptography.X509Certificates;

namespace BowlingGame
{
    public class BowlingService : IBowlingService
    {
        public BowlingService()
        {
            
        }

        public bool Spare(int frameScore, int firstRoll)
        {
            return frameScore == 10 && firstRoll != 10;
        }

        public bool Strike(int firstRoll)
        {
            return firstRoll == 10;
        }
    }
}