using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Core.Library.Models
{
    public class EndolorisSort: Sort
    {
        public EndolorisSort(int id) : base(id, "Endoloris", 5, 2) { }

        #region Public methods
        public override void Lancer()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Lancer();
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion
    }
}
