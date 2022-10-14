using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouverteEvenements.Models
{
    internal class Developer
    {
        public event Action<Code> TravailFini;

        public void EcrireCode()
        {
            Console.WriteLine("J'écris du code");



            this.TravailFini(new Code()
            {
                Contenu = "Console.WriteLine(\"Hello\");"
            });
        }
    }
}
