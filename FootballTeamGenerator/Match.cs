using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    class Match
    {
        private Team _team1;
        private Team _team2;

        public Match()
        {
        }

        public Match(Team team1, Team team2)
        {
            _team1 = team1;
            _team2 = team2;
        }

        public override String ToString()
        {
            return "Team 1 " + _team1.ToString() + "\n" + "Team 2 " + _team2.ToString();
        }

        public Team Team1    
        {
            get => _team1;
            set => _team1 = value;
        }

        public Team Team2    
        {
            get => _team2;
            set => _team2 = value;
        }
    }
}
