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
            while (one.score < 2 && two.score < 2)
            {
                one.ChooseGesture();
                two.ChooseGesture();
                CompareAnswers();
                DisplayScore();
            }
            
            
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
        public void CompareAnswers()//long if else statement 
        {
            if (one.gesture == "Rock" && two.gesture == "Scissors")
            {
                Console.WriteLine("Rock crushes Scissors! Player one wins this round!");
                one.score++;
            }
            else if (one.gesture == "Scissors" && two.gesture == "Paper")
            {
                Console.WriteLine("Scissors cuts paper! Player one wins this round!");
                one.score++;
            }
            else if (one.gesture == "Paper" && two.gesture == "Rock")
            {
                Console.WriteLine("Paper covers Rock! Player one wins this round!");
                one.score++;
            }
            else if (one.gesture == "Rock" && two.gesture == "Lizard")
            {
                Console.WriteLine("Rock crushes Lizard! Player one wins this round!");
                one.score++;
            }
            else if (one.gesture == "Lizard" && two.gesture == "Spock")
            {
                Console.WriteLine("Lizard poisons Spock! Player one wins this round!");
                one.score++;
            }
            else if (one.gesture == "Spock" && two.gesture == "Scissors")
            {
                Console.WriteLine("Spock smashes Scissors! Player one wins this round!");
                one.score++;
            }
            else if (one.gesture == "Scissors" && two.gesture == "Lizard")
            {
                Console.WriteLine("Scissors decapitates Lizard! Player one wins this round!");
                one.score++;
            }
            else if (one.gesture == "Lizard" && two.gesture == "Paper")
            {
                Console.WriteLine("Lizard eats Paper! Player one wins this round!");
                one.score++;
            }
            else if (one.gesture == "Paper" && two.gesture == "Spock")
            {
                Console.WriteLine("Paper disproves Spock! Player one wins this round!");
                one.score++;
            }
            else if(one.gesture == "Spock" && two.gesture == "Rock")
            {
                Console.WriteLine("Spock vaporizes Rock! Player one wins this round!");//This is the last one for player one
                one.score++;
            }
            if (two.gesture == "Rock" && one.gesture == "Scissors")
            {
                Console.WriteLine("Rock crushes Scissors! Opponent wins this round!");
                two.score++;
            }
            else if (two.gesture == "Scissors" && one.gesture == "Paper")
            {
                Console.WriteLine("Scissors cuts paper! Opponent wins this round!");
                two.score++;
            }
            else if (two.gesture == "Paper" && one.gesture == "Rock")
            {
                Console.WriteLine("Paper covers Rock! Opponent wins this round!");
                two.score++;
            }
            else if (two.gesture == "Rock" && one.gesture == "Lizard")
            {
                Console.WriteLine("Rock crushes Lizard! Opponent wins this round!");
                two.score++;
            }
            else if (two.gesture == "Lizard" && one.gesture == "Spock")
            {
                Console.WriteLine("Lizard poisons Spock! Opponent wins this round!");
                two.score++;
            }
            else if (two.gesture == "Spock" && one.gesture == "Scissors")
            {
                Console.WriteLine("Spock smashes Scissors! Opponent wins this round!");
                two.score++;
            }
            else if (two.gesture == "Scissors" && one.gesture == "Lizard")
            {
                Console.WriteLine("Scissors decapitates Lizard! Opponent wins this round!");
                two.score++;
            }
            else if (two.gesture == "Lizard" && one.gesture == "Paper")
            {
                Console.WriteLine("Lizard eats Paper! Opponent wins this round!");
                two.score++;
            }
            else if (two.gesture == "Paper" && one.gesture == "Spock")
            {
                Console.WriteLine("Paper disproves Spock! Opponent wins this round!");
                two.score++;
            }
            else if (two.gesture == "Spock" && one.gesture == "Rock")
            {
                Console.WriteLine("Spock vaporizes Rock! Opponent wins this round!");
                two.score++;
            }
            else if(one.gesture == two.gesture)
            {
                Console.WriteLine("It is a tie!");
            }
        }

        public void DisplayScore()
        {
           Console.WriteLine("Player One's score is: " + one.score);
            Console.WriteLine("Opponent's score is: " + two.score);
            Console.ReadLine();
        }

        public void DisplayGameWinner()
        {
            
        }
        
            
        





        //display rules for game : game does this (Done)
        //choose if player would like to verse another player or computer (Done)
        //Allow player to choose Rock, Paper, Scissors, Lizard, or Spock (DOne)
        //Allow computer to randomly generate their answer based on a number 1-4 (Done)
        //determine round winner, increment winner score : Game does this (Done)
        //best of 3
        //check if game winner, if yes line beneath this one, if no, loop into next round where players choose gestures : Game does this(Done)
            //to check this potentially use player score
        //ask if they would like to play again, start game over 

        //make 2 more classes potentially for human and computer, can use inheritance: This would be a good idea for you
        //abstract methods for gesture and player name


        //for creating PVP and PVC: create a method for how many players you want, then create another method that contains an if statement
        //then do something like if you choose 1, then create a computer and if you choose 2, make player 2 = human
    }
}
