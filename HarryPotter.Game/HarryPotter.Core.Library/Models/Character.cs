using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Core.Library.Models
{
    /// <summary>
    /// Classe parent pour tous les personnages du jeu
    /// </summary>
    public abstract class Character
    {
        #region Fields
        private static int Compteur = 1;
        private Baguette baguette;
        private int pointsDeVie = 100;
        private static Random random = new Random();
        private int id;

        public event Action<Character> Mourrir;
        #endregion

        #region Constructors
        public Character(string prenom) : this(prenom, null)
        {
        }

        public Character(string prenom, Baguette baguette)
        {
            this.id = Character.Compteur++;

            this.Prenom = prenom;
            this.baguette = baguette;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Affecte l'unique baguette au personnage
        /// (écrase l'ancienne)
        /// </summary>
        public void AffecterBaguette(Baguette baguette)
        {
            this.baguette = baguette;
        }

        public void SeLaPeter(Character character)
        {
            // string.Format("{1}{1}", character.Prenom, 10);
            Console.WriteLine("{0} : Jai gagné !! J'ai gagné !!!", this.Prenom);
        }

        public virtual void Attaquer(Character ennemi)
        {
            int coup = Character.random.Next(1, 15);
            ennemi.PointsDeVie -= coup;

            Console.WriteLine($"Ennemi {ennemi.Prenom.ToUpper()}: {ennemi.pointsDeVie}");
        }

        public abstract void Defendre();

        public override string ToString()
        {
            return String.Format("{1}. Prenom : {0}", this.Prenom, this.id);
        }
        #endregion

        #region Properties
        public string Prenom { get; set; } = "";
        
        public int PointsDeVie
        {
            get => this.pointsDeVie;
            set
            {
                this.pointsDeVie = value;

                if (this.pointsDeVie <= 0)
                {
                    this.pointsDeVie = 0;
                    this.Mourrir?.Invoke(this);
                }
            }
        }
        #endregion
    }
}
