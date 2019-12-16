using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FootballTeamGenerator
{
    public class InputOutputHandler
    {
        public String[] Playernames;
        private const String versionNumber = "v2.0";
        private const string _welcomeText = "-----------------------------------------------------------------" + versionNumber + "\n                                                             ___\n  o__                                                 o__   |   |\\ \n /|       Welcome To The Football Team Generator!     /\\    |   |X\\\n / > o                                                 <\\   |   |XX\\\n---------------------------------------------------------------------\n";
        private const string _incorrectNumberOfPeople = "The number of people is incorrect. Please enter the number of people again.";
        private const string _enterOfPlayerNames = "Please enter the player names one by one and confirm after every name with the ENTER key. \n";
        private const string _emptyField = "The field cannot be empty. You have to enter a name.";

        public int NumberOfPlayers { get; set; }

        public void ReadUserInput(string[] consoleParameter)
        {
            if (consoleParameter.Length != 0)
            {
                NumberOfPlayers = consoleParameter.Length;
                Playernames = consoleParameter;
            }
            else
            {
                NumberOfPlayers = Convert.ToInt32(Console.ReadLine());
                Playernames = new String[NumberOfPlayers];
            }

            while (NumberOfPlayers != 2 && NumberOfPlayers != 4)
            {
                Console.WriteLine(_incorrectNumberOfPeople);
                NumberOfPlayers = Convert.ToInt32(Console.ReadLine());
                Playernames = new String[NumberOfPlayers];
            }

            Console.WriteLine("Okay, " + NumberOfPlayers + " Players");
            Console.WriteLine("");

            if (consoleParameter.Length == 0)
            {
                Console.WriteLine(_enterOfPlayerNames);
                for (int i = 0; i < NumberOfPlayers; i++)
                {
                    Console.WriteLine("Player " + (i + 1) + ":");
                    Playernames[i] = Console.ReadLine();
                    while (Playernames[i] == "")
                    {
                        Console.WriteLine(_emptyField);
                        Playernames[i] = Console.ReadLine();
                    }
                }

                FileManager manager = new FileManager();
                manager.WritingInATextfile(Playernames);
            }
        }

        public List<Player> GetEnteredPlayers()
        {
            List<Player> players = new List<Player>();
            foreach (var name in Playernames)
            {
                var newPlayer = new Player(name);
                players.Add(newPlayer);
            }

            return players;
        }
        public void ShowMatch(Match match)
        {
            String horizontalline = " -";
            String Team1 = match.Team1.ToString();
            String Team2 = match.Team2.ToString();
            int lineLength = match.Team1.ToString().Length;

            if (Team1.Length > Team2.Length)
            {
                Team2.PadRight(Team1.Length, ' ');
            }
            else if (Team1.Length < Team2.Length)
            {
                Team1.PadRight(Team2.Length, ' ');
            }
            Console.WriteLine(horizontalline.PadRight(lineLength + 22, '-'));
            Console.WriteLine("|      " + "Team 1: " + Team1.PadRight(lineLength + 7, ' ') + "|");
            Console.WriteLine("|      " + "Team 2: " + Team2.PadRight(lineLength + 7, ' ') + "|");
            Console.WriteLine(horizontalline.PadRight(lineLength + 22, '-'));
        }
        public void PrintingWelcomeText()
        {
            Console.WriteLine(_welcomeText);
        }
    }
}
