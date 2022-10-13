using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Core.Tools
{
    /// <summary>
    /// Contrat pour toute classe souhaitant etre un logger
    /// </summary>
    public interface ILogger
    {
        void Ecrire(string message);
    }
}
