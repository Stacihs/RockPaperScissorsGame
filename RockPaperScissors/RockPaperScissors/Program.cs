using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static bool play = true;

        static void Main(string[] args)
        {
            
            Console.WriteLine("Press Enter to Play rock, paper, scissors");
            Console.ReadLine();


            do
            {
                Console.WriteLine("Player 1:  Rock, Paper, or Scissors?");
                string hand1 = Console.ReadLine();

                Console.WriteLine("Player 2:  Rock, Paper, or Scissors?");
                string hand2 = Console.ReadLine();

                string response = Response(hand1, hand2);
                Console.WriteLine(response);

                Console.WriteLine("Do You wish to play again? (y/n)");
                
                if (Console.ReadLine() == "n")
                    play = false;
                Console.Clear();
            } while (play);
            
        }

        public static string Response(string hand1, string hand2)
        {

            hand1 = hand1.ToLower();
            hand2 = hand2.ToLower();

            string[] options = new string[] { "paper", "rock", "scissors" };
            if (!options.Contains(hand1) || !options.Contains(hand2))
            {
                return "Error: You did not select an correct option";
            }

            string player1 = "Player 1 Wins!";
            string player2 = "Player 2 Wins!";
            
            if (hand1 == hand2)
            {
                return "It's a tie!";
            }
            if (hand1 == "rock")
            {
                if (hand2 == "paper")
                {
                    return "Player 2 Wins!";
                }
                else
                {
                    return "Player 1 Wins!";
                }
                      

            }
            if (hand1 == "paper")
            {
                if (hand2 == "scissors")
                {
                    return player2;
                }
                else
                {
                    return player1;
                }
            }
            if (hand1 == "scissors")
            {
                if (hand2 == "rock")
                {
                    return player2;
               
                }
                else
                {
                    return player1;
                }
            }
            
            return "";
        }
    }

  
