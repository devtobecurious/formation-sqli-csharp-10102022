using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesAnimauxFantastiques.Models
{
    internal class AnimalFantastique
    {
        #region Constructors
        public AnimalFantastique(string prenom, int taille, int age, params Capacite[] capacites)
        {
            this.Capacites.AddRange(capacites);
            this.Prenom = prenom;
            this.Age = age;
            this.Taille = taille;
        }
        #endregion

        #region Properties
        public string Prenom { get; set; } = "";

        public int Age { get; set; }

        public int Taille { get; set; }

        public List<Capacite> Capacites { get; init; } = new List<Capacite>();
        #endregion
    }
}
