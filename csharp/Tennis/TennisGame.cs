using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    public class TennisGame : ITennisGame
    {
        private Player _playerOne;
        private Player _playerTwo;

        public TennisGame(string player1Name, string player2Name)
        {
            this._playerOne = new Player(player1Name);
            this._playerTwo = new Player(player2Name);
        }

        public void WonPoint(string playerName)
        {
            if (playerName == _playerOne.Name)
                _playerOne.Score++;
            else
                _playerTwo.Score++;
        }

        public string GetScore()
        {
            if (_playerOne.Score == _playerTwo.Score)
            {
                return TennisGameHelper.GetFormattedScoreForEquality(_playerOne.Score);
            }
            else if (_playerOne.Score >= 4 || _playerTwo.Score >= 4)
            {
                return TennisGameHelper.GetFormattedScoreForAdvantageOrWin(_playerOne, _playerTwo);
            }
            return TennisGameHelper.GetFormattedScore(_playerOne, _playerTwo);
        }
    }
}
