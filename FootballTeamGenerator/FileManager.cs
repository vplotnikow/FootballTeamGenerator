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
        private const string _playernamesFilename = "Playernames.txt";
        private const string _footballTeamsFilename = "FootballTeams.txt";
        private const string _lastEnteredPlayers = "Do you want to use the last entered player names ";
        private const string _reply = " Please reply with yes or no.";
        private const string _incorrectReply = "Your reply is unfortunatelly incorrect. ";
        private const string _againReply = "Please try it again with yes or no.";
        private const string _incorrectNOPInFile = "The file with the last entered names exists but the number of them is incorrect. Please enter them one by one again.";
        private const string _numberOfPeople = "\nWith how many people do you want to play? (2 or 4)";
        
        public void WritingInATextfile(string[] playernames)
        {
            File.WriteAllLines(@".\" + _playernamesFilename, playernames);
            Console.WriteLine("");
        }

        public void ImportTeams(Generator generator)
        {
            if (File.Exists(@".\" + _footballTeamsFilename) && new FileInfo(@".\" + _footballTeamsFilename).Length != 0)
            {
                generator.DefaultFootballTeams = File.ReadAllLines(@".\" + _footballTeamsFilename);
            }
            else
            {
                File.WriteAllLines(@".\" + _footballTeamsFilename, generator.DefaultFootballTeams);
            }
        }

        public static string[] ReadPlayerLines(string[] args)
        {
            bool cancellation = false;

            try
            {
                if (args.Length == 0)
                {
                    if (File.Exists(@".\" + _playernamesFilename) && new FileInfo(@".\" + _playernamesFilename).Length != 0)
                    {
                        string[] playernames = File.ReadAllLines(@".\" + _playernamesFilename);

                        if (playernames.Length == 2)
                        {
                            Console.WriteLine(_lastEnteredPlayers + "(" + playernames[0] + ", " + playernames[1] + ")?" + _reply);
                        }
                        else if (playernames.Length == 4)
                        {
                            Console.WriteLine(_lastEnteredPlayers + "(" + playernames[0] + ", " + playernames[1] + ", " + playernames[2] + ", " + playernames[3] + ")?" + _reply);
                        }
                        else
                        {
                            throw new InvalidNumberOfPlayersException(_incorrectNOPInFile);
                        }

                        while (!cancellation)
                        {
                            try
                            {
                                string answer = Console.ReadLine().ToLower();
                                if (answer == "yes" || answer == "y")
                                {
                                    args = File.ReadAllLines(@".\" + _playernamesFilename);
                                }
                                else if (answer == "no" || answer == "n")
                                {
                                    File.WriteAllLines(@".\" + _playernamesFilename, args);

                                    if (args.Length == 0)
                                    {
                                        Console.WriteLine(_numberOfPeople);

                                    }
                                }
                                else
                                {
                                    throw new InvalidReplyException(_incorrectReply + _againReply);
                                }
                                cancellation = true;
                            }
                            catch (InvalidReplyException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(_numberOfPeople);
                    }
                }
            }
            catch (InvalidNumberOfPlayersException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(_numberOfPeople);
            }
            return args;
        }
    }
}
