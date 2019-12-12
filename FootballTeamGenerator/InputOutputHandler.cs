using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FootballTeamGenerator
{
    class InputOutputHandler
    {
        private int numberOfPlayers;
        private String[] Playernames;

        public void ReadUserInput(string[] consoleParameter)
        {
            if (consoleParameter.Length != 0)
            {
                numberOfPlayers = consoleParameter.Length;
                Playernames = consoleParameter;
            }
            else
            {
                numberOfPlayers = Convert.ToInt32(Console.ReadLine());
                Playernames = new String[numberOfPlayers];
            }

            while (numberOfPlayers != 2 && numberOfPlayers != 4)
            {
                Console.WriteLine("The number of people is incorrect. Please enter the number of people again.");
                numberOfPlayers = Convert.ToInt32(Console.ReadLine());
                Playernames = new String[numberOfPlayers];
            }

            Console.WriteLine("Okay, " + numberOfPlayers + " Players");
            Console.WriteLine("");

            if (consoleParameter.Length == 0)
            {
                Console.WriteLine("Please enter the player names one by one and confirm after every name with the ENTER key. \n");
                for (int i = 0; i < numberOfPlayers; i++)
                {
                    Console.WriteLine("Player " + (i + 1) + ":");
                    Playernames[i] = Console.ReadLine();
                    while (Playernames[i] == "")
                    {
                        Console.WriteLine("The field cannot be empty. You have to enter a name.");
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
            Console.WriteLine("---------------------------------------------------------------------{0}                                                             ___{0}  o__                                                 o__   |   |\\ {0} /|       Welcome To The Football Team Generator!     /\\    |   |X\\{0} / > o                                                 <\\   |   |XX\\{0}---------------------------------------------------------------------", Environment.NewLine);
        }
    }
}
