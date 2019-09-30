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

            Random rng = new Random();

            int index = rng.Next(gestures.Count);
            
            gesture = gestures[index];
            Console.WriteLine("random: " + gesture);
        }
    }
}
