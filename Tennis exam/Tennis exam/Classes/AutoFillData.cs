using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_exam.Classes
{
    class AutoFillData : Person
    {
        enum FirstNameMale { Anders, Bent, Charles, Danni, Erik, Finn, Gert, Hans, Ib }
        enum FirstNameFemale { Anni, Belina, Christina, Dina, Elisa, Fie, Gita, Henrietta, Ine }

        enum MiddleNames { Dahl, Friis, Holm, Nørgaard, Søndergaard, Lund, Juul, Kjær, Skov }
        enum LastNames { Østergaard, Jensen, Rasmussen, Jespersen, Pedersen, Petersen, Larsen, Nielsen, Andersen }

        Random rand = new Random();

        public Player AutoCreatePlayer(string gender)
        {
            Player newPlayer = new Player();
            
            if (gender == "male")
            {
                newPlayer.FristName = Enum.GetName(typeof(FirstNameMale), RandomIndex());
                newPlayer.Gender = (int)Genders.Male;
            }
            else if (gender == "female")
            {
                newPlayer.FristName = Enum.GetName(typeof(FirstNameFemale), RandomIndex());
                newPlayer.Gender = (int)Genders.Female;
            }
            newPlayer.MiddleName = Enum.GetName(typeof(MiddleNames), RandomIndex());
            newPlayer.LastName = Enum.GetName(typeof(LastNames), RandomIndex());
            newPlayer.DateOfBirth = RandomBirthDate();
            newPlayer.Nationality = RandomIndex();

            return newPlayer;
        }

        private int RandomIndex()
        {
            int firstNameIndex = rand.Next(0, 8);
            return firstNameIndex;
        }
        
        private DateTime RandomBirthDate()
        {
            DateTime start = new DateTime(1980, 1, 1);
            DateTime end = new DateTime(1995, 1, 1);

            int range = (end - start).Days;
            return start.AddDays(rand.Next(range));
        }
    }
}