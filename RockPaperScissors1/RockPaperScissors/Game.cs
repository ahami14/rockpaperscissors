using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        //member vairables (Has A)
        Player one;
        Player two;
        
        //constructor (Spawner)
        

        //member methods (Can do)
        public void RunGame()
        {
            int numberPlayers = GetNumberOfPlayers();
            CreatePlayers(numberPlayers);
            
        }
        public void DisplayRules() 
        {
            Console.WriteLine("The Player will choose Rock, Paper, Scissors, Lizard, or Spock.");
            Console.WriteLine("Afterwards, it will be revealed whether the Player beat the opponent, be it computer or second Player.");
            Console.WriteLine("The game will be played best of 3.");
        }
        public int GetNumberOfPlayers()
        {
            Console.WriteLine("How many players are there?");
            int numberPlayers = int.Parse(Console.ReadLine());
            return numberPlayers;
        }
        public void CreatePlayers(int numberPlayers)
        {
            if(numberPlayers == 1)
            {
                one = new Human();
                two = new Computer();
            }
            else if(numberPlayers == 2)
            {
                one = new Human();
                two = new Human();
            }
        }

        
            
        





        //display rules for game : game does this
        //choose if player would like to verse another player or computer
        //Allow player to choose Rock, Paper, Scissors, Lizard, or Spock
        //Allow computer to randomly generate their answer based on a number 1-5
        //determine round winner, increment winner score
        //best of 3
        //check if game winner, if yes line beneath this one, if no, loop into next round where players choose gestures : Game does this
            //to check this potentially use player score
        //ask if they would like to play again, start game over 

        //make 2 more classes potentially for human and computer, can use inheritance: This would be a good idea for you
        //abstract methods for gesture and player name


        //for creating PVP and PVC: create a method for how many players you want, then create another method that contains an if statement
        //then do something like if you choose 1, then create a computer and if you choose 2, make player 2 = human
    }
}
