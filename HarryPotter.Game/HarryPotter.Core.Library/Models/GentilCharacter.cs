﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Core.Library.Models
{
    public class GentilCharacter : Character
    {
        #region Constructors
        public GentilCharacter(string prenom, Baguette baguette = null) : base(prenom, baguette)
        {
        }
        #endregion

        #region Public methods
        public override void Attaquer()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
