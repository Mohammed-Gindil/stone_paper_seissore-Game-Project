using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stone_paper_seissore_Game_Project
{
    internal class ClassGame
    {
        enum enGameChoice { rock = 1, paper = 2, scissore = 3 };
        enum enWinner { player1 = 1, computer = 2, Drow = 3 };

        Random rd = new Random();

        public short GetRandomNumber(short from,short to)
        {
            return Convert.ToInt16(rd.Next(from, to));
        }

        public string GetComputerChoice()
        {
            string[] Choice = { "Rock", "Scissors","Paper"};
            return Choice[GetRandomNumber(0,3)]; 
        }

        public static string HowWin(string player1,string player2)
        {
            player1 = player1.ToLower();
            player2 = player2.ToLower();

            if (player1 == player2)
            {
                return "Drow";
            }

            if (player1 == "rock" && player2 == "scissors")
            {
                return "player1";
            }
            else if (player1 == "paper" && player2 == "rock")
            {
                return "player1";
            }
            else if (player1 == "scissors" && player2 == "paper")
            {
                return "player1";
            }
            else
            {
                return "computer";
            }
        }

        public static string WinName(short player1, short player2)
        {
            if (player1 > player2)
            {
                return "player1";

            }
            else if( player2 > player1)
            {
                return "Computer";
            }
            else
            {
                return "Drow";
            }
        }

    }

}
