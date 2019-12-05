using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    class Generator
    {
        static Random Coincidence = new Random();

        public static String TeamBuilding()
        {
            int count = FootballTeam.country.Length;
            int number1 = Coincidence.Next(0, count);
            return FootballTeam.country[number1];
        }
    }
}
