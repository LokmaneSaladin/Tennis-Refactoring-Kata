using System;

namespace Tennis
{
    public static class TennisGameHelper
    {
        public static string GetFormattedScoreForEquality(int score)
        {
            if (score > 2)
                return "Deuce";

            return ((ScoreName)score).ToString() + "-All";
        }

        public static string GetFormattedScoreForAdvantageOrWin(Player playerOne, Player playerTwo)
        {
            string winOrAdvantage = Math.Abs(playerOne.Score - playerTwo.Score) == 1 ? "Advantage " : "Win for ";
            string winner = playerOne.Score > playerTwo.Score ? playerOne.Name : playerTwo.Name;

            return winOrAdvantage + winner;
        }

        public static string GetFormattedScore(Player playerOne, Player playerTwo) 
        {
            return ((ScoreName)playerOne.Score).ToString() + "-" + ((ScoreName)playerTwo.Score).ToString();
        }
    }
    public enum ScoreName
    {
        Love,
        Fifteen,
        Thirty,
        Forty
    }
}
