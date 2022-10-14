using LesAnimaux;
using LesAnimaux.UI.Console;
using System.Linq;

#region Apprentissage héritage + polymorphisme
//Animal animal1 = new Chat();
//Animal animal2 = new Chien();

//List<Animal> animals = new List<Animal>()
//{
//    animal1,
//    animal2,
//    new Gorille(),
//    null
//};

//animals.ForEach(animal =>
//{
//    if (animal != null)
//    {
//        animal.Dormir();
//    }
//}
//);


//foreach (Animal item in animals)
//{
//    item.Dormir();
//}

//animal1.Manger(10);
#endregion


#region Découverte LINQ
List<Chat> chats = new()
{
    new() { Prenom = "Matou", Couleur = ConsoleColor.Red, LePelage = Pelage.Tachete },
    new() { Prenom = "Gros minet", Couleur = ConsoleColor.Blue, LePelage = Pelage.Tachete },
    new() { Prenom = "Felix", Couleur = ConsoleColor.Black, LePelage = Pelage.Uni },
    new() { Prenom = "Rex", Couleur = ConsoleColor.Gray, LePelage = Pelage.Tigre, Longueur = 120 },
    new() { Prenom = "Bougie", Couleur = ConsoleColor.Gray, LePelage = Pelage.Uni, Longueur = 50 },
};

Console.WriteLine("-----------------------------------------------------------");

// Affiche moi la liste de tous les chats
foreach (var item in chats)
{
    Console.WriteLine(item.Prenom);
}

Console.WriteLine("-----------------------------------------------------------");
var queryListChats = from item in chats
                     select item;

foreach (var item in queryListChats)
{
    Console.WriteLine(item.Prenom);
}

Console.WriteLine("-----------------------------------------------------------");

// Ramener les chats tachetes
var queryListChatsTachetes = from item in chats
                             where item.LePelage == Pelage.Tachete
                             select item;

foreach (var item in queryListChatsTachetes)
{
    Console.WriteLine(item.Prenom);
}

Console.WriteLine("-----------------------------------------------------------");

// Ramener les chats tachetes et bleus
var queryListChatsTachetesEtBleus = from item in chats
                                     where item.LePelage == Pelage.Tachete && item.Couleur == ConsoleColor.Blue
                                     select item;

foreach (var item in queryListChatsTachetesEtBleus)
{
    Console.WriteLine(item.Prenom);
}

Console.WriteLine("-----------------------------------------------------------");


// Ramener les longueurs de chats
var queryLongueurs = from item in chats
                     select item.Longueur;

foreach (var item in queryLongueurs)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------------------------------------------------");

// Ramener les longueurs de chats et leur pelage
var queryLongueursEtPelage = from item in chats
                             select new { MonPelage = item.LePelage, MaLongueur = item.Longueur };

foreach (var item in queryLongueursEtPelage)
{
    Console.WriteLine(item.MaLongueur + ": " + item.MonPelage);
}

Console.WriteLine("-----------------------------------------------------------");

// Ramener les longueurs de chats et leur pelage avec classe existante
//List<PrenomEtCouleur> pcs = new List<PrenomEtCouleur>();
//foreach (var item in chats)
//{
//    pcs.Add(new PrenomEtCouleur() { Couleur = item.Couleur, Prenom = item.Prenom });
//}

//return pcs;
     

var queryLongueursEtPelage2 = from item in chats
                              select new PrenomEtCouleur() {  Couleur = item.Couleur, Prenom = item.Prenom };

foreach (var item in queryLongueursEtPelage2)
{
    Console.WriteLine(item.Prenom + ": " + item.Couleur);
}

Console.WriteLine("-----------------------------------------------------------");
#endregion












