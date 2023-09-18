using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {
            
        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n\n Rock breaks Scissors \n Scissors cuts Paper \n Paper covers Rock \n Rock squishes Lizard \n Lizard bites Spock \n Spock breaks Scissors \n Scissors chops Lizard \n Lizard rips Paper \n Paper controls Spock \n Spock destroys rock \n\nThe game will be best of 3!");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("Will there be 1 or 2 players playing?");
            int playerNum = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return playerNum;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            
            if (numberOfHumanPlayers == 1)
            {
                Console.WriteLine("Please enter your name:");
                string playerName1 = Console.ReadLine();
                playerOne = new HumanPlayer(playerName1);
                playerTwo = new ComputerPlayer();
            }
            else if (numberOfHumanPlayers == 2)
            {
                Console.WriteLine("Please enter Player 1's name:");
                string playerName1 = Console.ReadLine();
                playerOne = new HumanPlayer(playerName1);

                Console.WriteLine();

                Console.WriteLine("Please enter Player 2's name:");
                string playerName2 = Console.ReadLine();
                playerTwo = new HumanPlayer(playerName2);
            }
            else
            {
                Console.WriteLine("Invalid number of players.");
            }
        }

        public void CompareGestures()
        {
            playerOne.ChooseGesture();
            Console.WriteLine();
            playerTwo.ChooseGesture();

            Console.WriteLine();

            Console.WriteLine($"{playerOne.name} chose {playerOne.chosenGesture}");
            Console.WriteLine();
            Console.WriteLine($"{playerTwo.name} chose {playerTwo.chosenGesture}");

            Console.WriteLine();

            if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((playerOne.gestures[0] == playerOne.chosenGesture && playerTwo.gestures[2] == playerTwo.chosenGesture) || (playerOne.gestures[2] == playerOne.chosenGesture && playerTwo.gestures[1] == playerTwo.chosenGesture) || (playerOne.gestures[1] == playerOne.chosenGesture && playerTwo.gestures[0] == playerTwo.chosenGesture) || (playerOne.gestures[0] == playerOne.chosenGesture && playerTwo.gestures[3] == playerTwo.chosenGesture) || (playerOne.gestures[3] == playerOne.chosenGesture && playerTwo.gestures[4] == playerTwo.chosenGesture) || (playerOne.gestures[4] == playerOne.chosenGesture && playerTwo.gestures[2] == playerTwo.chosenGesture) || (playerOne.gestures[2] == playerOne.chosenGesture && playerTwo.gestures[3] == playerTwo.chosenGesture) || (playerOne.gestures[3] == playerOne.chosenGesture && playerTwo.gestures[1] == playerTwo.chosenGesture) || (playerOne.gestures[1] == playerOne.chosenGesture && playerTwo.gestures[4] == playerTwo.chosenGesture) || (playerOne.gestures[4] == playerOne.chosenGesture && playerTwo.gestures[0] == playerTwo.chosenGesture))
            {
                Console.WriteLine($"{playerOne.name} wins!");
                playerOne.score++;
            }
            else
            {
                Console.WriteLine($"{playerTwo.name} wins!");
                playerTwo.score++; 
            }

            Console.WriteLine($"Score: {playerOne.score} - {playerTwo.score}");

            Console.WriteLine();
        }

        public void DisplayGameWinner()
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine($"{playerOne.name} wins the game!");
            }
            else if (playerTwo.score == 2)
            {
                Console.WriteLine($"{playerTwo.name} wins the game!");
            }
        }

        public void RunGame()
        {
            WelcomeMessage();

            Console.WriteLine();

            CreatePlayerObjects(ChooseNumberOfHumanPlayers());

            Console.WriteLine();

            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                CompareGestures();
            }

            Console.WriteLine();

            DisplayGameWinner();
        }
    }
}
