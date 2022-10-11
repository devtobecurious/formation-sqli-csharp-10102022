using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Core.Library.Models
{
    public class StupefixSort : Sort
    {
        public StupefixSort(int id) : base(id, "Stupéfix", 12, 3) { }

        #region Public methods
        public override void Lancer()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            base.Lancer();
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion
    }
}
