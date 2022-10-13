using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Core.Library.Models
{
    public class BoisSureauBaguette : Baguette
    {
        #region Constructors
        public BoisSureauBaguette() : base("Baguette en bois de sureau")
        {
            
        }

        protected override void DoInitialiserSorts()
        {
            this.AjouterSort(new AvadaKedavraSort(1));
            this.AjouterSort(new EndolorisSort(2));
        }
        #endregion


    }
}
