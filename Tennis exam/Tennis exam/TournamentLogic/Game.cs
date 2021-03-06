﻿using System;
using System.Linq;
using TennisExam.People;
using TennisExam.Data;

namespace TennisExam.TournamentLogic
{
    internal class Game
    {
        public enum GameTypes { Single, Double }

        public Player[,] Participants { get; private set; }
        public Player[] GameWinner { get; private set; }
        public Player[] GameLoser { get; private set; }
        public Set[] Sets { get; private set; }
        public GameTypes GameType { get; private set; }
        private TournamentTypes TournamentType { get; set; }
        public Referee GameReferee { get; private set; }
        public string DisplayableResult { get; private set; }
        public int Round { get; private set; }

        #region Constructor
        // Constructor to single matches
        public Game(Player player1, Player player2, int round, TournamentTypes tournamentType)
        {
            Participants = new Player[2, 1];
            GameWinner = new Player[1];
            GameLoser = new Player[1];
            GameType = GameTypes.Single;
            Round = round;
            TournamentType = tournamentType;

            switch (tournamentType)
            {
                case TournamentTypes.SingleFemale:
                    Sets = new Set[3];
                    break;
                case TournamentTypes.SingleMale:
                    Sets = new Set[5];
                    break;
            }

            Participants[0, 0] = player1;
            Participants[1, 0] = player2;
        }
        // Constructor to double matches
        public Game(Player[] team1, Player[] team2, int round, TournamentTypes tournamentType)
        {
            Participants = new Player[2, 2];
            GameWinner = new Player[2];
            GameLoser = new Player[2];
            GameType = GameTypes.Double;
            Round = round;
            TournamentType = tournamentType;

            switch (tournamentType)
            {
                case TournamentTypes.DoubleFemale:
                    Sets = new Set[3];
                    break;
                case TournamentTypes.DoubleMale:
                case TournamentTypes.MixDouble:
                    Sets = new Set[5];
                    break;
            }

            Participants[0, 0] = team1[0];
            Participants[0, 1] = team1[1];
            Participants[1, 0] = team2[0];
            Participants[1, 1] = team2[1];
        }
        #endregion

        #region Add/remove GameReferee
        public void AddReferee(Referee referee)
        {
            GameReferee = referee;
        }

        public void RemoveReferee()
        {
            GameReferee = null;
        }
        #endregion

        public void PlayGame()
        {
            var player1GameScore = 0;
            var player2GameScore = 0;

            for (int i = 0; i < Sets.Length; i++)
            {
                var newSet = new Set();
                newSet.PlaySet();
                Sets[i] = newSet;

                if (newSet.Score1 > newSet.Score2)
                {
                    player1GameScore++;
                }
                else
                {
                    player2GameScore++;
                }
            }

            SetGameWinner(player1GameScore, player2GameScore);
            SetGameLooser(player1GameScore, player2GameScore);

            BuildDisplayableResult(player1GameScore, player2GameScore);
        }

        private void SetGameWinner(int player1Score, int player2Score)
        {
            switch (GameType)
            {
                case GameTypes.Single:
                    if (player1Score > player2Score)
                    {
                        GameWinner[0] = Participants[0, 0];
                    }
                    else
                    {
                        GameWinner[0] = Participants[1, 0];
                    }
                    break;
                case GameTypes.Double:
                    if (player1Score > player2Score)
                    {
                        GameWinner[0] = Participants[0, 0];
                        GameWinner[1] = Participants[0, 1];
                    }
                    else
                    {
                        GameWinner[0] = Participants[1, 0];
                        GameWinner[1] = Participants[1, 1];
                    }
                    break;
                default:
                    throw new Exception("Unknown gametype.");
            }
        }

        private void SetGameLooser(int player1Score, int player2Score)
        {
            switch (GameType)
            {
                case GameTypes.Single:
                    if (player1Score > player2Score)
                    {
                        GameLoser[0] = Participants[1, 0];
                    }
                    else
                    {
                        GameLoser[0] = Participants[0, 0];
                    }
                    break;
                case GameTypes.Double:
                    if (player1Score > player2Score)
                    {
                        GameLoser[0] = Participants[1, 0];
                        GameLoser[1] = Participants[1, 1];
                    }
                    else
                    {
                        GameLoser[0] = Participants[0, 0];
                        GameLoser[1] = Participants[0, 1];
                    }
                    break;
                default:
                    throw new Exception("Unknown gametype.");
            }
        }

        private void BuildDisplayableResult(int player1Score, int player2Score)
        {
            string result = null;

            if (player1Score > player2Score)
            {
                for (int i = 0; i < Sets.Length; i++)
                {
                    if (i == Sets.Length - 1)
                    {
                        result += "[" + Sets[i].Score1 + " | " + Sets[i].Score2 + "]";
                    }
                    else
                    {
                        result += "[" + Sets[i].Score1 + " | " + Sets[i].Score2 + "] - ";
                    }

                }

                DisplayableResult = result;
            }
            else
            {
                for (int i = 0; i < Sets.Length; i++)
                {
                    if (i == Sets.Length - 1)
                    {
                        result += "[" + Sets[i].Score2 + " | " + Sets[i].Score1 + "]";
                    }
                    else
                    {
                        result += "[" + Sets[i].Score2 + " | " + Sets[i].Score1 + "] - ";
                    }
                }
                DisplayableResult = result;
            }
        }

        public int SetsPlayed()
        {
            return Sets.Count(set => set != null);
        }

        public bool GameValidation()
        {
            switch (TournamentType)
            {
                case TournamentTypes.SingleMale:
                    if (Participants[0, 0].Gender == Genders.Male
                        && Participants[1, 0].Gender == Genders.Male)
                    {
                        return true;
                    }
                    throw new Exception("Both players will have to be males in a men's single.");
                case TournamentTypes.SingleFemale:
                    if (Participants[0, 0].Gender == Genders.Female
                        && Participants[1, 0].Gender == Genders.Female)
                    {
                        return true;
                    }
                    throw new Exception("Both players will have to be females in a womans's single.");

                case TournamentTypes.DoubleMale:
                    if (Participants[0, 0].Gender == Genders.Male
                        && Participants[0, 1].Gender == Genders.Male
                        && Participants[1, 0].Gender == Genders.Male
                        && Participants[1, 1].Gender == Genders.Male)
                    {
                        return true;
                    }
                    throw new Exception("All players will have to be males in a mens's double.");
                case TournamentTypes.DoubleFemale:
                    if (Participants[0, 0].Gender == Genders.Female
                        && Participants[0, 1].Gender == Genders.Female
                        && Participants[1, 0].Gender == Genders.Female
                        && Participants[1, 1].Gender == Genders.Female)
                    {
                        return true;
                    }
                    throw new Exception("All players will have to be females in a women's double.");
                case TournamentTypes.MixDouble:
                    var malesCount = 0;
                    var femalesCount = 0;

                    for (var i = 0; i < Participants.GetLength(0); i++)
                    {
                        for (var j = 0; j < Participants.GetLength(1); j++)
                        {
                            switch (Participants[i, j].Gender)
                            {
                                case Genders.Male:
                                    malesCount++;
                                    break;
                                case Genders.Female:
                                    femalesCount++;
                                    break;
                            }
                        }
                    }

                    if (malesCount == femalesCount)
                    {
                        return true;
                    }

                    throw new Exception("One male and one female is needed on each team in a mix-double.");
            }
            throw new Exception("Unknown Tournament type in game validation");
        }

    }
}
