using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_exam.Classes
{
    internal class Referee : Person
    {
        public DateTime LicenseAcquired { get; set; }
        public DateTime LicenseLastRenewed { get; set; }
    }
}
