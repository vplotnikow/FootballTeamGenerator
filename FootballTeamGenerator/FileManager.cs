using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace FootballTeamGenerator
{
    class FileManager
    {
        const String playernamesFilename = "Playernames.txt";
        const String FootballTeamsFilename = "FootballTeams.txt";
        private const string _lastEnteredPlayers = "Do you want to use the last entered player names";
        private const string _reply = " Please reply with yes or no.";
        private const string _numberOfPeople = "With how many people do you want to play? (2 or 4)";


        public void WritingInATextfile(String[] Playernames)
        {
            File.WriteAllLines(@".\" + playernamesFilename, Playernames);
            Console.WriteLine("");
        }

        public void ImportTeams(Generator generator)
        {
            if (File.Exists(@".\" + FootballTeamsFilename) && new FileInfo(@".\" + FootballTeamsFilename).Length != 0)
            {
                generator.DefaultFootballTeams = File.ReadAllLines(@".\" + FootballTeamsFilename);
            }
            else
            {
                File.WriteAllLines(@".\" + FootballTeamsFilename, generator.DefaultFootballTeams);
            }
        }

        public static string[] ReadPlayerLines(string[] args)
        {
            
            if (args.Length == 0)
            {
                if (File.Exists(@".\" + playernamesFilename) && new FileInfo(@".\" + playernamesFilename).Length != 0)
                {
                    string[] playernames = File.ReadAllLines(@".\" + playernamesFilename);

                    if (playernames.Length == 2)
                    {
                        Console.WriteLine(_lastEnteredPlayers + "(" + playernames[0] + ", " + playernames[1] + ")?" + _reply);
                    }
                    else if (playernames.Length == 4)
                    {
                        Console.WriteLine(_lastEnteredPlayers + "(" + playernames[0] + ", " + playernames[1] + ", " + playernames[2] + ", " + playernames[3] + ")?" + _reply);

                    }
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "yes" || answer == "y")
                    {
                        args = File.ReadAllLines(@".\" + playernamesFilename);
                    }
                    else if (answer == "no" || answer == "n")
                    {
                        File.WriteAllLines(@".\" + playernamesFilename, args);

                        if (args.Length == 0)
                        {
                            Console.WriteLine(_numberOfPeople);

                        }
                    }
                }
                else
                {
                    Console.WriteLine(_numberOfPeople);
                }
            }
            return args;
        }
    }
}
