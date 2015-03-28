using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_exam.Classes
{
    class Tournament : Common
    {
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }
        public Player[] Players { get; set; }
        public Referee[] Referees { get; set; }
        public GameMaster GameMasterProp { get; set; }
        public int TournamentSize { get; set; }

        public Tournament(int amountOfPlayers)
        {
            int TournamentSize = amountOfPlayers;
            Players = new Player[TournamentSize];
            Referees = new Referee[TournamentSize];
            GameMasterProp = null;
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
        public void AddGamemaster(GameMaster gameMaster)
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
    }
}
