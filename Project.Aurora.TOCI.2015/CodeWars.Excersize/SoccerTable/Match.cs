using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Excersize.SoccerTable
{
    public class Match
    {
        public string Team1 { get; set; }
        public int Team1Score { get; set; }
        public string Team2 { get; set; }
        public int Team2Score { get; set; }
        //0- team1 won, 1- draw, 2-team2 won
        public int Result { get; set; }
    }
}
