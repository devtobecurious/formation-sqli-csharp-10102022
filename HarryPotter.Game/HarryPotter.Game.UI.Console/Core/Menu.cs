using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    internal class Menu
    {
    }
}


namespace HarryPotter.Game.UI.Console.Core
{
    /// <summary>
    /// Classe affichant le menu du jeu
    /// </summary>
    internal class Menu
    {
        // public List<MenuItem> Items = new List<MenuItem>();
        private List<MenuItem> items = new List<MenuItem>();

        public void Ajouter(MenuItem item)
        {
            this.items.Add(item);
        }

        public void Ajouter(int test)
        {
            this.items.Add(new MenuItem(test));
        }

        public void Ajouter(int id, string libelle)
        {
            this.items.Add(new MenuItem(id, libelle));
        }

        public void Afficher()
        {
            foreach (var item in this.items)
            {
                System.Console.WriteLine(item.Id + ". " + item.Libelle);
            }
        }
    }
}
