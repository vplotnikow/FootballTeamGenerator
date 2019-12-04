using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FootballTeamGenerator
{
    class Textfile_Teams
    {
        public static void ImportTeams()
        {
            

            if (File.Exists(@".\FootballTeams.txt") && new FileInfo(@".\FootballTeams.txt").Length != 0)
            {
                Country.country = File.ReadAllLines(@".\FootballTeams.txt");
                //var words = File.ReadLines(@".\FootballTeams.txt").Count();

            }
            else
            {
                File.WriteAllLines(@".\FootballTeams.txt", Country.country);
            }
        }
    }
}
