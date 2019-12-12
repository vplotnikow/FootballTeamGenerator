﻿using System;
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
            inputOutputHandler.PrintingWelcomeText();
            args = FileManager.ReadPlayerLines(args);
            inputOutputHandler.ReadUserInput(args);
            List<Player> playerList = inputOutputHandler.GetEnteredPlayers();

            var matchMaker = new MatchMaker(playerList);
            var match = matchMaker.CreateMatch();

            inputOutputHandler.ShowMatch(match);

            Console.WriteLine("\nI wish both teams good luck and a good game!");
   
            Console.ReadKey();
        }
    }
}
