using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    class MatchMaker
    {
        private List<Player> _playerliste;

        public MatchMaker()
        {

        }

        public MatchMaker(List<Player> _playerliste)
        {
            this._playerliste = _playerliste;
        }

        public Match CreateMatch()
        {
            
            Match match = new Match();
            Generator generator = new Generator();
            FileManager files = new FileManager();
            files.ImportTeams(generator);
            List<Team> teams = generator.CreateTeams(_playerliste);

            match.Team1 = teams[0];
            match.Team2 = teams[1];
              
            return match;
        }

        
                   

    } 
          
}    







