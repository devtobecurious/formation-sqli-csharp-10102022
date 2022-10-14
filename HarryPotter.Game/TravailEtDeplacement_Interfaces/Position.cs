using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailEtDeplacement_Interfaces
{
    internal class Position2
    {
        #region Surcharges operateurs
        public static bool operator ==(Position2 p1, Position2 p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static bool operator !=(Position2 p1, Position2 p2)
        {
            return p1.X != p2.X || p1.Y != p2.Y;
        }
        #endregion

        #region Properties
        public int X { get; init; }
        public int Y { get; init; }
        #endregion
    }

    public record Position(int X, int Y);
}
