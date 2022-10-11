using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Game.UI.Console.Core.Exceptions
{
    /// <summary>
    /// A déclencher (throw) : lorsque un age n'est pas attendu
    /// </summary>
    internal class AgeNonAttenduException : Exception
    {
        #region Fields
        // private int age;
        #endregion

        #region Constructors
        public AgeNonAttenduException(int ageSaisie, int ageLimit = 13)
        {
            this.AgeLimit = ageLimit;
            this.AgeSaisie = ageSaisie;
        }
        #endregion

        #region Properties
        public int AgeSaisie
        {
            get
            {
                return (int)this.Data["ageS"];
            }
            set
            {
                this.Data["ageS"] = value;
            }
        }

        public int AgeLimit
        {
            get
            {
                return (int)this.Data["age"];
            }
            set
            {
                this.Data["age"] = value;
            }
        }
        #endregion
    }
}
