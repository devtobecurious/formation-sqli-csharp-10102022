using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Core.Library.Models
{
    public class PlumePhoenixBaguette : Baguette
    {
        #region Constructors
        public PlumePhoenixBaguette() : base("Baguette en plume de phoenix")
        {
           
        }

        protected override void DoInitialiserSorts()
        {
            this.AjouterSort(new StupefixSort(1));
            this.AjouterSort(new EndolorisSort(2));
            this.AjouterSort(new AvadaKedavraSort(2));
        }
        #endregion
    }
}
