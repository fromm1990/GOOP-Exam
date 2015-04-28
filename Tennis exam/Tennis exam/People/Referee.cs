using System;

namespace TennisExam.People
{
    internal class Referee : Person
    {
        public DateTime LicenseAcquired { get; set; }
        public DateTime? LicenseLastRenewed { get; set; }
    }
}
