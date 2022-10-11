using HarryPotter.Game.UI.Console.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Game.UI.Console.Core
{
    /// <summary>
    /// Profil de la personne qui va jouer
    /// </summary>
    internal class Profil
    {
        #region Fields
        private DateTime dateDeNaissance;
        #endregion

        #region Constructors
        public Profil(DateOnly dateDeNaissance) : this(dateDeNaissance.ToDateTime(TimeOnly.MinValue), string.Empty, 0)
        {
        }

        public Profil(DateTime dateDeNaissance, string prenom, int age)
        {
            DateDeNaissance = dateDeNaissance;
            Prenom = prenom;
            Age = age;
        }
        #endregion

        #region Properties
        public DateTime DateDeNaissance
        {
            get
            {
                return this.dateDeNaissance;
            }

            set
            {
                TimeSpan result = DateTime.Now - value;
                int age = result.Days / 365;

                if (age < 13)
                {
                    throw new AgeNonAttenduException(age, 13);
                }

                this.dateDeNaissance = value;
            }
        }

        public string Prenom { get; init; }

        public int Age { get; set; }
        #endregion
    }
}
