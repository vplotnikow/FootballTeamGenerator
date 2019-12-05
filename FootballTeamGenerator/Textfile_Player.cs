using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    class Textfile_Player
    {
        public static string[] ReadLines(string[] args)
        {
            if (File.Exists(@".\Spielernamen.txt") && new FileInfo(@".\Spielernamen.txt").Length != 0)
            {
                string[] spielernamen = File.ReadAllLines(@".\Spielernamen.txt");
                if (spielernamen.Length == 2)
                {
                    Console.WriteLine("Möchten Sie die zuletzt eingegebene Spielernamen (" + spielernamen[0] + ", " + spielernamen[1] + ") verwenden? Antworten Sie mit ja oder nein. ");
                }
                else if (spielernamen.Length == 4)
                {
                    Console.WriteLine("Möchten Sie die zuletzt eingegebene Spielernamen (" + spielernamen[0] + ", " + spielernamen[1] + ", " + spielernamen[2] + ", " + spielernamen[3] + ") verwenden? Antworten Sie mit ja oder nein. ");
                }
                string antwort = Console.ReadLine().ToLower();
                if (antwort == "ja")
                {
                    args = File.ReadAllLines(@".\Spielernamen.txt");
                }
                else if (antwort == "nein")
                {
                    File.WriteAllLines(@".\Spielernamen.txt", args);
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
    }
}
