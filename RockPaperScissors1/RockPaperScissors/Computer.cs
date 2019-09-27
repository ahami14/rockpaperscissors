using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Computer : Player
    {
        //member variable (Has A)

        //constructor (Spawner)
        public Computer()
        {

        }

        //member methods (Can Do)
        public override void ChooseGesture()
        {
            //This will be rng, make a list, randomize the index of the list and whichever index it gets is what will be given
            //we need an object reference, so somehow get it to reference the list 

            Random rng = new Random();

            int index = rng.Next(gestures.Count);
            
            gesture = gestures[index];
            Console.WriteLine("random: " + gesture);
        }
    }
}
