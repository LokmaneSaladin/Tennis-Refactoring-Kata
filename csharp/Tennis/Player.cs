using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
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
}
