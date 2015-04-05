using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_exam.Classes
{
    class Game
    {
        public Player[,] Participants { get; set; }
        public Player[] GameWinner { get; set; }
        public Set[] Sets { set; get; }
        public string GameType { get; set; }

        private Random rand = new Random();

        // Constructor to single matches
        public Game(Player player1, Player player2)
        {
            Participants = new Player[2, 1];
            GameWinner = new Player[1];
            GameType = "single";

            Participants[0, 0] = player1;
            Participants[1, 0] = player2;
        }
        // Constructor to double matches
        public Game(Player[] team1, Player[] team2)
        {
            Participants = new Player[2, 1];
            GameWinner = new Player[2];
            GameType = "double";

            Participants[0, 0] = team1[0];
            Participants[0, 1] = team1[1];
            Participants[1, 0] = team2[0];
            Participants[1, 1] = team2[1];
        }

        public void PlayGame(int sets)
        {
            int player1GameScore = 0;
            int player2GameScore = 0;

            for (int i = 0; i < sets; i++)
            {
                Set newSet = new Set();
                newSet.PlaySet();
                Sets[i] = newSet;

                if (newSet.Score1 > newSet.Score2)
                {
                    player1GameScore += 1;
                }
                else
                {
                    player2GameScore += 1;
                }
            }
            SetGameWinner(player1GameScore, player2GameScore);            
        }

        private void SetGameWinner(int player1Score, int player2Score)
        {
            if ( GameType == "single")
            {
                if (player1Score > player2Score)
                {
                    GameWinner[0] = Participants[0, 0];
                }
                else
                {
                    GameWinner[0] = Participants[1, 0];
                }
            }
            else
            {
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
            }
               
        }
    }
}
