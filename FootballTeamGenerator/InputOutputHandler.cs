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

        public void ReadUserInput(string[] konsolenParameter)
        {
            if (konsolenParameter.Length != 0)
            {
                numberOfPlayers = konsolenParameter.Length;
                Playernames = konsolenParameter;
            }
            else
            {
                numberOfPlayers = Convert.ToInt32(Console.ReadLine());
                Playernames = new String[numberOfPlayers];
            }

            while (numberOfPlayers != 2 && numberOfPlayers != 4)
            {
                Console.WriteLine("Die Anzahl der Personen ist nicht passend. Geben Sie erneut die Personenanzahl ein.");
                numberOfPlayers = Convert.ToInt32(Console.ReadLine());
                Playernames = new String[numberOfPlayers];
            }

            Console.WriteLine("Okay, " + numberOfPlayers + " Spieler also.");
            Console.WriteLine("");

            if (konsolenParameter.Length == 0)
            {
                Console.WriteLine("Gib nun bitte nacheinander die Spielernamen ein und bestätige nach jedem Namen mit Enter. \n");
                for (int i = 0; i < numberOfPlayers; i++)
                {
                    Console.WriteLine("Spieler " + (i + 1) + ":");
                    Playernames[i] = Console.ReadLine();
                    while (Playernames[i] == "")
                    {
                        Console.WriteLine("Das Feld kann nicht leer sein! Sie müssen einen Namen eingeben!");
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
            Console.WriteLine(match);
        }

        

    }
}
