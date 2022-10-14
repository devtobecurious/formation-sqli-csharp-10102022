using System.Linq;

List<AnimalFantastique> animaux = new()
{
    new ("Prenom 1", 100, 200, new Capacite() { Value = CapaciteValue.Disparaitre}, new Capacite() { Value = CapaciteValue.CracherDuFeu}),
    new ("Prenom 2", 150, 2),
    new ("Prenom 3", 300, 1, new Capacite() { Value = CapaciteValue.Voler}, new Capacite() { Value = CapaciteValue.CracherDuFeu}),
    new ("Prenom 4", 50, 3, new Capacite() { Value = CapaciteValue.Voler}),
};

Console.WriteLine("********** Liste de toutes les tailles **********");
var queryTaille = from animal in animaux
                  where animal.Taille > 100
                  select animal.Taille;


var maFonctionLambda = (AnimalFantastique item) => item.Taille;
var resultTailles = animaux.Where(item => item.Taille > 100).Select(maFonctionLambda);

//List<int> SelectTailles()
//{
//    List<int> result = new List<int>();
//    foreach (var animal in animaux)
//    {
//        // result.Add(item.Taille);
//        int taille = maFonctionLambda(animal);
//        result.Add(taille);
//    }

//    return result;
//}


Console.WriteLine("********** Au moins un animal qui vole ? **********");

var query = from animal in animaux
            where animal.Capacites.Any(item => item.Value == CapaciteValue.Voler)
            select animal;

// Si je veux uniquement savoir  sans parcourir
if (query.Any())
{
    Console.WriteLine("Oui, nous avons au moins un animal qui peut voler");
}

// Si je veux parcourir et vérifier le nbvar listAnimalQuiPeuventVoler = query.ToList();
var listAnimalQuiPeuventVoler = query.ToList();
if (listAnimalQuiPeuventVoler.Count > 0)
{
    Console.WriteLine("Oui, nous avons au moins un animal qui peut voler");
    listAnimalQuiPeuventVoler.ForEach(item => Console.WriteLine(item.Prenom));
}


Console.WriteLine("********** Liste des capacités ? **********");
var queryCapacites = from animal in animaux
                     select animal.Capacites;

foreach (var item in queryCapacites)
{
    foreach (var capacite in item)
    {
        Console.WriteLine(capacite.Value);
    }
}


//var queryCapacites2 = from item in queryCapacites
//                      select item.GroupBy();

Console.WriteLine("********** L'âge maximal de tous les animaux **********");


var monExpressionLambda = (AnimalFantastique item) => item.Age; 
var result = animaux.Max(monExpressionLambda);

var result2 = animaux.Max(item => item.Age);


int GetAge(AnimalFantastique item)
{
    return item.Age;
}
var result3 = animaux.Max(GetAge);

Console.WriteLine("Age max ? {0}", result);



List<int> list = new List<int>() { 1, 2, 3, 7 };
int result4 = list.Max();
