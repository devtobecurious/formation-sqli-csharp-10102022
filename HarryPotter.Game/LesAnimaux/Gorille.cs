using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesAnimaux
{
    public class Gorille : Animal
    {
        public override void Dormir()
        {
            Console.WriteLine("Je me suis confectionné un lit de feuille");
            base.Dormir();
        }
    }
}
