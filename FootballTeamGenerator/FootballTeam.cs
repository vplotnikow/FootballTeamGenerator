using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    public class FootballTeam
    {
        private String name;

        public FootballTeam(String name)
        {
            this.name = name;
        }

        public override String ToString()
        {
            return name;
        }
    }
}
