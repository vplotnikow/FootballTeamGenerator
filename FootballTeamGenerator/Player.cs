using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    class Player
    {
        String name;
        public Player(String name)
        {
            name = this.name;
        }

        public static int anzahlDerSpieler;
        static String[] namenDerSpieler = new String[anzahlDerSpieler];
        static String[] array = new String[anzahlDerSpieler];

        public static void Input(string[] konsolenParameter)
        {
            if (konsolenParameter.Length != 0)
            {
                anzahlDerSpieler = konsolenParameter.Length;
                namenDerSpieler = konsolenParameter;
            }
            else
            {
                anzahlDerSpieler = Convert.ToInt32(Console.ReadLine());
                namenDerSpieler = new String[anzahlDerSpieler];
            }

            while (anzahlDerSpieler != 2 && anzahlDerSpieler != 4)
            {
                Console.WriteLine("Die Anzahl der Personen ist nicht passend. Geben Sie erneut die Personenanzahl ein.");
                anzahlDerSpieler = Convert.ToInt32(Console.ReadLine());
                namenDerSpieler = new String[anzahlDerSpieler];
            }

            Console.WriteLine("Okay, " + anzahlDerSpieler + " Spieler also.");
            Console.WriteLine("");

            if (konsolenParameter.Length == 0)
            {
                Console.WriteLine("Gib nun bitte nacheinander die Spielernamen ein und bestätige nach jedem Namen mit Enter. \n");
                for (int i = 0; i < anzahlDerSpieler; i++)
                {
                    Console.WriteLine("Spieler " + (i + 1) + ":");
                    namenDerSpieler[i] = Console.ReadLine();
                    while (namenDerSpieler[i] == "")
                    {
                        Console.WriteLine("Das Feld kann nicht leer sein! Sie müssen einen Namen eingeben!");
                        namenDerSpieler[i] = Console.ReadLine();
                    }
                }
                File.WriteAllLines(@".\Spielernamen.txt", namenDerSpieler);
                Console.WriteLine("");
            }
        }

        public static void TeamNumber()
        {
            Random Coincidence = new Random();
            array = new String[anzahlDerSpieler];
            for (int i = 0; i < anzahlDerSpieler; i++)
            {
                int number = Coincidence.Next(0, anzahlDerSpieler);
                while (namenDerSpieler[number] == null)
                {
                    number = Coincidence.Next(0, anzahlDerSpieler);
                }
                array[i] = namenDerSpieler[number];
                namenDerSpieler[number] = null;
            }
        }

        public static void Output()
        {
            String country = FootballTeam.TeamBuilding();
            String country2 = FootballTeam.TeamBuilding();
            if (anzahlDerSpieler == 2)
            {
                Console.WriteLine("Team 1 (" + array[0] + ") = " + country);
                Console.WriteLine("Team 2 (" + array[1] + ") = " + country2);
            }
            else if (anzahlDerSpieler == 4)
            {
                Console.WriteLine("Team 1 (" + array[0] + " & " + array[1] + ") = " + country);
                Console.WriteLine("Team 2 (" + array[2] + " & " + array[3] + ") = " + country2);
            }
        }
    }
}
