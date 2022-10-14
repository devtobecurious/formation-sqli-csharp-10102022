using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Core.Library.Models
{
    public class MechantCharacter : Character
    {
        #region Constructors
        public MechantCharacter(string prenom, Baguette baguette = null) : base(prenom, baguette)
        {
        }
        #endregion

        #region Public methods
        public override void Defendre()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
