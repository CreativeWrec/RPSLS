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
             public int pointsNeededToWin = 3;
        player1 = new Human();
        gestureOptions = new List<>

    }

    //Method (can do)
    public void RunGame()   //master method
    {
        DisplayRules();
        ChooseGameMode();

        ViewgestureOptions();
        // 1) Display rules (also include how many rounds!) [GAME]
        // 2) What are we playing (HvH or HvC) [GAME]

        /// One round of game ///
        // 3) Display gesture options [PLAYER]
        // 4) Player one chooses gesture [PLAYER]
        // 5) Player 2 chooses gesture [PLAYER/COMPUTER]
        // 6) Compare gestures(assign a point to round winner/check for tie!) [GAME]
        // 7) Display current score [GAME]
        // 8) Check for game winner (first of 3/5) [GAME]
        // if no
        // 9a) Display current score [GAME]
        // if yes
        // 9b) Display final result [GAME]
        // 10) Ask to play again?       [GAME]
    }

    public void DisplayRules()
    {
        Console.WriteLine("THESE ARE THE RULES");
        Console.WriteLine("THESE ARE THE RULES")
        }

    public void ChooseGameMode()
    {
        Console.WriteLine("Please enter 1 for HvC, or enter 2 for HvH")

            string userInput = Console.Realine();
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
        }
        else
        {
            //TODO: Try Again?
        }
    }


    }
    //Method (can do)
}

