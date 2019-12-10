using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FootballTeamGenerator
{
    class Generator
    {
        private Random Coincidence = new Random();

        private String[] _defaultFootballTeams = { "England", "Österreich", "Belgien", "Bulgarien", "Tschechische Republik", "Dänemark",
                            "Finnland", "Frankreich", "Deutschland", "Griechenland", "Italien", "Norwegen", "Polen", "Portugal",  "Irland", "Rumänien",
                            "Russland", "Schottland", "Slowenien", "Spanien", "Schweden", "Schweiz", "Türkei",
                            "Wales", "Argentinien", "Brasilien", "Paraguay", "Uruguay", "Mexiko", "USA", "Kamerun", "China", "Australien",
                            "Ungarn", "Niederlande", "Nordirland", "Südafrika", "Peru", "Kolumbien", "Elfenbeinküste", "Ägypten", "Bolivien",
                            "Kanada", "Chile", "Ecuador", "Indien", "Venezuela" };

        public List<Player> PlayerGenerator(List<Player> playerliste)
        {
            List<Player> playerliste1 = new List<Player>(playerliste);
            for (int i = 0; i < playerliste.Count; i++)
            {
                int number = Coincidence.Next(0, playerliste.Count);
                while (playerliste[number] == null)
                {
                    number = Coincidence.Next(0, playerliste.Count);
                }
                playerliste1[i] = playerliste[number];
                playerliste[number] = null;
            }
            return playerliste1;
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

            List<Player> playerlisteTeam1 = new List<Player>();
            List<Player> playerlisteTeam2 = new List<Player>();


            if (playerliste.Count() == 2)
            {
                playerlisteTeam1.Add(playerliste[0]);
                playerlisteTeam2.Add(playerliste[1]);
            }
            else if (playerliste.Count() == 4)
            {
                playerlisteTeam1.Add(playerliste[0]);
                playerlisteTeam1.Add(playerliste[1]);
                playerlisteTeam2.Add(playerliste[2]);
                playerlisteTeam2.Add(playerliste[3]);
            }

            Team team1 = new Team(playerlisteTeam1, footballteam1);
            Team team2 = new Team(playerlisteTeam2, footballteam2);

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
