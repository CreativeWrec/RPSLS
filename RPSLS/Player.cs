using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Player
    {
        //Variable (has a)
        public string name;
        public int score;
        public int choice;
        //Constructor
        public Player()
        {
            score = 0;
        }
        //Method (can do)
        public virtual void Choice(List<string> choices)
        {
            choice = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine(name +)
        }

    }
}
