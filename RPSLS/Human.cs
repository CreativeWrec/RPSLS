using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Human : Player
    {
        

        //Variable (Has a)


        //Constructor

        //Method()
        public override void ChooseGesture()
        {
            // logic for making the human choose a gesture goes here
            Console.WriteLine("Please choose your weapon for this round.");
            // set the chosenGesture variable equal to the users input
            string gesture = Console.ReadLine();
            chosenGesture = gesture;
        }
        
    }
}