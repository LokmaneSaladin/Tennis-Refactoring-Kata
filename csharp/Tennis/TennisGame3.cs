using System;

namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int p2;
        private int p1;
        private string p1N;
        private string p2N;

        private string[] _scoreTable = { "Love", "Fifteen", "Thirty", "Forty" };
        public TennisGame3(string player1Name, string player2Name)
        {
            this.p1N = player1Name;
            this.p2N = player2Name;
        }

        public string GetScore()
        {
            string s;
            if ((p1 < 4 && p2 < 4) && (p1 + p2 < 6))
            {
                s = _scoreTable[p1];
                return (p1 == p2) ? s + "-All" : s + "-" + _scoreTable[p2];
            }
            else
            {
                if (p1 == p2)
                    return "Deuce";
                s = p1 > p2 ? p1N : p2N;
                return Math.Abs(p1 - p2) < 2 ? "Advantage " + s : "Win for " + s;
            }
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                this.p1 += 1;
            else
                this.p2 += 1;
        }

    }
}

