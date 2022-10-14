using HarryPotter.Core.Library.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Core.Library.Models
{
    /// <summary>
    /// Profil de la personne qui va jouer
    /// </summary>
    public class Profil
    {
        #region Fields
        private DateTime dateDeNaissance;
        private Character? character;
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

        #region Public methods
        public void AffecterPersonnage(Character character)
        {
            this.character = character;
        }

        public void AffecterBaguetteAuPersonnage(Baguette baguette)
        {
            this.character?.AffecterBaguette(baguette);
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

                if (age != this.Age)
                {
                    throw new ArgumentException("age");
                }

                this.dateDeNaissance = value;
            }
        }

        public string Prenom { get; init; }

        public int Age { get; set; }
        #endregion
    }
}
