using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponovni_pokusaj
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> bot_options = new List<string> { "ROCK", "PAPER", "SCISSORS" };

            Random R = new Random();
            int index = R.Next(bot_options.Count);
            string bot_answer = bot_options[index];
            string input = Console.ReadLine();
            string player_answer = input.ToUpper();
            List<string> list1 = new List<string>();
            list1.Add(player_answer);
           
            list1.Add(bot_answer);
            var list2 = new List<string>();
            list2.Add(player_answer);

            list2.Add(bot_answer);
            list2.Sort();
            /*List<Order> SortedList = objListOrder.OrderBy(o=>o.OrderDate).ToList();*/

            bool who_wins = list1.SequenceEqual(list2.Sort());


            Console.WriteLine(" {0} wins.", who_wins ? "player" : "bot");
         while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
    
}
