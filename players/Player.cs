using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace players
{
    internal class Player
    {
        private int _score { set; get; }
        private string _name { set; get; }

        public Player(string name, int score)
        {
            _score = score;
            _name = name;
        }

        public void Play(Player player)
        {
            var random = new Random();
            int num = random.Next(1, 2);
            if (num == 1) _score--;
            else player._score--;
        }

        public void ShowNameAndPoints()
        {
            Console.WriteLine($"Name: {_name}, Score: {_score}");
        }
    }
}
