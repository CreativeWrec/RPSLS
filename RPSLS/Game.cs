using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        //Variable (has a)
        public List<string> gestureOptions;
        public int pointsNeededToWin;
        public Player player1;
        public Player player2;

        //Constuctor
        public Game()
        {
            pointsNeededToWin = 3;
            player1 = new Human();
            gestureOptions = new List<string>()
            {
                "Rock",
                "Paper",
                "Scissors",
                "Lizard",
                "Spock"
            };
        }

        //Method (can do)
        public void RunGame()   //master method
        {
            DisplayRules();
            ChooseGameMode();
            while (player1.score < pointsNeededToWin && player2.score < pointsNeededToWin)
            {
                ViewGestureOptions();
                player1.ChooseGesture();
                player2.ChooseGesture();
                CompareChoices();
            }
            DisplayGameWinner();
            ///

            // 1) Display rules (also include how many rounds!) [GAME]
            // 2) What are we playing (HvH or HvC) [GAME]

            /// One round of game ///
            // 3) Display gesture options                                           [PLAYER]
            // 4) Player one chooses gesture                                        [PLAYER]
            // 5) Player 2 chooses gesture                                          [PLAYER]
            // 6) Compare gestures(assign a point to round winner/check for tie!)   [GAME]
            // 7) Display current score                                             [GAME]
            // 8) Check for game winner (first of 3/5)                              [GAME]
            // if no
            // 9a) Display current score                                            [GAME]
            // if yes
            // 9b) Display final result                                             [GAME]
            // 10) Ask to play again?   +                                           [GAME]
        }

        public void DisplayRules()
        {
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
        }

        public void DisplayGestures()
        {
            foreach(string choice in gestureOptions)
            {
                Console.WriteLine(choice);
            }
        }

        public void ChooseGameMode()
        {
            Console.WriteLine("Please enter 1 for HvC, or enter 2 for HvH");

            string userInput = Console.ReadLine();
            //what if they don't type in 1 or 2

            if (userInput == "1")
            {
                //HvC game
                player1 = new Human();
                player2 = new Computer();
            }
            else if (userInput == "2")
            {
                //HvH
                player1 = new Human();
                player2 = new Human();
            }
            else
            {
                //TODO: Try Again?
                Console.WriteLine("Better Luck Next Time, Let's Try That Again!");
                ChooseGameMode();
            }
        }
        public void ViewGestureOptions()
        {
            List<string> Gestures = new List<string>
            {
                "Rock",
                "Paper",
                "Scissors",
                "Lizard",
                "Spock"
            };
        }

        public void CompareChoices()
        {

            if (player1.chosenGesture == player2.chosenGesture)
            {
                //this is a tie
                Console.WriteLine("Tie! Press Enter to Continue");
                Console.ReadLine();
            }
            else if (player1.chosenGesture == "Rock" && (player2.chosenGesture == "Paper" || player2.chosenGesture == "Spock"))
            {
                //player2 won the round
                Console.WriteLine("Player2 has won the round");
                player2.score++;
            }
            else if (player1.chosenGesture == "Rock" && (player2.chosenGesture == "Scissors" || player2.chosenGesture == "Lizard"))
            {
                Console.WriteLine("Player1 has won the round");
                player1.score++;
            }
            else if (player1.chosenGesture == "Paper" && (player2.chosenGesture == "Scissors" || player2.chosenGesture == "Lizard"))
            {
                Console.WriteLine("Player2 has won the round");
                player2.score++;
            }
            else if (player1.chosenGesture == "Paper" && (player2.chosenGesture == "Spock" || player2.chosenGesture == "Rock"))
            {
                Console.WriteLine("Player1 has won the round");
                player1.score++;
            }
            else if (player1.chosenGesture == "Scissors" && (player2.chosenGesture == "Rock" || player2.chosenGesture == "Spock"))
            {
                Console.WriteLine("Player2 has won the round");
                player2.score++;
            }
            else if (player1.chosenGesture == "Scissors" && (player2.chosenGesture == "Paper" || player2.chosenGesture == "Lizard"))
            {
                Console.WriteLine("Player1 has won the round");
                player1.score++;
            }
            else if (player1.chosenGesture == "Lizard" && (player2.chosenGesture == "Scissors" || player2.chosenGesture == "Rock"))
            {
                Console.WriteLine("Player2 has won the round");
                player2.score++;
            }
            else if (player1.chosenGesture == "Lizard" && (player2.chosenGesture == "Paper" || player2.chosenGesture == "Spock"))
            {
                Console.WriteLine("Player1 has won the round");
                player1.score++;
            }
            else if (player1.chosenGesture == "Spock" && (player2.chosenGesture == "Lizard" || player2.chosenGesture == "Paper"))
            {
                Console.WriteLine("Player2 has won the round");
                player2.score++;
            }
            else if (player1.chosenGesture == "Spock" && (player2.chosenGesture == "Rock" || player2.chosenGesture == "Scissors"))
            {
                Console.WriteLine("Player1 has won the round");
                player1.score++;
            }

            
        }

        public void DisplayGameWinner()
        {
            if (player1.score == pointsNeededToWin)
            {
                Console.WriteLine("Player1 Wins! Game Over");
                Console.WriteLine("Wanna Play Again?" );
                ChooseGameMode();
            }
            else if (player2.score == pointsNeededToWin)
            {
                Console.WriteLine("Player2 Wins! Game Over");
                Console.WriteLine("Wanna Play Again?");
                ChooseGameMode();
            }
        }



    }

}

