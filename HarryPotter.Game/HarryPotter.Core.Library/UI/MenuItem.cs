using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Core.Library.UI
{
    /// <summary>
    /// Une ligne du menu
    /// </summary>
    public class MenuItem
    {
        private int id;
        private string libelle;
        private int order;

        public MenuItem(int id, string libelle, int order)
        {
            this.Id = id;
            this.Libelle = libelle;
            this.order = order;
        }

        public MenuItem(int id = 1, string libelle = "") : this(id, libelle, 0)
        {
            
        }        

        public MenuItem(): this(libelle: "")
        {

        }

        public int Id 
        { 
            get 
            { 
                return id; 
            }
            private set
            {
                if (value < -1)
                {
                    value = 0;
                }
                this.id = value;
            }
        }

        public string Libelle
        {
            get => this.libelle;
            set => this.libelle = value;
        }
    }
}
