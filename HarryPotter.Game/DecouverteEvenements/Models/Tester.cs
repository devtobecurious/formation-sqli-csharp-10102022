using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouverteEvenements.Models
{
    internal class Tester
    {
        public void CheckerLesBugs(Code code)
        {
            Console.WriteLine("Ya des bugs ? j'exécute le code {0}", code.Contenu);
        }
    }
}
