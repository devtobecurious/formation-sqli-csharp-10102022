using TravailEtDeplacement_Interfaces;
using TravailEtDeplacement_Interfaces.MoyensDeplacement;



Dictionary<string, string> configuration = new Dictionary<string, string>();

configuration.Add("ChaineDeConnexion", "12132131321");
// configuration.Add("ChaineDeConnexion", "54654654");

















Personne personne = new();

Dictionary<TempsQuiFait, IMoyenDeDeplacement> correspondances = new Dictionary<TempsQuiFait, IMoyenDeDeplacement>();

correspondances.Add(TempsQuiFait.BeauTemps, new TrotinetteMoyenDeplacement());
// correspondances.Add(TempsQuiFait.BeauTemps, new TrainMoyenDeplacement());

correspondances.Add(TempsQuiFait.IlPleut, new VoitureMoyenDeplacement());
correspondances.Add(TempsQuiFait.YFaitChaud, new TrainMoyenDeplacement());
correspondances.Add(TempsQuiFait.YaDeLorage, new TrainMoyenDeplacement());


Meteo meteo = new Meteo();
TempsQuiFait temps = meteo.Recuperer();

IMoyenDeDeplacement moyenDeDeplacement = null;

if (correspondances.ContainsKey(temps))
{
    moyenDeDeplacement = correspondances[temps];
    personne.AllerAuTravail(moyenDeDeplacement, position => new Position(2, 2));
}



//personne.AllerAuTravail()


//var position1 = new Position(1, 1);

//var position2 = new Position(1, 1);

//bool positionsIdentiques = position1 == position2;

//Console.WriteLine(positionsIdentiques);


//TempsQuiFait monTemps = TempsQuiFait.BeauTemps;

//var listEnum = Enum.GetValues(typeof(TempsQuiFait));

//foreach (var temp in listEnum)
//{
//    Console.WriteLine(temp);
//}