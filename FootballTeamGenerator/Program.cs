﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            args = Textfile_Player.ReadLines(args);
            Player.Input(args);
            Textfile_FootballTeams.ImportTeams();
            Player.TeamNumber();
            Player.Output();
            Console.WriteLine("");
            Console.WriteLine("Ich wünsche beiden Teams viel Erfolg und Gut Kick!");
            Console.ReadKey();
        }
    }
}
