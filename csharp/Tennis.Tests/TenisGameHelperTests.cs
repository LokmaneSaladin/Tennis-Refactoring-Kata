using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Tests
{
    public class TenisGameHelperTests
    {
        [TestCase(0, 1, "Love-Fifteen")]
        [TestCase(1, 0, "Fifteen-Love")]
        [TestCase(2, 2, "Thirty-All")]
        [TestCase(3, 2, "Forty-Thirty")]
        [TestCase(2, 3, "Thirty-Forty")]
        [TestCase(1, 3, "Fifteen-Forty")]
        [TestCase(3, 1, "Forty-Fifteen")]
        [TestCase(3, 0, "Forty-Love")]
        [TestCase(0, 3, "Love-Forty")]
        private void GetFormattedScoreTest(int scoreOne, int scoreTwo, string expectedResult) 
        {
            //Arrange 
            var playerOne = new Player("PlayerOne", scoreOne);
            var playerTwo = new Player("PlayerTwo", scoreTwo);
            //Act
            var result = TennisGameHelper.GetFormattedScore(playerOne, playerTwo);
            //Asssert
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(0, 1, "Love-Fifteen")]
        [TestCase(1, 0, "Fifteen-Love")]
        [TestCase(2, 2, "Thirty-All")]
        [TestCase(3, 2, "Forty-Thirty")]
        [TestCase(2, 3, "Thirty-Forty")]
        [TestCase(1, 3, "Fifteen-Forty")]
        [TestCase(3, 1, "Forty-Fifteen")]
        [TestCase(3, 0, "Forty-Love")]
        [TestCase(0, 3, "Love-Forty")]
        private void GetFormattedScoreForAdvantageOrWinTest() 
        { }
    }
}
