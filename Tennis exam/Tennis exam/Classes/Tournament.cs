using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_exam.Classes
{
    public enum TournamentTypes { SingleMale, SingleFemale, DoubleMale, DoubleFemale, MixDouble }

    internal class Tournament : Common
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }
        public Player[] Players { get; set; }
        public Referee[] Referees { get; set; }
        public GameMaster GameMasterProp { get; set; }
        public int TournamentSize { get; set; }
        public TournamentTypes TournamentType { get; set; }
        public List<Game> Games { get; set; }
        public int Round { get; set; }
        private Random Rand { get; set; }

        public Tournament(string name, DateTime startsAt, DateTime endsAt, int amountOfPlayers, TournamentTypes tournamentType)
        {
            Name = name;
            TournamentSize = amountOfPlayers;
            Players = new Player[TournamentSize];
            Referees = new Referee[TournamentSize / 2];
            GameMasterProp = null;
            TournamentType = tournamentType;
            Games = new List<Game>();
            Year = startsAt.Year;
            Round = 1;
            Rand = new Random();
        }

        #region Add/Remove Player or Referee
        private bool Add(Object element, Object[] array)
        {
            int index = EmptyObjectArrayIndex(array);
            if (index >= 0)
            {
                array[index] = element;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Remove(Object element, Object[] array)
        {
            int index = FindElementIndex(element, array);
            if (index >= 0)
            {
                Players[index] = null;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddPlayer(Player player)
        {
            if (!Add(player, Players))
            {
                throw new Exception("All player slots are filled.");
            }
        }

        public void AddReferee(Referee referee)
        {
            if (!Add(referee, Referees))
            {
                throw new Exception("All referee slots are filled.");
            }
        }

        public void RemovePlayer(Player player)
        {
            if (!Remove(player, Players))
            {
                throw new Exception("No such player");
            }
        }

        public void RemoveReferee(Referee referee)
        {
            if (!Remove(referee, Referees))
            {
                throw new Exception("No such referee");
            }
        }
        #endregion

        #region Add/Remove/Set Game master
        public void AddGameMaster(GameMaster gameMaster)
        {
            if (GameMasterProp == null)
            {
                GameMasterProp = gameMaster;
            }
            else
            {
                throw new Exception("You will have to remove the curent gamemaster.");
            }
        }

        public void SetGameMaster(Referee referee)
        {
            if (GameMasterProp == null)
            {
                GameMaster gamemaster = new GameMaster();
                //gamemaster = (GameMaster)referee;
                gamemaster.FristName = referee.FristName;
                gamemaster.MiddleName = referee.MiddleName;
                gamemaster.LastName = referee.LastName;
                gamemaster.DateOfBirth = referee.DateOfBirth;
                gamemaster.Nationality = referee.Nationality;
                gamemaster.Gender = referee.Gender;
                gamemaster.LicenseAcquired = referee.LicenseAcquired;
                gamemaster.LicenseLastRenewed = referee.LicenseLastRenewed;

                GameMasterProp = gamemaster;
                RemoveReferee(referee);
            }
            else
            {
                throw new Exception("You will have to remove the curent gamemaster.");
            }

        }

        public void RemoveGamemaster()
        {
            if (GameMasterProp != null)
            {
                GameMasterProp = null;
            }
            else
            {
                throw new Exception("No gamemaster to delete.");
            }
        }
        #endregion

        #region Sort Player or Referee
        public void SortByFirstName(Player[] objectArray)
        {
            Array.Sort(objectArray,
                delegate(Player x, Player y)
                {
                    if (x == null)
                    {
                        return y == null ? 0 : 1;
                    }
                    if (y == null)
                    {
                        return -1;
                    }
                    return x.FristName.CompareTo(y.FristName);
                });
        }

        public void SortByFirstName(Referee[] objectArray)
        {
            Array.Sort(objectArray,
                delegate(Referee x, Referee y)
                {
                    if (x == null)
                    {
                        return y == null ? 0 : 1;
                    }
                    if (y == null)
                    {
                        return -1;
                    }
                    return x.FristName.CompareTo(y.FristName);
                });
        }

        public void SortByLastName(Player[] objectArray)
        {
            Array.Sort(objectArray,
                delegate(Player x, Player y)
                {
                    if (x == null)
                    {
                        return y == null ? 0 : 1;
                    }
                    if (y == null)
                    {
                        return -1;
                    }
                    return x.LastName.CompareTo(y.LastName);
                });
        }

        public void SortByLastName(Referee[] objectArray)
        {
            Array.Sort(objectArray,
                delegate(Referee x, Referee y)
                {
                    if (x == null)
                    {
                        return y == null ? 0 : 1;
                    }
                    if (y == null)
                    {
                        return -1;
                    }
                    return x.LastName.CompareTo(y.LastName);
                });
        }
        #endregion

        #region Initialize gametypes
        private void InitializeSingle()
        {
            int j = Players.Length - 1;
            int k = 0;

            for (int i = 0; i <= j; i++)
            {
                Game newGame = new Game(Players[i], Players[j], Referees[k] , Round, Rand);
                Games.Add(newGame);
                j--;
                k++;
            }
        }

        private void InitializeDouble()
        {
            int j = Players.Length - 1;
            int k = 0;

            for (int i = 0; i <= j; i += 2)
            {
                Player[] team1 = new Player[2];
                Player[] team2 = new Player[2];

                team1[0] = Players[i];
                team1[1] = Players[i + 1];
                team2[0] = Players[j];
                team2[1] = Players[j - 1];

                Game newGame = new Game(team1, team2, Referees[k], Round, Rand);
                Games.Add(newGame);
                j -= 2;
                k++;
            }
        }

        private void InitializeMixDouble()
        {
            Player[] newPlayerArray = (Player[])Players.Clone();
            int j = 0;
            int k = 0;

            for (int i = 0; i < newPlayerArray.Length; i += 4)
            {
                Player[] team1 = new Player[2];
                Player[] team2 = new Player[2];

                team1[0] = Players[SearchForMale(newPlayerArray)];
                team1[1] = Players[SearchForFemale(newPlayerArray)];
                team2[0] = Players[SearchForMale(newPlayerArray)];
                team2[1] = Players[SearchForFemale(newPlayerArray)];

                Game newGame = new Game(team1, team2, Referees[k], Round, Rand);
                Games.Add(newGame);
                j++;
                k++;
            }
        }

        private int SearchForMale(Player[] players)
        {
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i] != null && players[i].Gender == Genders.Male)
                {
                    players[i] = null;
                    return i;
                }
            }
            return -1;
        }

        private int SearchForFemale(Player[] players)
        {

            for (int i = 0; i < players.Length; i++)
            {
                if (players[i] != null && players[i].Gender == Genders.Female)
                {
                    players[i] = null;
                    return i;
                }
            }
            return -1;
        }
        #endregion

        #region Play tournament
        public void PlayTournament(TournamentTypes tournamentType)
        {
            switch (tournamentType)
            {
                case TournamentTypes.SingleMale:
                case TournamentTypes.SingleFemale:
                    InitializeSingle();
                    PlayAllSingleRounds();
                    break;
                case TournamentTypes.DoubleMale:
                case TournamentTypes.DoubleFemale:
                    InitializeDouble();
                    PlayAllDoubleRounds();
                    break;
                case TournamentTypes.MixDouble:
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
                for (int i = 0; i < Games.Count; i++ )
                {
                    Games[i].PlayGame(3);
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
                    Game newGame = new Game(player1, player2, referee, Round, Rand);
                    newGame.PlayGame(3);
                    Games.Add(newGame);
                    start += 2;
                }
                Round++;
            }
        }

        private void PlayAllDoubleRounds()
        {
            int totalRounds = (int)Math.Log(TournamentSize/2, 2);

            if (Round == 1)
            {
                for (int i = 0; i < Games.Count; i++)
                {
                    Games[i].PlayGame(3);
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

                    Game newGame = new Game(team1, team2, referee, Round, Rand);
                    newGame.PlayGame(3);
                    Games.Add(newGame);
                    start += 2;
                }
                Round++;
            }
        }
        #endregion

        private int LastPlayedRound()
        {
            return Games[Games.Count - 1].Round;
        }

        public bool IsTurnamentActive()
        {
            if (IsSingle())
            {
                return LastPlayedRound() != (int)Math.Log(TournamentSize, 2) ? true : false;
            }
            else
            {
                return LastPlayedRound() != (int)Math.Log(TournamentSize / 2, 2) ? true : false;
            }
        }

        public Player[] TournamentWinner()
        {
            if (!IsTurnamentActive())
            {
                if (IsSingle())
                {
                    Player[] tournamentWinner = new Player[1];
                    tournamentWinner[0] = Games[Games.Count - 1].GameWinner[0];
                    return tournamentWinner;
                }
                else
                {
                    Player[] tournamentWinner = new Player[2];
                    tournamentWinner[0] = Games[Games.Count - 1].GameWinner[0];
                    tournamentWinner[1] = Games[Games.Count - 1].GameWinner[1];
                    return tournamentWinner;
                }
            }
            else
            {
                throw new Exception("The winner is not found yet.");
            }         
        }

        public bool IsSingle()
        {
            return  TournamentType == TournamentTypes.SingleFemale || 
                    TournamentType == TournamentTypes.SingleMale 
                    ? true : false;
        }

        public bool IsDouble()
        {
            return  TournamentType == TournamentTypes.DoubleFemale || 
                    TournamentType == TournamentTypes.DoubleMale || 
                    TournamentType == TournamentTypes.MixDouble 
                    ? true : false;
        }
    }
}