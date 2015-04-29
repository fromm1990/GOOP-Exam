using System;
using System.Collections.Generic;
using System.Linq;
using TennisExam.People;
using TennisExam.Data;

namespace TennisExam.TournamentLogic
{
    public enum TournamentTypes { SingleMale, SingleFemale, DoubleMale, DoubleFemale, MixDouble }

    internal class Tournament
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }
        public List<Player> Players { get; set; }
        public List<Referee> Referees { get; set; }
        public GameMaster GameMaster { get; set; }
        public int TournamentSize { get; set; }
        public TournamentTypes TournamentType { get; set; }
        public List<Game> Games { get; set; }
        public int Round { get; set; }

        public Tournament(string name, DateTime startsAt, DateTime endsAt, int amountOfPlayers, TournamentTypes tournamentType)
        {
            Name = name;
            TournamentSize = amountOfPlayers;
            Players = new List<Player>();
            Referees = new List<Referee>();
            GameMaster = null;
            TournamentType = tournamentType;
            Games = new List<Game>();
            Year = startsAt.Year;
            StartsAt = startsAt;
            EndsAt = endsAt;
            Round = 1;
        }

        #region Add/Remove Player or Referee

        public void AddPlayer(Player player)
        {
            if (Players.Count >= TournamentSize)
            {
                throw new Exception("All player slots are filled.");
            }

            Players.Add(player);
        }

        public void AddReferee(Referee referee)
        {
            if (Referees.Count >= TournamentSize / 2)
            {
                throw new Exception("All referee slots are filled.");
            }

            Referees.Add(referee);
        }

        public void RemovePlayer(Player player)
        {
            if (!Players.Remove(player))
            {
                throw new Exception("No such player");
            }
        }

        public void RemoveReferee(Referee referee)
        {
            if (!Referees.Remove(referee))
            {
                throw new Exception("No such referee");
            }
        }
        #endregion

        #region Add/Remove/Set Game master
        public void AddGameMaster(GameMaster gameMaster)
        {
            if (GameMaster == null)
            {
                GameMaster = gameMaster;
            }
            else
            {
                throw new Exception("You will have to remove the curent gamemaster.");
            }
        }

        public void SetGameMaster(Referee referee)
        {
            if (GameMaster == null)
            {
                var gamemaster = new GameMaster
                {
                    FirstName = referee.FirstName,
                    MiddleName = referee.MiddleName,
                    LastName = referee.LastName,
                    DateOfBirth = referee.DateOfBirth,
                    Nationality = referee.Nationality,
                    Gender = referee.Gender,
                    LicenseAcquired = referee.LicenseAcquired,
                    LicenseLastRenewed = referee.LicenseLastRenewed
                };

                GameMaster = gamemaster;
                RemoveReferee(referee);
            }
            else
            {
                throw new Exception("You will have to remove the curent gamemaster.");
            }

        }

        public void RemoveGamemaster()
        {
            GameMaster = null;
        }
        #endregion

        #region Sort Player or Referee
        public void SortPlayersByFirstName()
        {
            Players = Players.OrderBy(obj => obj.FirstName).ToList();
        }

        public void SortRefereesByFirstName()
        {
            Referees = Referees.OrderBy(obj => obj.FirstName).ToList();
        }

        public void SortPlayersByLastName()
        {
            Players = Players.OrderBy(obj => obj.LastName).ToList();
        }

        public void SortRefereesByLastName()
        {
            Referees = Referees.OrderBy(obj => obj.LastName).ToList();
        }
        #endregion

        #region Initialize gametypes

        private bool PlayerListValidation()
        {
            switch (TournamentType)
            {
                case TournamentTypes.SingleMale:
                case TournamentTypes.DoubleMale:
                    if (Players.Exists(player => player.Gender == Genders.Female))
                    {
                        throw new Exception("Both players will have to be males in a men's single.");
                    }
                    return true;

                case TournamentTypes.SingleFemale:
                case TournamentTypes.DoubleFemale:
                    if (Players.Exists(player => player.Gender == Genders.Male))
                    {
                        throw new Exception("Both players will have to be females in a womans's single.");
                    }
                    return true;
                case TournamentTypes.MixDouble:
                    var females = Players.FindAll(player => player.Gender == Genders.Female);
                    var males = Players.FindAll(player => player.Gender == Genders.Male);
                    if (females.Count != males.Count)
                    {
                        throw new Exception("One male and one female is needed on each team in a mix-double.");
                    }
                    return true;
            }
            throw new Exception("Player list validation failed");
        }

        private void InitializeSingle()
        {
            if (!PlayerListValidation()) return;
            var j = Players.Count - 1;

            for (var i = 0; i <= j; i++)
            {
                var newGame = new Game(Players[i], Players[j], Round, TournamentType);
                newGame.AddReferee(Referees[i]);
                Games.Add(newGame);
                j--;
            }
        }

        private void InitializeDouble()
        {
            if (!PlayerListValidation()) return;
            var j = Players.Count - 1;

            for (var i = 0; i <= j; i += 2)
            {
                var team1 = new Player[2];
                var team2 = new Player[2];

                team1[0] = Players[i];
                team1[1] = Players[i + 1];
                team2[0] = Players[j];
                team2[1] = Players[j - 1];

                var newGame = new Game(team1, team2, Round, TournamentType);
                newGame.AddReferee(Referees[i / 2]);
                Games.Add(newGame);
                j -= 2;
            }
        }

        private void InitializeMixDouble()
        {
            if (!PlayerListValidation()) return;
            var newPlayerList = new List<Player>(Players);

            for (var i = 0; i < Players.Count; i += 4)
            {
                var team1 = new Player[2];
                var team2 = new Player[2];

                team1[0] = SearchForMale(newPlayerList);
                team1[1] = SearchForFemale(newPlayerList);
                team2[0] = SearchForMale(newPlayerList);
                team2[1] = SearchForFemale(newPlayerList);

                var newGame = new Game(team1, team2, Round, TournamentType);
                newGame.AddReferee(Referees[i / 4]);
                Games.Add(newGame);
            }
        }

        private Player SearchForMale(List<Player> players)
        {
            var male = players.Find(o => o.Gender == Genders.Male);
            players.Remove(male);
            return male;
        }

        private Player SearchForFemale(List<Player> players)
        {
            var female = players.Find(o => o.Gender == Genders.Female);
            players.Remove(female);
            return female;
        }
        #endregion

        #region Play tournament
        public void PlayTournament()
        {
            if (GameMaster == null)
            {
                throw new Exception("You will have to add a game master in order to start the tournament.");
            }

            switch (TournamentType)
            {
                case TournamentTypes.SingleMale:
                case TournamentTypes.SingleFemale:
                    if (Referees.Count < TournamentSize / 2)
                    {
                        throw new Exception("You will need " + TournamentSize / 2 + " referees in order to start the tournament. You Currently have " + Referees.Count + " referees.");
                    }
                    if (Players.Count < TournamentSize)
                    {
                        throw new Exception("You will need to have exactly " + TournamentSize + " players, you currently have " + Players.Count + ".");
                    }
                    InitializeSingle();
                    PlayAllSingleRounds();
                    break;
                case TournamentTypes.DoubleMale:
                case TournamentTypes.DoubleFemale:
                    if (Referees.Count < TournamentSize / 4)
                    {
                        throw new Exception("You will need " + TournamentSize / 4 + " referees in order to start the tournament. You Currently have " + Referees.Count + " referees.");
                    }
                    if (Players.Count < TournamentSize)
                    {
                        throw new Exception("You will need to have exactly " + TournamentSize + " players, you currently have " + Players.Count + ".");
                    }
                    InitializeDouble();
                    PlayAllDoubleRounds();
                    break;
                case TournamentTypes.MixDouble:
                    if (Referees.Count < TournamentSize / 4)
                    {
                        throw new Exception("You will need " + TournamentSize / 4 + " referees in order to start the tournament. You Currently have " + Referees.Count + " referees.");
                    }
                    if (Players.Count < TournamentSize)
                    {
                        throw new Exception("You will need to have exactly " + TournamentSize / 2 + " male players, and exactly " + TournamentSize / 2 + " female players. " +
                                            "You currently have " + Players.Count(obj => obj.Gender == Genders.Male) + " male players and " + Players.Count(obj => obj.Gender == Genders.Female) + " female players.");
                    }
                    InitializeMixDouble();
                    PlayAllDoubleRounds();
                    break;
            }
        }

        private void PlayAllSingleRounds()
        {
            int totalRounds = (int)Math.Log(TournamentSize, 2);

            if (Round == 1)
            {
                for (int i = 0; i < Games.Count; i++)
                {
                    Games[i].PlayGame();
                }
                Round++;
            }

            while (Round <= totalRounds)
            {
                int offset = (int)Math.Pow(2, (totalRounds - (Round - 1)));
                int start = Games.Count - offset;
                int end = Games.Count;

                while (start < end)
                {
                    Player player1 = Games[start].GameWinner[0];
                    Player player2 = Games[start + 1].GameWinner[0];
                    Referee referee = Games[start].GameReferee;
                    Game newGame = new Game(player1, player2, Round, TournamentType);
                    newGame.AddReferee(referee);
                    if (newGame.GameValidation())
                    {
                        newGame.PlayGame();
                        Games.Add(newGame);
                    }
                    start += 2;
                }
                Round++;
            }
        }

        private void PlayAllDoubleRounds()
        {
            int totalRounds = (int)Math.Log(TournamentSize / 2, 2);

            if (Round == 1)
            {
                for (int i = 0; i < Games.Count; i++)
                {
                    Games[i].PlayGame();
                }
                Round++;
            }

            while (Round <= totalRounds)
            {
                int offset = (int)Math.Pow(2, (totalRounds - (Round - 1)));
                int start = Games.Count - offset;
                int end = Games.Count;

                while (start < end)
                {
                    Player[] team1 = new Player[2];
                    Player[] team2 = new Player[2];

                    team1[0] = Games[start].GameWinner[0];
                    team1[1] = Games[start].GameWinner[1];
                    team2[0] = Games[start + 1].GameWinner[0];
                    team2[1] = Games[start + 1].GameWinner[1];
                    Referee referee = Games[start].GameReferee;

                    Game newGame = new Game(team1, team2, Round, TournamentType);
                    newGame.AddReferee(referee);

                    if (newGame.GameValidation())
                    {
                        newGame.PlayGame();
                        Games.Add(newGame);
                    }
                    start += 2;
                }
                Round++;
            }
        }
        #endregion

        public bool IsTurnamentActive()
        {
            if (IsSingle())
            {
                return Games.Last().Round != (int)Math.Log(TournamentSize, 2);
            }

            return Games.Last().Round != (int)Math.Log(TournamentSize / 2, 2);
        }

        public Player[] TournamentWinner()
        {
            if (IsTurnamentActive()) throw new Exception("The winner is not found yet.");

            if (IsSingle())
            {
                var tournamentWinner = new Player[1];
                tournamentWinner[0] = Games[Games.Count - 1].GameWinner[0];
                return tournamentWinner;
            }
            else
            {
                var tournamentWinner = new Player[2];
                tournamentWinner[0] = Games[Games.Count - 1].GameWinner[0];
                tournamentWinner[1] = Games[Games.Count - 1].GameWinner[1];
                return tournamentWinner;
            }
        }

        public bool IsSingle()
        {
            return TournamentType == TournamentTypes.SingleFemale ||
                   TournamentType == TournamentTypes.SingleMale;
        }

        public bool IsDouble()
        {
            return TournamentType == TournamentTypes.DoubleFemale ||
                   TournamentType == TournamentTypes.DoubleMale ||
                   TournamentType == TournamentTypes.MixDouble;
        }

    }
}