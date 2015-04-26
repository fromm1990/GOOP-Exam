using System;

namespace TennisExam.TournamentLogic
{
    internal class Set
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }

        public void PlaySet(Random rand)
        {
            if (rand.Next(0, 100) < 49)
            {
                Score1 = 6;
                Score2 = rand.Next(0, 6);
            }
            else
            {
                Score2 = 6;
                Score1 = rand.Next(0, 6);
            }
        }
    }
}
