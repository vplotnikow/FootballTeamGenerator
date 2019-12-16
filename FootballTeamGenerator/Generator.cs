using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FootballTeamGenerator
{
    public class Generator
    {
        private Random Coincidence = new Random();

        private String[] _defaultFootballTeams = { "England", "Austria", "Belgium", "Bulgaria", "Czech Republic", "Denmark",
                            "Finland", "France", "Germany", "Greece", "Italy", "Norway", "Poland", "Portugal",  "Ireland", "Romania",
                            "Russia", "Scottland", "Slovenia", "Spain", "Sweden", "Schwitzerland", "Turkey",
                            "Wales", "Argentina", "Brazil", "Paraguay", "Uruguay", "Mexico", "USA", "Cameroon", "China", "Australia",
                            "Hungary", "Netherlands", "Northern Ireland", "South Africa", "Peru", "Colombia", "Ivory Coast", "Egypt", "Bolivia",
                            "Canada", "Chile", "Ecuador", "India", "Venezuela" };

        
        public List<Player> PlayerGenerator(List<Player> playerlist)
        {
            List<Player> playerlist1 = new List<Player>(playerlist);
            for (int i = 0; i < playerlist.Count; i++)
            {
                int number = Coincidence.Next(0, playerlist.Count);
                while (playerlist[number] == null)
                {
                    number = Coincidence.Next(0, playerlist.Count);
                }
                playerlist1[i] = playerlist[number];
                playerlist[number] = null;
            }

            return playerlist1;
        }

        public FootballTeam GetRandomFootballTeam()
        {
            int count = DefaultFootballTeams.Length;

            int number1 = Coincidence.Next(0, count);
            FootballTeam footballteam = new FootballTeam(DefaultFootballTeams[number1]);

            return footballteam;
        }

        public List<Team> CreateTeams(List<Player> playerliste1)
        {
            List<Player> playerliste = PlayerGenerator(playerliste1);

            FootballTeam footballteam1 = GetRandomFootballTeam();
            FootballTeam footballteam2 = GetRandomFootballTeam();

            List<Player> playerlistTeam1 = new List<Player>();
            List<Player> playerlistTeam2 = new List<Player>();


            if (playerliste.Count() == 2)
            {
                playerlistTeam1.Add(playerliste[0]);
                playerlistTeam2.Add(playerliste[1]);
            }
            else if (playerliste.Count() == 4)
            {
                playerlistTeam1.Add(playerliste[0]);
                playerlistTeam1.Add(playerliste[1]);
                playerlistTeam2.Add(playerliste[2]);
                playerlistTeam2.Add(playerliste[3]);
            }

            Team team1 = new Team(playerlistTeam1, footballteam1);
            Team team2 = new Team(playerlistTeam2, footballteam2);

            List<Team> teamList = new List<Team>();
            teamList.Add(team1);
            teamList.Add(team2);

            return teamList;
        }

        public string[] DefaultFootballTeams
        {
            get => _defaultFootballTeams;
            set => _defaultFootballTeams = value;
        }
    }
}
