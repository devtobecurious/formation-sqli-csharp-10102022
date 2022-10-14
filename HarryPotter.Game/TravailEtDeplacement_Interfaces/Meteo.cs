using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailEtDeplacement_Interfaces
{
    internal class Meteo
    {
        private static Random random = new Random();

        public TempsQuiFait Recuperer()
        {
            TempsQuiFait temps = TempsQuiFait.BeauTemps;

            int valeur = random.Next((int)TempsQuiFait.INeige, (int)TempsQuiFait.YFaitChaud);

            var possibiliteDeTemps = Enum.GetValues<TempsQuiFait>();

            var tempsATester =  possibiliteDeTemps.Where(item => item == (TempsQuiFait)valeur)
                                                  .SingleOrDefault();            

            if (tempsATester != null)
            {
                temps = tempsATester;
            }

            return temps;
        }
    }
}
