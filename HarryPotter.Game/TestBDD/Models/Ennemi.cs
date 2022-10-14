using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBDD.Models
{
    internal class Ennemi
    {
        public decimal Id { get; set; }

        public string Prenom { get; set; } = "";

        public decimal PointsDeVie { get; set; }
    }
}
