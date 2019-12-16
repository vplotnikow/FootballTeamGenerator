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
        private int _numberOfPlayers;
        private string[] _playernames;
        private const string versionNumber = "v2.0";
        private const string _welcomeText = "-----------------------------------------------------------------" + versionNumber + "\n                                                             ___\n  o__                                                 o__   |   |\\ \n /|       Welcome To The Football Team Generator!     /\\    |   |X\\\n / > o                                                 <\\   |   |XX\\\n---------------------------------------------------------------------";
        private const string _incorrectNumberOfPeople = "The number of people is incorrect. Please enter the number of people again. (2 or 4)";
        private const string _incorrectNumberOfCLA = "\nThe number of command line arguments is incorrect. Please enter two or four command line arguments.";
        private const string _enterOfPlayerNames = "Please enter the player names one by one and confirm after every name with the ENTER key. \n";
        private const string _emptyField = "The field cannot be empty. You have to enter a name.";
        private const string _nolettersorsc = "You can enter either 2 or 4 and no letters or special characters. Please try it again.";
        private bool cancellation;

        public void ReadUserInput(string[] consoleParameter)
        {
            if (consoleParameter.Length != 0)
            {
                if (consoleParameter.Length != 2 && consoleParameter.Length != 4)
                {
                    throw new InvalidNumberOfCLAException(_incorrectNumberOfCLA);
                }
                _numberOfPlayers = consoleParameter.Length;
                _playernames = consoleParameter;
            }
            else
            {
                cancellation = false;
                while (!cancellation)
                {
                    try
                    {
                        _numberOfPlayers = Convert.ToInt32(Console.ReadLine());
                        if(_numberOfPlayers != 2 && _numberOfPlayers != 4)
                        {
                            throw new InvalidNumberOfPlayersException(_incorrectNumberOfPeople);
                        }
                        cancellation = true;
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine(_nolettersorsc);
                    }
                    catch(InvalidNumberOfPlayersException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                _playernames = new string[_numberOfPlayers];
            }

            Console.WriteLine("Okay, so " + _numberOfPlayers + " Players.");
            Console.WriteLine("");

            if (consoleParameter.Length == 0)
            {
                Console.WriteLine(_enterOfPlayerNames);
                for (int i = 0; i < _numberOfPlayers; i++)
                {
                    cancellation = false;
                    Console.WriteLine("Player " + (i + 1) + ":");                   
                    while (!cancellation)
                    {
                        try
                        {
                            _playernames[i] = Console.ReadLine();
                            if (_playernames[i] == "")
                            {
                                throw new EmptyFieldException(_emptyField);
                            }
                            cancellation = true;
                        }
                        catch (EmptyFieldException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }

                FileManager manager = new FileManager();
                manager.WritingInATextfile(_playernames);
            }
        }

        public List<Player> GetEnteredPlayers()
        {
            List<Player> players = new List<Player>();
            foreach (var name in _playernames)
            {
                var newPlayer = new Player(name);
                players.Add(newPlayer);
            }

            return players;
        }

        public void ShowMatch(Match match)
        {
            string horizontalline = " -";
            string team1 = match.Team1.ToString();
            string team2 = match.Team2.ToString();
            int lineLength = match.Team1.ToString().Length;

            if (team1.Length > team2.Length)
            {
                team2.PadRight(team1.Length, ' ');
            }
            else if (team1.Length < team2.Length)
            {
                team1.PadRight(team2.Length, ' ');
            }
            Console.WriteLine(horizontalline.PadRight(lineLength + 22, '-'));
            Console.WriteLine("|      " + "Team 1: " + team1.PadRight(lineLength + 7, ' ') + "|");
            Console.WriteLine("|      " + "Team 2: " + team2.PadRight(lineLength + 7, ' ') + "|");
            Console.WriteLine(horizontalline.PadRight(lineLength + 22, '-'));
        }

        public void PrintingWelcomeText()
        {
            Console.WriteLine(_welcomeText);
        }
    }
}
