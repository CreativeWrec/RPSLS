using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Player
    {
        //Variable (has a)
        public int score;
        public string chosenGesture;
       
        //Constructor
        public Player()
        {
            score = 0;
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
    }
}
