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
        Player playerone;
        Player playertwo;

        //constructor (Spawner)
        public Game()
        {
            //playerone = new Player();
            //playertwo = new Player();
        }

        //member methods (Can do)
        public void RunGame()
        {
            int numberPlayers = GetNumberOfPlayers();
            CreatePlayers(numberPlayers);
            DisplayRules();
            while (playerone.score < 2 && playertwo.score < 2)
            {
                playerone.ChooseGesture();
                playertwo.ChooseGesture();
                CompareAnswers(playerone, playertwo);
                CompareAnswers(playertwo, playerone);
                DisplayScore();
            }
            DisplayGameWinner();
            
            
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
                playerone = new Human();
                playertwo = new Computer();
            }
            else if(numberPlayers == 2)
            {
                playerone = new Human();
                playertwo = new Human();
            }
        }
        public void CompareAnswers(Player playerone, Player playertwo)//long if else statement 
        {
            if (playerone.gesture == "Rock" && playertwo.gesture == "Scissors")
            {
                Console.WriteLine("Rock crushes Scissors! Player one wins this round!");
                playerone.score++;
            }
            else if (playerone.gesture == "Scissors" && playertwo.gesture == "Paper")
            {
                Console.WriteLine("Scissors cuts paper! Player one wins this round!");
                playerone.score++;
            }
            else if (playerone.gesture == "Paper" && playertwo.gesture == "Rock")
            {
                Console.WriteLine("Paper covers Rock! Player one wins this round!");
                playerone.score++;
            }
            else if (playerone.gesture == "Rock" && playertwo.gesture == "Lizard")
            {
                Console.WriteLine("Rock crushes Lizard! Player one wins this round!");
                playerone.score++;
            }
            else if (playerone.gesture == "Lizard" && playertwo.gesture == "Spock")
            {
                Console.WriteLine("Lizard poisons Spock! Player one wins this round!");
                playerone.score++;
            }
            else if (playerone.gesture == "Spock" && playertwo.gesture == "Scissors")
            {
                Console.WriteLine("Spock smashes Scissors! Player one wins this round!");
                playerone.score++;
            }
            else if (playerone.gesture == "Scissors" && playertwo.gesture == "Lizard")
            {
                Console.WriteLine("Scissors decapitates Lizard! Player one wins this round!");
                playerone.score++;
            }
            else if (playerone.gesture == "Lizard" && playertwo.gesture == "Paper")
            {
                Console.WriteLine("Lizard eats Paper! Player one wins this round!");
                playerone.score++;
            }
            else if (playerone.gesture == "Paper" && playertwo.gesture == "Spock")
            {
                Console.WriteLine("Paper disproves Spock! Player one wins this round!");
                playerone.score++;
            }
            else if(playerone.gesture == "Spock" && playertwo.gesture == "Rock")
            {
                Console.WriteLine("Spock vaporizes Rock! Player one wins this round!");//This is the last one for player one
                playerone.score++;
            }
            else if(playerone.gesture == playertwo.gesture)
            {
                Console.WriteLine("It is a tie!");
            }
        }

        public void DisplayScore()
        {
           Console.WriteLine("Player One's score is: " + playerone.score);
            Console.WriteLine("Opponent's score is: " + playertwo.score);
            Console.ReadLine();
        }

        public void DisplayGameWinner()
        {
            if(playerone.score > playertwo.score)
            {
                Console.WriteLine("Congratultions Player One! You won the game!");
            }
            else if(playerone.score < playertwo.score)
            {
                Console.WriteLine("Congratulations Player Two! You wont the game!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
            Console.ReadLine();
        }
        
           
    }
}
