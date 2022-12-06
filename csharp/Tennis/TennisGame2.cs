using System;

namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private Player playerOne;
        private Player playerTwo;
        private string[] _scoreTable = new string[4] { "Love", "Fifteen", "Thirty", "Forty" };

        public TennisGame2(string player1Name, string player2Name)
        {
            this.playerOne = new Player(player1Name);
            this.playerTwo = new Player(player2Name);
        }

        public string GetScore()
        {
            if (playerOne.Score == playerTwo.Score)
            {
                return (playerOne.Score < 3) ? _scoreTable[playerOne.Score] + "-All" : "Deuce";
            }
            if(playerOne.Score >= 4 || playerTwo.Score >= 4)
            {
                return GetWinOrAdvatange() + " " + GetGreaterPlayerName();
            }
            
            return GetFormattedScore(playerOne.Score, playerTwo.Score);
        }

        private string GetWinOrAdvatange()
        {
            return Math.Abs(playerOne.Score - playerTwo.Score) < 2 ? "Advantage" : "Win for";
        }

        private string GetGreaterPlayerName()
        {
            return playerOne.Score > playerTwo.Score ? playerOne.Name : playerTwo.Name;
        }

        private string GetFormattedScore(int scorePlayerOne, int scorePlayerTwo)
        {
            return _scoreTable[scorePlayerOne] + "-" + _scoreTable[scorePlayerTwo]; ;
        }

        void ITennisGame.WonPoint(string player)
        {
            if (player == playerOne.Name)
                playerOne.Score++;
            else
                playerTwo.Score++;
        }
    }
}

public class Player
{
    private string _name;
    private int _score;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Score
    {
        get { return _score; }
        set { _score = value; }
    }

    public Player(string name, int score = 0)
    {
        this._name = name;
        this._score = score;
    }
}
