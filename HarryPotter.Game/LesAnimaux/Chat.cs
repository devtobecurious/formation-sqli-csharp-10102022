using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesAnimaux
{
    public class Chat : Animal
    {
        public string Prenom { get; set; } = "";
        public int Longueur { get; set; } = 80;
        public Pelage LePelage { get; set; } = Pelage.Uni;

        public System.ConsoleColor Couleur { get; set; } = ConsoleColor.Blue;

        public override void Dormir()
        {
            base.Dormir();
            Console.WriteLine("Je ronronne");
        }
    }
}
