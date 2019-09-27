using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Human : Player
    {
        //member variable (Has A)

        //constructor (Spawner)
        public Human()
        {

        }

        //member methods (Can Do)
        public override void ChooseGesture()
        {
            Console.WriteLine("Choose your gesture: Rock, Paper, Scissors, Lizard, or Spock");
        }

    }
}
