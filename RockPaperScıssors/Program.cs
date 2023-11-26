using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScıssors
{
    class Program
    {
        static void Main(string[] args)
        {
            int rnum;
            string player, computer,agaın;
            bool playagaın = true;
            Random rnd = new Random();
            

            while (playagaın) {

                player = "";
                computer = "";
                while (player != "ROCK" && player!="PAPER"&& player!="SCISSORS")
                {
                    Console.WriteLine("ENTER ROCK PAPER OR SCISSORS");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }
                rnum = rnd.Next(1, 4);
                switch(rnum)
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;

                }
                Console.WriteLine("PLAYER : {0}",player);
                Console.WriteLine("COMPUTER : {0}",computer);

                switch (player)
                {
                    case "ROCK":
                        if(computer=="ROCK")
                            Console.WriteLine("DRAW");
                       else if(computer=="PAPER")
                            Console.WriteLine("YOU LOST");
                        else Console.WriteLine("YOU WIN");
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                            Console.WriteLine("YOU WIN");
                        else if (computer == "PAPER")
                            Console.WriteLine("YOU DRAW");
                        else Console.WriteLine("YOU LOST");
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                            Console.WriteLine("YOU LOST");
                        else if (computer == "PAPER")
                            Console.WriteLine("YOU WIN");
                        else Console.WriteLine("YOU DRAW");
                        break;
                        
                        




                }
                    
                    
                        
             }
            Console.ReadLine();
        }
    }
}
