using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_exam.Classes
{
    public enum Nationalities { Albania, Belgium, Colombia, Denmark, England, France, Greece, Holland, Italy }
    public enum Genders { Male, Female }

    class AutoFillData
    {
        enum FirstNameMale { Anders, Bent, Charles, Danni, Erik, Finn, Gert, Hans, Ib }
        enum FirstNameFemale { Anni, Belina, Christina, Dina, Elisa, Fie, Gita, Henrietta, Ine }

        enum MiddleNames { Dahl, Friis, Holm, Nørgaard, Søndergaard, Lund, Juul, Kjær, Skov }
        enum LastNames { Østergaard, Jensen, Rasmussen, Jespersen, Pedersen, Petersen, Larsen, Nielsen, Andersen }

        Random rand = new Random();

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

        public void AutoAddPlayers(Tournament tournament)
        {
            var currentAddedMales = tournament.Players.Count(player => player.Gender == Genders.Male);
            var currentAddedFemales = tournament.Players.Count(player => player.Gender == Genders.Female);
            var currentAddedAmount = tournament.Players.Count;

            switch (tournament.TournamentType)
            {
                case TournamentTypes.SingleFemale:
                case TournamentTypes.DoubleFemale:
                    for (int i = 0; i < tournament.TournamentSize - currentAddedAmount; i++)
                    {
                        tournament.AddPlayer(AutoCreatePlayer(Genders.Female));
                    }
                    break;
                case TournamentTypes.SingleMale:
                case TournamentTypes.DoubleMale:
                    for (int i = 0; i < tournament.TournamentSize - currentAddedAmount; i++)
                    {
                        tournament.AddPlayer(AutoCreatePlayer(Genders.Male));
                    }
                    break;
                case TournamentTypes.MixDouble:
                    for (int i = 0; i < (tournament.TournamentSize / 2) - currentAddedFemales; i++)
                    {
                        tournament.AddPlayer(AutoCreatePlayer(Genders.Female));
                    }
                    for (int i = 0; i < (tournament.TournamentSize / 2) - currentAddedMales; i++)
                    {
                        tournament.AddPlayer(AutoCreatePlayer(Genders.Male));
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

        public void AutoAddReferees(Tournament tournament)
        {
            var currentAddedMales = tournament.Referees.Count(player => player.Gender == Genders.Male);
            var currentAddedFemales = tournament.Referees.Count(player => player.Gender == Genders.Female);

            switch (tournament.TournamentType)
            {
                case TournamentTypes.SingleFemale:
                case TournamentTypes.SingleMale:
                    for (int i = 0; i < (tournament.TournamentSize / 4) - currentAddedFemales; i++)
                    {
                        tournament.AddReferee(AutoCreateReferee(Genders.Female));
                    }
                    for (int i = 0; i < (tournament.TournamentSize / 4) - currentAddedMales; i++)
                    {
                        tournament.AddReferee(AutoCreateReferee(Genders.Male));
                    }
                    break;
                case TournamentTypes.DoubleFemale:
                case TournamentTypes.DoubleMale:
                case TournamentTypes.MixDouble:
                    for (int i = 0; i < (tournament.TournamentSize / 8) - currentAddedFemales; i++)
                    {
                        tournament.AddReferee(AutoCreateReferee(Genders.Female));
                    }
                    for (int i = 0; i < (tournament.TournamentSize / 8) - currentAddedMales; i++)
                    {
                        tournament.AddReferee(AutoCreateReferee(Genders.Male));
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