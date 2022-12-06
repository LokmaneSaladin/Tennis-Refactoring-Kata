using System;

namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        public Player playerOne;
        public Player playerTwo;
        
        public TennisGame2(string player1Name, string player2Name)
        {
            this.playerOne = new Player(player1Name);
            this.playerTwo = new Player(player2Name);
        }
        
        public void WonPoint(string playerName)
        {
            if (playerName == playerOne.Name)
                playerOne.Score++;
            else
                playerTwo.Score++;
        }

        public string GetScore()
        {
            if (playerOne.Score == playerTwo.Score)
            {
                return TennisGameHelper.GetFormattedScoreForEquality(playerOne.Score);
            }
            else if (playerOne.Score >= 4 || playerTwo.Score >= 4)
            {
                return TennisGameHelper.GetFormattedScoreForAdvantageOrWin(playerOne, playerTwo);
            }
            return TennisGameHelper.GetFormattedScore(playerOne, playerTwo);
        }
    }
}
