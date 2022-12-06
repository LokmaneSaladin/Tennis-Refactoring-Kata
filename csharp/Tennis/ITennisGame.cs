namespace Tennis
{
    public interface  ITennisGame
    {
        public void WonPoint(string playerName);
        public string GetScore();
    }
}