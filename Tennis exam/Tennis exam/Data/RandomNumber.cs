using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisExam.Data
{
    static class RandomNumber
    {
        private static Random Rand { get; set; }

        static RandomNumber()
        {
            Rand = new Random();
        }
    }
}
