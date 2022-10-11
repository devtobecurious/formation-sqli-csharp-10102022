using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesAnimaux
{
    public class Chien : Animal
    {
        public override void Dormir()
        {
            base.Dormir();
            Console.WriteLine("En bavant");
        }
    }
}
