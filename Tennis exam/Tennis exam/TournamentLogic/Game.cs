using System;
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
        private static Random Rand { get; set; }
        public string DisplayableResult { get; private set; }
        public int Round { get; private set; }

        #region Constructor
        // Constructor to single matches
        public Game(Player player1, Player player2, int round, Random rand, TournamentTypes tournamentType)
        {
            Participants = new Player[2, 1];
            GameWinner = new Player[1];
            GameLoser = new Player[1];
            GameType = GameTypes.Single;
            Round = round;
            Rand = rand;
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
        public Game(Player[] team1, Player[] team2, int round, Random rand, TournamentTypes tournamentType)
        {
            Participants = new Player[2, 2];
            GameWinner = new Player[2];
            GameLoser = new Player[2];
            GameType = GameTypes.Double;
            Round = round;
            Rand = rand;
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

        public void PlayGame()
        {
            var player1GameScore = 0;
            var player2GameScore = 0;

            for (var i = 0; i < Sets.Length; i++)
            {
                var newSet = new Set();
                newSet.PlaySet(Rand);
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
            SetGameStatus(player1GameScore, player2GameScore);
            BuildDispResult(player1GameScore, player2GameScore);
        }

        private void SetGameStatus(int player1Score, int player2Score)
        {
            if (GameType == GameTypes.Single)
            {
                if (player1Score > player2Score)
                {
                    GameWinner[0] = Participants[0, 0];
                    GameLoser[0] = Participants[1, 0];
                }
                else
                {
                    GameWinner[0] = Participants[1, 0];
                    GameLoser[0] = Participants[0, 0];
                }
            }
            else if (GameType == GameTypes.Double)
            {
                if (player1Score > player2Score)
                {
                    GameWinner[0] = Participants[0, 0];
                    GameWinner[1] = Participants[0, 1];
                    GameLoser[0] = Participants[1, 0];
                    GameLoser[1] = Participants[1, 1];
                }
                else
                {
                    GameWinner[0] = Participants[1, 0];
                    GameWinner[1] = Participants[1, 1];
                    GameLoser[0] = Participants[0, 0];
                    GameLoser[1] = Participants[0, 1];
                }
            }
            else
            {
                throw new Exception("Unknown gametype.");
            }
        }

        private void BuildDispResult(int player1Score, int player2Score)
        {
            string result = "";
            if (player1Score > player2Score)
            {
                for (int i = 0; i < Sets.Length; i++)
                {
                    result = result + "(" + Sets[i].Score1 + ", " + Sets[i].Score2 + "), ";
                }
                DisplayableResult = result;
            }
            else
            {
                for (int i = 0; i < Sets.Length; i++)
                {
                    result = result + "(" + Sets[i].Score2 + ", " + Sets[i].Score1 + "), ";
                }
                DisplayableResult = result;
            }
        }

        public int SetsPlayed()
        {
            return Sets.Count(set => set != null);
        }

        public void AddReferee(Referee referee)
        {
            GameReferee = referee;
        }

        public void RemoveReferee()
        {
            GameReferee = null;
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
                    if (Participants[0, 0].Gender == Genders.Male && Participants[0, 1].Gender == Genders.Female
                        || Participants[0, 0].Gender == Genders.Female && Participants[0, 1].Gender == Genders.Male
                        && Participants[1, 0].Gender == Genders.Male && Participants[1, 1].Gender == Genders.Female
                        || Participants[1, 0].Gender == Genders.Female && Participants[1, 1].Gender == Genders.Male)
                    {
                        return true;
                    }
                    throw new Exception("One male and one female is needed on each team in a mix-double.");
            }
            throw new Exception("Unknown Tournament type in game validation");
        }
    }
}
