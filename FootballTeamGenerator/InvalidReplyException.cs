using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    class InvalidReplyException : Exception
    {
        public InvalidReplyException(string message) : base(message)
        {
        }
    }
}
