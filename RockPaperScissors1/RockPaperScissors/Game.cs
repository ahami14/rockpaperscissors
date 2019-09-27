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
        public Game()
        {

        }

        //member methods (Can do)
        public void RunGame()
        {
            int numberPlayers = GetNumberOfPlayers();
            CreatePlayers(numberPlayers);
            DisplayRules();
            one.ChooseGesture();
            two.ChooseGesture();
            CompareAnswers();
            
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
        public void CompareAnswers()//long if else statement that somehow says we cannot compare datatypes 
        {
            if (one.gesture == "Rock" && two.gesture == "Scissors")
            {
                Console.WriteLine("Rock crushes Scissors!");
                one.score++;
            }
            else if (one.gesture == "Scissors" && two.gesture == "Paper")
            {
                Console.WriteLine("Scissors cuts paper!");
                one.score++;
            }
            else if (one.gesture == "Paper" && two.gesture == "Rock")
            {
                Console.WriteLine("Paper covers Rock!");
                one.score++;
            }
            else if (one.gesture == "Rock" && two.gesture == "Lizard")
            {
                Console.WriteLine("Rock crushes Lizard!");
                one.score++;
            }
            else if (one.gesture == "Lizard" && two.gesture == "Spock")
            {
                Console.WriteLine("Lizard poisons Spock!");
                one.score++;
            }
            else if (one.gesture == "Spock" && two.gesture == "Scissors")
            {
                Console.WriteLine("Spock smashes Scissors!");
                one.score++;
            }
            else if (one.gesture == "Scissors" && two.gesture == "Lizard")
            {
                Console.WriteLine("Scissors decapitates Lizard!");
                one.score++;
            }
            else if (one.gesture == "Lizard" && two.gesture == "Paper")
            {
                Console.WriteLine("Lizard eats Paper!");
                one.score++;
            }
            else if (one.gesture == "Paper" && two.gesture == "Spock")
            {
                Console.WriteLine("Paper disproves Spock!");
                one.score++;
            }
            else if(one.gesture == "Spock" && two.gesture == "Rock")
            {
                Console.WriteLine("Spock vaporizes Rock!");//This is the last one for player one
                one.score++;
            }
            if (two.gesture == "Rock" && one.gesture == "Scissors")
            {
                Console.WriteLine("Rock crushes Scissors!");
                two.score++;
            }
            else if (two.gesture == "Scissors" && one.gesture == "Paper")
            {
                Console.WriteLine("Scissors cuts paper!");
                two.score++;
            }
            else if (two.gesture == "Paper" && one.gesture == "Rock")
            {
                Console.WriteLine("Paper covers Rock!");
                two.score++;
            }
            else if (two.gesture == "Rock" && one.gesture == "Lizard")
            {
                Console.WriteLine("Rock crushes Lizard!");
                two.score++;
            }
            else if (two.gesture == "Lizard" && one.gesture == "Spock")
            {
                Console.WriteLine("Lizard poisons Spock!");
                two.score++;
            }
            else if (two.gesture == "Spock" && one.gesture == "Scissors")
            {
                Console.WriteLine("Spock smashes Scissors!");
                two.score++;
            }
            else if (two.gesture == "Scissors" && one.gesture == "Lizard")
            {
                Console.WriteLine("Scissors decapitates Lizard!");
                two.score++;
            }
            else if (two.gesture == "Lizard" && one.gesture == "Paper")
            {
                Console.WriteLine("Lizard eats Paper!");
                two.score++;
            }
            else if (two.gesture == "Paper" && one.gesture == "Spock")
            {
                Console.WriteLine("Paper disproves Spock!");
                two.score++;
            }
            else if (two.gesture == "Spock" && one.gesture == "Rock")
            {
                Console.WriteLine("Spock vaporizes Rock!");
                two.score++;
            }
            else if(one.gesture == two.gesture)
            {
                Console.WriteLine("It is a tie!");
            }
            Console.ReadLine();
        }

        
            
        





        //display rules for game : game does this
        //choose if player would like to verse another player or computer
        //Allow player to choose Rock, Paper, Scissors, Lizard, or Spock
        //Allow computer to randomly generate their answer based on a number 1-4
        //determine round winner, increment winner score : Game does this
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
