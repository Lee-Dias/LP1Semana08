using System;


namespace PlayerManager3
{
    public class Player
    {
        public string Name { get; }
        public int Score { get; set; }
        public Player (string name, int score)
        {
            Name = name;
            Score = score;
        }

        public int CompareTo(Player play)
        {
            if (play == null) return 1; 
            if (Score > play.Score) return 1;
            else if (Score < play.Score) return -1;
            else return 0;

        }


    }
}