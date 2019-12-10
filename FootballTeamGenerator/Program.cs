using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            InputOutputHandler inputOutputHandler = new InputOutputHandler();
            args = FileManager.ReadPlayerLines(args);
            inputOutputHandler.ReadUserInput(args);
            List<Player> playerList = inputOutputHandler.GetEnteredPlayers();

            var matchMaker = new MatchMaker(playerList);
            var match = matchMaker.CreateMatch();

            inputOutputHandler.ShowMatch(match);

            Console.WriteLine("Ich wünsche beiden Teams viel Erfolg und Gut Kick!");
            Console.ReadKey();
        }
    }
}
