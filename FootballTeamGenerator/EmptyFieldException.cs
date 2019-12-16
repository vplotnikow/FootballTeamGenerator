using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    class EmptyFieldException : Exception
    {
        public EmptyFieldException(string message) : base(message)
        {
        }
    }
}
