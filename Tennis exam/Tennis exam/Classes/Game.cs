using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_exam.Classes
{
    internal class Game
    {
        public Player[,] Participants { get; set; }
        public Player[] GameWinner { get; set; }
        public Player[] GameLoser { get; set; }
        public Set[] Sets { set; get; }
        public string GameType { get; set; }
        public string Referee { get; set; }
        private Random Rand { get; set; }
        public string DisplayableResult { get; set; }
        public int Round { get; set; }

        #region Constructor
        // Constructor to single matches
        public Game(Player player1, Player player2, int round, Random rand)
        {
            Participants = new Player[2, 1];
            GameWinner = new Player[1];
            GameLoser = new Player[1];
            Sets = new Set[3];
            GameType = "single";
            Round = round;
            Rand = rand;

            Participants[0, 0] = player1;
            Participants[1, 0] = player2;
        }
        // Constructor to double matches
        public Game(Player[] team1, Player[] team2, int round, Random rand)
        {
            Participants = new Player[2, 2];
            GameWinner = new Player[2];
            GameLoser = new Player[2];
            Sets = new Set[3];
            GameType = "double";
            Round = round;
            Rand = rand;

            Participants[0, 0] = team1[0];
            Participants[0, 1] = team1[1];
            Participants[1, 0] = team2[0];
            Participants[1, 1] = team2[1];
        }
        #endregion

        public void PlayGame(int sets)
        {
            int player1GameScore = 0;
            int player2GameScore = 0;

            for (int i = 0; i < sets; i++)
            {
                Set newSet = new Set();
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
            if ( GameType == "single")
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
            else
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
        }

        private void BuildDispResult(int player1Score, int player2Score)
        {
            string result = "";
            if (player1Score > player2Score)
            {
                for (int i = 0; i < Sets.Length ; i++)
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
    }
}
