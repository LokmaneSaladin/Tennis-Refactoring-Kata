using System;

namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private Player playerOne; 
        private Player playerTwo;

        public TennisGame3(string player1Name, string player2Name)
        {
            this.playerOne = new Player(player1Name);
            this.playerTwo = new Player(player2Name);
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

        public void WonPoint(string playerName)
        {
            if (playerName == this.playerOne.Name)
                this.playerOne.Score += 1;
            else if(playerName == this.playerTwo.Name)
                this.playerTwo.Score += 1;
        }

    }
}

