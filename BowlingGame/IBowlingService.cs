namespace BowlingGame
{
    public interface IBowlingService
    {
        bool Spare(int frameScore, int firstRoll);
        bool Strike(int firstRoll);
    }
}