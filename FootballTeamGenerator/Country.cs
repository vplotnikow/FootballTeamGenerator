using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    class Country
    {
        static Random Coincidence = new Random();

        public static String TeamBuilding()
        {
            int number1 = Coincidence.Next(0, 47);
            String[] country = { "England", "Österreich", "Belgien", "Bulgarien", "Tschechische Republik", "Dänemark",
                "Finnland", "Frankreich", "Deutschland", "Griechenland", "Italien", "Norwegen", "Polen", "Portugal",  "Irland", "Rumänien",
                "Russland", "Schottland", "Slowenien", "Spanien", "Schweden", "Schweiz", "Türkei",
                "Wales", "Argentinien", "Brasilien", "Paraguay", "Uruguay", "Mexiko", "USA", "Kamerun", "China", "Australien",
                "Ungarn", "Niederlande", "Nordirland", "Südafrika", "Peru", "Kolumbien", "Elfenbeinküste", "Ägypten", "Bolivien",
                "Kanada", "Chile", "Ecuador", "Indien", "Venezuela" };
            return country[number1];
        }
    }
}
