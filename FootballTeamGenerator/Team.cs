using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    public class Team
    {
        public List<Player> _player;
        private FootballTeam _footballTeam;

        public Team(List<Player> player, FootballTeam _footballTeam)
        {
            this._player = player;
            this._footballTeam = _footballTeam;
        }

        public override string ToString()
        {
            if (_player.Count == 1)
            {
                return this._player[0].ToString() + " = " + _footballTeam.ToString();
            }

            return this._player[0].ToString() +" & " +  this._player[1].ToString() + " = " + _footballTeam.ToString();
        }
    }
}
