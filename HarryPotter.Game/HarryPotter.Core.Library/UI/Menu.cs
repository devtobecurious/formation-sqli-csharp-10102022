using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    public class Menu
    {
    }
}


namespace HarryPotter.Core.Library.UI
{
    /// <summary>
    /// Classe affichant le menu du jeu
    /// </summary>
    public class Menu
    {
        // public List<MenuItem> Items = new List<MenuItem>();
        private readonly List<MenuItem> items = new List<MenuItem>();

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
