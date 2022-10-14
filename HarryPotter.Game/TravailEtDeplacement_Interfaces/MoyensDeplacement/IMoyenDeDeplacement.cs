using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailEtDeplacement_Interfaces.MoyensDeplacement
{
    internal interface IMoyenDeDeplacement
    {
        Position SeDeplacer(Position initiale, CalculPosition calculPosition);
    }
}
