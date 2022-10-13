using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Core.Tools
{
    public class ConsoleLogger : ILogger
    {
        public void Ecrire(string message)
        {
            Console.WriteLine(message);
        }
    }
}
