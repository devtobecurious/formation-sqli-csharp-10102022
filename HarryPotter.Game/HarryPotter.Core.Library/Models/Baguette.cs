using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Core.Library.Models
{
    public abstract class Baguette
    {
        #region Fields
        private readonly List<Sort> sorts = new();
        private int id = 0;
        private static int Compteur = 1;
        #endregion

        #region Constructors
        protected Baguette(string libelle)
        {
            this.id = Baguette.Compteur++;
            this.Libelle = libelle;

            this.InitialiserSorts();
        }

        //protected Baguette(string libelle, List<Sort> sorts)
        //{
        //    this.sorts = sorts;
        //}

        //protected Baguette(string libelle, params Sort[] sorts)
        //{
        //    this.sorts = new List<Sort>(sorts);
        //}
        #endregion

        #region Public methods
        private void InitialiserSorts()
        {
            this.DoInitialiserSorts();
            if (this.sorts.Count == 0)
            {
                throw new Exception();
            }
        }

        /// <summary>
        ///  Vous êtes obligé d'ajouter au moins un sort
        /// </summary>
        protected abstract void DoInitialiserSorts();

        public void AjouterSort(Sort sort)
        {
            this.sorts.Add(sort);
        }

        public override string ToString()
        {
            StringBuilder builder = new();

            builder.Append($"{this.id}. {this.Libelle}");

            if (this.sorts.Count > 0)
            {
                builder.Append(" [");

                int nbSorts = 0;
                this.sorts.ForEach(sort =>
                {
                    builder.Append(sort.Libelle);

                    if (nbSorts < this.sorts.Count - 1)
                    {
                        builder.Append(',');
                    }
                    nbSorts++;
                });

                builder.Append("]");
            }

            string retourChaine = builder.ToString();

            return retourChaine;
        }
        #endregion

        #region Properties
        public string Libelle { get; init; }
        #endregion
    }
}
