using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Core.Library.Models
{
    public class AvadaKedavraSort : Sort
    {
        #region Constructors
        public AvadaKedavraSort(int id) : base(id, "Avada Kedavra", 18, 22) { }

        //public AvadaKedavraSort(bool avecId): base(0) { }
        #endregion

        #region Public methods
        public override void Lancer()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Lancer();
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion
    }
}
