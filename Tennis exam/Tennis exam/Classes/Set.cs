using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_exam.Classes
{
    class Set
    {
        private Random rand = new Random();

        public int Score1 { get; set; }
        public int Score2 { get; set; }

        public void PlaySet()
        {
            if (rand.Next(0, 100) < 49)
            {
                Score1 = 6;
            }
            else
            {
                Score2 = 6;
            }
            
            if (Score1 == 6)
            {
                Score2 = rand.Next(0, 5);
            }
            else
            {
                Score1 = rand.Next(0, 5);
            }
        }
    }
}
