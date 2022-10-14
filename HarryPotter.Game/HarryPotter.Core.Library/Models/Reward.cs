using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Core.Library.Models
{
    public class Reward
    {
        #region Properties
        public decimal Id { get; set; }

        public string Label { get; set; } = string.Empty;

        public decimal Value { get; set; }
        #endregion
    }
}
