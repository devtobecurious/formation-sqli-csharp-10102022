using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Core.Library.Models
{
    public class EcailleDragonBaguette : Baguette
    {
        #region Constructors
        public EcailleDragonBaguette() : base("Baguette en écaille de dragon") //, new ExpelliarmusSort(2), new StupefixSort(1))
        {
            //this.AjouterSort(new ExpelliarmusSort(4));
        }

        protected override void DoInitialiserSorts()
        {
            this.AjouterSort(new ExpelliarmusSort(4));
        }
        #endregion


    }
}
