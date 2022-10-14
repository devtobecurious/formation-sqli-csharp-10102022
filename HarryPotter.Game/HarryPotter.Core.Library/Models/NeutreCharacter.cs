using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Core.Library.Models
{
    internal class NeutreCharacter : Character
    {
        public NeutreCharacter(string prenom) : base(prenom)
        {
        }

        public override void Defendre()
        {
            throw new NotImplementedException();
        }
    }
}
