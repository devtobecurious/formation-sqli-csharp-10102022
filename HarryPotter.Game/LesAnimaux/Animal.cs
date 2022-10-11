using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesAnimaux
{
    public class Animal
    {
        public void Manger(int nbGrammeNourriture)
        {
            Console.WriteLine($"Miam, je mange {nbGrammeNourriture}");
        }

        public virtual void Dormir()
        {
            Console.WriteLine("Je dors, laisse moi tranquille");
        }
    }
}
