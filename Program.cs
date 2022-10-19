using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Lists
{
    class Program
    {
        public static int number_Pwins = 0;
        public static int number_Bwins = 0;

        static void  PlayerWins()
        {
            number_Pwins += 1;
            Console.WriteLine($" The Player has {number_Pwins}  Wins!");


        }
       static  void BotWins()
        {
            number_Bwins += 1;
            Console.WriteLine($" The Bot has {number_Bwins}  Wins!");
            
        }
        static void DeclareWiner()
        {
            if (number_Pwins == 3 || number_Bwins == 3 )
            {
                Console.WriteLine($"Finnal score is: Player: {number_Pwins} Bot: {number_Bwins}  ");
            }
        }

        static void Main(string[] args)
        {
            List<string> bot_options = new List<string> { "ROCK", "PAPER", "SCISSORS" };

            

            while (true)
                {
                

                Random R = new Random();
                int index = R.Next(bot_options.Count);
                string bot_answer = bot_options[index];
                string input = Console.ReadLine();
                string player_answer = input.ToUpper();

                List<string> list1 = new List<string>();
                    list1.Add(player_answer);
                    list1.Add(bot_answer);
                    list1.ForEach(Console.WriteLine);
                while (player_answer != "ROCK" && player_answer != "PAPER" && player_answer != "SCISSORS")
                {
                    Console.WriteLine("Enter Rock, Paper,Scissors!");
                    string wronginput = Console.ReadLine();
                    string upperString = wronginput.ToUpper();
                    if (upperString == "ROCK" || upperString == "PAPER" || upperString == "SCISSORS")
                        break;
                }

                if (bot_answer != player_answer)
                    {


                        var sortedList = list1.OrderBy(x => x).ToList();
                        bool who_wins = list1.SequenceEqual(sortedList);

                        if (player_answer == "PAPER" && bot_answer == "SCISSORS")
                        {
                            who_wins = false;
                        }
                        Console.WriteLine(" {0} wins.", who_wins ? "player" : "bot");

                        if (who_wins == true)
                        PlayerWins(); 
                        else  
                        BotWins(); 
                    }
                    else
                    {
                        Console.WriteLine("It's a Draw");
                    }
                
                if (number_Bwins >= 3 || number_Pwins >= 3)

                    break;
                

            }




            DeclareWiner();

            

            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}


