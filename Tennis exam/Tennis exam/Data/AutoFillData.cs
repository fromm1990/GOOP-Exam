using System;
using System.Linq;
using TennisExam.TournamentLogic;
using TennisExam.People;

namespace TennisExam.Data
{
    public enum Nationalities { Albania, Belgium, Colombia, Denmark, England, France, Greece, Holland, Italy }
    public enum Genders { Male, Female }

    class AutoFillData
    {
        enum FirstNameMale { Anders, Bent, Charles, Danni, Erik, Finn, Gert, Hans, Ib }
        enum FirstNameFemale { Anni, Belina, Christina, Dina, Elisa, Fie, Gita, Henrietta, Ine }

        enum MiddleNames { Dahl, Friis, Holm, Nørgaard, Søndergaard, Lund, Juul, Kjær, Skov }
        enum LastNames { Østergaard, Jensen, Rasmussen, Jespersen, Pedersen, Petersen, Larsen, Nielsen, Andersen }

        private Tournament Tournament { get; set; }

        Random rand = new Random();

        public AutoFillData(Tournament tournament)
        {
            Tournament = tournament;
        }

        #region Auto create players
        private Player AutoCreatePlayer(Genders gender)
        {
            Player newPlayer = new Player();

            if (gender == Genders.Male)
            {
                newPlayer.FristName = Enum.GetName(typeof(FirstNameMale), RandomIndex());
                newPlayer.Gender = (int)Genders.Male;
            }
            else if (gender == Genders.Female)
            {
                newPlayer.FristName = Enum.GetName(typeof(FirstNameFemale), RandomIndex());
                newPlayer.Gender = Genders.Female;
            }
            newPlayer.MiddleName = Enum.GetName(typeof(MiddleNames), RandomIndex());
            newPlayer.LastName = Enum.GetName(typeof(LastNames), RandomIndex());
            newPlayer.DateOfBirth = RandomBirthDate();
            newPlayer.Nationality = RandomIndex();

            return newPlayer;
        }

        public void AutoAddPlayers()
        {
            var currentAddedMales = Tournament.Players.Count(player => player.Gender == Genders.Male);
            var currentAddedFemales = Tournament.Players.Count(player => player.Gender == Genders.Female);
            var currentAddedAmount = Tournament.Players.Count;

            switch (Tournament.TournamentType)
            {
                case TournamentTypes.SingleFemale:
                case TournamentTypes.DoubleFemale:
                    for (int i = 0; i < Tournament.TournamentSize - currentAddedAmount; i++)
                    {
                        Tournament.AddPlayer(AutoCreatePlayer(Genders.Female));
                    }
                    break;
                case TournamentTypes.SingleMale:
                case TournamentTypes.DoubleMale:
                    for (int i = 0; i < Tournament.TournamentSize - currentAddedAmount; i++)
                    {
                        Tournament.AddPlayer(AutoCreatePlayer(Genders.Male));
                    }
                    break;
                case TournamentTypes.MixDouble:
                    for (int i = 0; i < (Tournament.TournamentSize / 2) - currentAddedFemales; i++)
                    {
                        Tournament.AddPlayer(AutoCreatePlayer(Genders.Female));
                    }
                    for (int i = 0; i < (Tournament.TournamentSize / 2) - currentAddedMales; i++)
                    {
                        Tournament.AddPlayer(AutoCreatePlayer(Genders.Male));
                    }
                    break;
            }
        }
        #endregion

        #region Auto create referees
        private Referee AutoCreateReferee(Genders gender)
        {
            Referee newReferee = new Referee();

            if (gender == Genders.Male)
            {
                newReferee.FristName = Enum.GetName(typeof(FirstNameMale), RandomIndex());
                newReferee.Gender = Genders.Male;
            }
            else if (gender == Genders.Female)
            {
                newReferee.FristName = Enum.GetName(typeof(FirstNameFemale), RandomIndex());
                newReferee.Gender = Genders.Female;
            }
            newReferee.MiddleName = Enum.GetName(typeof(MiddleNames), RandomIndex());
            newReferee.LastName = Enum.GetName(typeof(LastNames), RandomIndex());
            newReferee.DateOfBirth = RandomBirthDate();
            newReferee.Nationality = RandomIndex();
            newReferee.LicenseAcquired = RandomBirthDate();
            newReferee.LicenseLastRenewed = RandomBirthDate();

            return newReferee;
        }

        public void AutoAddReferees()
        {
            var currentAddedMales = Tournament.Referees.Count(player => player.Gender == Genders.Male);
            var currentAddedFemales = Tournament.Referees.Count(player => player.Gender == Genders.Female);

            switch (Tournament.TournamentType)
            {
                case TournamentTypes.SingleFemale:
                case TournamentTypes.SingleMale:
                    for (int i = 0; i < (Tournament.TournamentSize / 4) - currentAddedFemales; i++)
                    {
                        Tournament.AddReferee(AutoCreateReferee(Genders.Female));
                    }
                    for (int i = 0; i < (Tournament.TournamentSize / 4) - currentAddedMales; i++)
                    {
                        Tournament.AddReferee(AutoCreateReferee(Genders.Male));
                    }
                    break;
                case TournamentTypes.DoubleFemale:
                case TournamentTypes.DoubleMale:
                case TournamentTypes.MixDouble:
                    for (int i = 0; i < (Tournament.TournamentSize / 8) - currentAddedFemales; i++)
                    {
                        Tournament.AddReferee(AutoCreateReferee(Genders.Female));
                    }
                    for (int i = 0; i < (Tournament.TournamentSize / 8) - currentAddedMales; i++)
                    {
                        Tournament.AddReferee(AutoCreateReferee(Genders.Male));
                    }
                    break;
            }

        }
        #endregion

        private int RandomIndex()
        {
            int randomIndex = rand.Next(0, 8);
            return randomIndex;
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