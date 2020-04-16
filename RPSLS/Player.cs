using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    abstract class Player
    {
        //Variable (has a)
        public int score;
        public string chosenGesture;
        public List<string> gestures;
        //Constructor
        public Player()
        {
            score = 0;
            gestures = new List<string>
            {
                "Rock",
                "Paper",
                "Scissors",
                "Lizard",
                "Spock"
            };
        }
        //Method (can do)
        //choosing a gesture method

        public void ViewGestureOptions(List<string> gestureOptions) 
        {
            Console.WriteLine("Here are your gestures options"); 
           for(int i = 0; i < gestureOptions.Count; i++)
            {
                Console.WriteLine(gestureOptions[i]);
            }
        }

        public abstract void ChooseGesture();
    }
}
