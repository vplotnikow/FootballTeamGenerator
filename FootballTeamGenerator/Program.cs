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
        private const string _finalText = "I wish both teams good luck and a good game!";
        private const string _exitText = "\nPress any key to exit.";

        static void Main(string[] args)
        {
            InputOutputHandler inputOutputHandler = new InputOutputHandler();
            inputOutputHandler.PrintingWelcomeText();
            args = FileManager.ReadPlayerLines(args);

            try
            {               
                inputOutputHandler.ReadUserInput(args);
            }
            catch (InvalidNumberOfCLAException e1)
            {
                Console.WriteLine(e1.Message);
                Console.WriteLine(_exitText);
                Console.ReadKey();
                Environment.Exit(0);
            }
           
            List<Player> playerList = inputOutputHandler.GetEnteredPlayers();

            var matchMaker = new MatchMaker(playerList);
            var match = matchMaker.CreateMatch();

            inputOutputHandler.ShowMatch(match);
            Console.WriteLine("\n" + _finalText);
   
            Console.ReadKey();
        }
    }
}
