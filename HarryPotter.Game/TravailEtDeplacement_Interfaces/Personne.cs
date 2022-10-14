using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailEtDeplacement_Interfaces.MoyensDeplacement;

namespace TravailEtDeplacement_Interfaces
{
    internal class Personne
    {
        public Position Position { get; private set; } = new Position(0, 0);

        public void AllerAuTravail(IMoyenDeDeplacement deplacement, CalculPosition calculPosition)
        {
            this.Position = deplacement.SeDeplacer(this.Position, calculPosition);
        }
    }
}
