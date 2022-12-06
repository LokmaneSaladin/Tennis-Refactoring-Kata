using System;

namespace Tennis
{
    public class TennisGame1 : ITennisGame
    {
        private Player playerOne;
        private Player playerTwo;

        public TennisGame1(string player1Name, string player2Name)
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
            string score = "";
            var tempScore = 0;
            if (playerOne.Score == playerTwo.Score)
            {
                return GetFormattedScoreForEquality(playerOne.Score);
            }
            else if (playerOne.Score >= 4 || playerTwo.Score >= 4)
            {
                return GetFormattedScoreForAdvantageOrWin(playerOne, playerTwo);
            }
            else
            {
                score = ((ScoreName)playerOne.Score).ToString() + "-" + ((ScoreName)playerTwo.Score).ToString();
            }
            return score;
        }

        private string GetFormattedScoreForEquality(int score)
        {
            if (score > 2)
                return "Deuce";

            return ((ScoreName)score).ToString() + "-All";
        }

        private string GetFormattedScoreForAdvantageOrWin(Player playerOne, Player playerTwo)
        {
            string winOrAdvantage = Math.Abs(playerOne.Score - playerTwo.Score) == 1 ? "Advantage " : "Win for ";
            string winner = playerOne.Score > playerTwo.Score ? playerOne.Name: playerTwo.Name;
            
            return winOrAdvantage + winner;
        }

    }


    public class Player
    {
        private string _name;
        private int _score;
        
        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        
        public int Score {
            get { return _score; }
            set { _score = value; }
        }

        public Player(string name, int score = 0)
        {
            this._name = name;
            this._score = score;
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

