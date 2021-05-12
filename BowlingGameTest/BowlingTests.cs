using BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTest
{
    [TestClass]
    public class BowlingGameTest
    {
        private Game _game;

            [TestInitialize]
        public void BowlingGameTestFixture()
        {
            _game = new Game();
        }

        [TestMethod]
        public void TestGutterGame()
        {
            RollMany(20, 0);
            Assert.AreEqual(0, _game.Score());
        }

        [TestMethod]
        public void TestAllOnes()
        {
            RollMany(20, 1);
            Assert.AreEqual(20, _game.Score());
        }
        
        [TestMethod]
        public void TestOneSpare()
        {
            _game.Roll(5);
            _game.Roll(5);
            _game.Roll(3);
            RollMany(17, 0);
            Assert.AreEqual(16, _game.Score());
        }
        
        [TestMethod]
        public void TestOneSpareWithTenPins()
        {
            _game.Roll(0);
            _game.Roll(10);
            _game.Roll(3);
            RollMany(17, 0);
            Assert.AreEqual(16, _game.Score());
        }

        [TestMethod]
        public void TestOneStrike()
        {
            _game.Roll(10);
            _game.Roll(4);
            _game.Roll(3);
            RollMany(16, 0);
            Assert.AreEqual(24, _game.Score());
        }

        [TestMethod]
        public void TestPerfectGame()
        {
            RollMany(12, 10);
            Assert.AreEqual(300, _game.Score());
        }
        
        private void RollMany(int n, int pins)
        {
            for (var i = 0; i < n; i++)
            {
                _game.Roll(pins);
            }
        }
    }
}