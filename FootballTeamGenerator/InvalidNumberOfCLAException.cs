using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    class InvalidNumberOfCLAException : Exception
    {
        public InvalidNumberOfCLAException(string message) : base(message)
        {
        }
    }
}
