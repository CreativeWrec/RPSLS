using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Computer : Player
    {
        //Variable (has a)

        //Constuctor
        public Computer()
        {
            

        }
        //Method (can do)
        public override void ChooseGesture()
        {
            // generate a random number 
            // user that random number to grab a random value out of the lsit of gestures using the random number as the index
            Random rng = new Random();
            int randomIndex = rng.Next(0, 5);
            chosenGesture = gestures[randomIndex];
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine();
            //}

        }
    }
}
