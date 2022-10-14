#region ADO.net (à l'ancienne)
//using(var connection = new Microsoft.Data.SqlClient.SqlConnection())
//{
//    connection.ConnectionString = "";
//    connection.Open();

//    using (var command = new Microsoft.Data.SqlClient.SqlCommand("", connection))
//    {
//        command.CommandText = "SELECT * FROM Ennemi";
//        using (var reader = command.ExecuteReader())
//        {
//            while (reader.Read())
//            {

//            }
//            reader.Close();
//        }
//    }

//    connection.Close();
//}
#endregion

#region Façon EFCore
using Microsoft.EntityFrameworkCore;
using TestBDD;
using TestBDD.Models;

// On doit dire :
// 1. Définir la chaine de connexion
// 2. Définir vers quel type de bdd (sql server, oracle, .. ?)

var builder = new DbContextOptionsBuilder();

var connectionString = "Server=DESKTOP-1446PBQ;Database=HarryPotter.Database.10102022;Trusted_Connection=True; Encrypt=true; TrustServerCertificate=true;";
builder.UseSqlServer(connectionString);

var context = new DefaultDbContext(builder.Options);

var query = from item in context.Enemies
            where item.Id > 0
            select item;

// ouvre, requete, cree la liste, remplit la liste, ferme la connexion
var list = query.ToList();

Console.WriteLine("-------------------- REQUETE SELECT * --------------");
foreach (var item in list)
{
    Console.WriteLine(item.Prenom);
}

Console.WriteLine("-------------------- REQUETE SELECT * DEPUIS ENEMIES --------------");
foreach (var item in context.Enemies)
{
    Console.WriteLine(item.Prenom);
}


Console.WriteLine("-------------------- PREPARATION AJOUT 2 ENNEMIS --------------");
var nouvelEnemi = new Ennemi() { PointsDeVie = 150, Prenom = "Beatrix" };
context.Enemies.Add(nouvelEnemi);

var nouvelEnemi2 = new Ennemi() { PointsDeVie = 200, Prenom = "Nim" };
context.Enemies.Add(nouvelEnemi2);

Console.WriteLine("-------------------- SAUVEGARDE EN BDD DES 2 ENNEMIS --------------");
context.SaveChanges();

Console.WriteLine("-------------------- AFFICHAGE DE MA PREMIERE LIST --------------");
foreach (var item in list)
{
    Console.WriteLine(item.Prenom);
}

Console.WriteLine("-------------------- AFFICHAGE DES DONNEES DANS MON DBSET --------------");
foreach (var item in context.Enemies)
{
    Console.WriteLine(item.Prenom);
}
#endregion