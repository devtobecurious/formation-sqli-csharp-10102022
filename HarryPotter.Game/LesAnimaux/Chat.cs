using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesAnimaux
{
    public class Chat : Animal
    {
        public override void Dormir()
        {
            base.Dormir();
            Console.WriteLine("Je ronronne");
        }
    }
}
