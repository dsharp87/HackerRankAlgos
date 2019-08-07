using System;
using System.Collections.Generic;
using System.Linq;

namespace comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] names = new string[]{"james", "jacky", "ben", "sarah"};
            int[] scores  = new int[]{12,12,18,5};
            List<Player> players = new List<Player>();
            for(int i = 0; i < names.Length; i++)
            {
                Player p = new Player(names[i],scores[i]);
                players.Add(p);
            }

            players = players.OrderByDescending(p => p.score).ThenBy(p => p.name).ToList();
            System.Console.WriteLine("yolo");
        }

    }


    class Player
    {
        public string name {get; set;}

        public int score {get; set;}

        public Player(string n, int s)
        {
            this.name = n;
            this.score = s;
        }
    }

    


}
