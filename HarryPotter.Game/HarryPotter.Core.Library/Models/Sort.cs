using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Core.Library.Models
{
    /// <summary>
    /// Sort à utiliser dans le jeu
    /// </summary>
    public abstract class Sort : Object
    {
        #region Constructors
        public Sort(int id): this(id, string.Empty) {}

        public Sort(int id, string libelle) : this(id, libelle, 10) {}

        public Sort(int id, string libelle, int degats) : this(id, libelle, degats, 10) {}

        public Sort(int id, string libelle, int degats, int cout)
        {
            this.Id = id;
            this.Libelle = libelle;
            this.NombreDegats = degats;
            this.Cout = cout;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Lance un sort sur un ennemi
        /// </summary>
        public virtual void Lancer()
        {
            Console.WriteLine("Je lance le sort : " + this.Libelle);
        }

        public override string ToString()
        {
            // return this.Id + ". " + this.Libelle;
            // return string.Format("{0}. {1}", this.Id, this.Libelle);

            return $"{this.Id}. {this.Libelle}";
        }
        #endregion

        #region Properties
        public int Id { get; init; }

        public string Libelle { get; set; } = "";

        public int NombreDegats { get; set; } = 10;

        public int Cout { get; set; } = 5;
        #endregion
    }
}
