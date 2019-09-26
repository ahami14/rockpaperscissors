using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public abstract class Player
    {
        //member vairables (Has A)
       public int score;
       public string gesture;
       public string name;

        //constructor (Spawner)

        //member methods (Can do)
        public abstract void ChooseGesture();
        //public abstract void ChooseName();//we can work with this later, focus on choosing human and computer classes rn
    }
}
