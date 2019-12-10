using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    class FileManager
    {
        const String playernamesFilename = "Playernames.txt";
        const String FootballTeamsFilename = "FootballTeams.txt";


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
                        Console.WriteLine("Möchten Sie die zuletzt eingegebene Spielernamen (" + playernames[0] + ", " + playernames[1] + ") verwenden? Antworten Sie mit ja oder nein. ");
                    }
                    else if (playernames.Length == 4)
                    {
                        Console.WriteLine("Möchten Sie die zuletzt eingegebene Spielernamen (" + playernames[0] + ", " + playernames[1] + ", " + playernames[2] + ", " + playernames[3] + ") verwenden? Antworten Sie mit ja oder nein. ");
                    }
                    string antwort = Console.ReadLine().ToLower();
                    if (antwort == "ja" || antwort == "j")
                    {
                        args = File.ReadAllLines(@".\" + playernamesFilename);
                    }
                    else if (antwort == "nein" || antwort == "n")
                    {
                        File.WriteAllLines(@".\" + playernamesFilename, args);
                        if (args.Length == 0)
                        {
                            Console.WriteLine("Willkommen zum Football Team Generator! Mit wie vielen Personen möchtest du spielen? (2 oder 4)");
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Willkommen zum Football Team Generator! Mit wie vielen Personen möchtest du spielen? (2 oder 4)");
                }
                return args;
            }

            else
            {
                Console.WriteLine("Willkommen zum Football Team Generator!");
            }
            return args;
        }
    }
}
