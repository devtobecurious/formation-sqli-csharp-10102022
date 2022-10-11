
using HarryPotter.Core.Library.Exceptions;
using HarryPotter.Core.Library.Models;
using HarryPotter.Core.Library.UI;
using System;
using System.Collections.Generic;
using MonCore = HarryPotter.Core.Library.Models;
using MonEspace = Toto;

#region Coeur de l'application
Menu menu = new Menu();
MonEspace.Menu m;

MonCore.Profil profil;
// profil.DateDeNaissance = DateTime.Now;

List<Sort> sorts = new List<Sort>();

void PrepareSorts()
{
    //var sort = new Sort(0);
    //Sort sort2 = new(10);

    sorts.Add(new AvadaKedavraSort(1));
    sorts.Add(new EndolorisSort(2));
    sorts.Add(new StupefixSort(3));
}

void AfficherSortsDisponibles()
{
    Console.WriteLine("------------ LES SORTS DISPONIBLES -------------");

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    foreach (var item in sorts)
    {
        Console.WriteLine(item);
    }
    Console.ForegroundColor = ConsoleColor.White;
}

void SelectionSortALancer()
{
    Console.WriteLine("Choix du sort");
    string sortSaisie = Console.ReadLine();
    Sort sortSelectionne = null;

    sortSelectionne = sorts[int.Parse(sortSaisie) - 1];

    sortSelectionne.Lancer();

    //switch (int.Parse(sortSaisie))
    //{
    //    case 1:
    //        {
    //            sortSelectionne = sorts[0];
    //        } break;

    //    case 2:
    //        {
    //            sortSelectionne = sorts[1];
    //        }
    //        break;

    //    case 3:
    //        {
    //            sortSelectionne = sorts[2];
    //        }
    //        break;
    //}
}

void SaisieProfil() 
{
    var prenom = "";
    var dateNaissance = DateOnly.MinValue;
    var age = 0;

    Console.WriteLine("------------ PROFIL -------------");

    do
    {
        Console.WriteLine("Ton prénom ?");
        prenom = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(prenom));
    
    do
    {
        bool dateValide = false;
        do
        {
            Console.WriteLine("Ta date de naissance maintenant ?");

            string date = Console.ReadLine();
            dateValide = DateOnly.TryParse(date, out dateNaissance);

        } while (! dateValide);

    } while (dateNaissance == DateOnly.MinValue);

    do
    {
        Console.WriteLine("Ton âge s'il te plaît, pour vérif");
        string ageSaisie = Console.ReadLine();

        int.TryParse(ageSaisie, out age);

        //        age = int.Parse(ageSaisie);

    } while (age <= 0);

    try
    {
        //Console.WriteLine("----> Saisie ?");

        //Console.WriteLine((10 / int.Parse(Console.ReadLine())));

        profil = new MonCore.Profil(dateNaissance.ToDateTime(TimeOnly.MinValue), prenom, age);

        //profil.Prenom = "Harry";
    }
    catch (AgeNonAttenduException ex) when (ex.AgeLimit < 10)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Age bcp trop faible, vous avez saisie " + ex.AgeSaisie);
        Console.ForegroundColor = ConsoleColor.White;

        throw;
    }
    catch (AgeNonAttenduException ex) when (ex.AgeLimit < 13)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Age trop faible, vous avez saisie " + ex.AgeSaisie);
        Console.ForegroundColor = ConsoleColor.White;
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Erreur de calcul");
    }
    //catch (Exception ex)
    //{
    //    Console.WriteLine("OOPs une erreur est apparue dans votre saisie !" + ex.Message);

    //    //if (ex is AgeNonAttenduException)
    //    //{
    //    //    
    //    //}
    //}
    finally
    {
        // Console.WriteLine("Quelque soit le fait qu'il y ait eu une erreur");
    }
}

void PreparerMenu()
{
    MenuItem item = new MenuItem();

    //menu.Items.Add(new MonCore.MenuItem(libelle: "Nouvelle partie"));
    //menu.Items.Add(new MonCore.MenuItem(2, "Charger une partie"));
    //menu.Items.Add(new MonCore.MenuItem(3, "A propos"));

    menu.Ajouter(0, "Saisie de ton profil");

    menu.Ajouter(new MenuItem(libelle: "Nouvelle partie"));
    menu.Ajouter(new MenuItem(2, "Charger une partie"));
    menu.Ajouter(new MenuItem(3, "A propos"));


    var monItem = new MenuItem(4);

    monItem.Libelle = "Statistiques";
    menu.Ajouter(monItem);

    menu.Ajouter(-1, "Quitter");
}
 
void PreparationJeu()
{
    PrepareSorts();
    PreparerMenu();    
}

void AfficherMenu()
{
    Console.ForegroundColor = ConsoleColor.Cyan;

    Console.WriteLine("************* MENU ***********");

    menu.Afficher();

    // 1. Affichage sans classe
    //Console.WriteLine("1. Nouvelle partie");
    //Console.WriteLine("2. Charger une partie");
    //Console.WriteLine("3. A propos");
    //Console.WriteLine("4. Quitter le jeu");

    // 2. 

    Console.ForegroundColor = ConsoleColor.White;
}
#endregion

#region Exécution de l'application
PreparationJeu();
AfficherSortsDisponibles();
SelectionSortALancer();

SaisieProfil();
AfficherMenu();
#endregion
