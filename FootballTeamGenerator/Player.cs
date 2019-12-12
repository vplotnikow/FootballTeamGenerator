using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    class Player
    {
        private String name;

        public Player(String name)
        {
            this.name = name;
        }

        public override String ToString()
        {
            return name;
        }
    }
}
