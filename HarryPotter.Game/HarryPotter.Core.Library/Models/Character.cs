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
        private int id;
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

        public abstract void Attaquer();

        public override string ToString()
        {
            return String.Format("{1}. Prenom : {0}", this.Prenom, this.id);
        }
        #endregion

        #region Properties
        public string Prenom { get; set; } = "";

        public int PointsDeVie { get; set; } = 100;
        #endregion
    }
}
