using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculTva
{
    internal class CalculateurTva
    {
        public float CalculTTC(float montantHT, RecuperererTva getTva)
        {
            return montantHT + (montantHT * getTva());
        }
    }
}
