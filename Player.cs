using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManager
{
    class Player
    {
        public Player(string name, string team)
        {
            Name = name;
            Team = team;
        }
        public string Name { get; set; }
        public string Team { get; set; }
        int Earned { get; set; }
        public static bool Add(string name)
        {
            return SQL.AddPlayer(name);
        }
    }
}
