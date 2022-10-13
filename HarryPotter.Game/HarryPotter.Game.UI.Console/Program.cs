
using HarryPotter.Core.Library.Exceptions;
using HarryPotter.Core.Library.Models;
using HarryPotter.Core.Library.UI;
using HarryPotter.Core.Tools;
using System;
using System.Collections.Generic;
using MonCore = HarryPotter.Core.Library.Models;
using MonEspace = Toto;

#region Coeur de l'application
Menu menu = new Menu();
MonEspace.Menu m;

MonCore.Profil profil = null;
// profil.DateDeNaissance = DateTime.Now;

List<Sort> sorts = new List<Sort>();
List<Character> characters = new List<Character>();
List<Baguette> baguettes = new List<Baguette>();

void PreparePersonnages()
{
    characters.Add(new GentilCharacter("Hermione"));
    characters.Add(new GentilCharacter("Harry Potter"));
    characters.Add(new MechantCharacter("Voldemort"));
}

void AfficherPersonnages()
{
    Console.WriteLine("------------ LES PERSONNAGES DISPONIBLES -------------");
    Console.ForegroundColor = ConsoleColor.DarkGreen;

    //foreach (var item in characters)
    //{

    //}
    characters.ForEach(item =>
    {
        Console.WriteLine(item);
    });

    Console.ForegroundColor = ConsoleColor.White;
}

void SelectionnerPersonnage()
{
    Console.WriteLine("Votre perso pour le jeu ?");
    string persoSaisie = Console.ReadLine();

    Character selectionPerso = characters[int.Parse(persoSaisie) - 1];
    //if (profil != null)
    //{
    //    profil.AffecterPersonnage(selectionPerso);
    //}
    profil?.AffecterPersonnage(selectionPerso);
}

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
}

void PreparerBaguettes()
{
    baguettes.Add(new BoisSureauBaguette());
    baguettes.Add(new PlumePhoenixBaguette());
    baguettes.Add(new EcailleDragonBaguette());
}

void AfficherBaguettes()
{
    Console.WriteLine("------------ les baguettes disponibles -------------".ToUpper());

    Console.ForegroundColor = ConsoleColor.DarkYellow;

    baguettes.ForEach(baguette =>
    {
        Console.WriteLine(baguette);
    });
    Console.ForegroundColor = ConsoleColor.White;
}

void SelectionBaguette()
{
    Console.WriteLine("Choix de la baguette");
    string baguetteSaisie = Console.ReadLine();
    Baguette baguetteSelectionnee = null;

    baguetteSelectionnee = baguettes[int.Parse(baguetteSaisie) - 1];

    profil?.AffecterBaguetteAuPersonnage(baguetteSelectionnee);
}

void SaisieProfil(ILogger logger) 
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

        logger.Ecrire(ex.Message);

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
    PreparerBaguettes();
    PreparePersonnages();
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
//AfficherSortsDisponibles();
//SelectionSortALancer();

var logger = new FichierLogger();
SaisieProfil(logger);

AfficherPersonnages();
SelectionnerPersonnage();
AfficherBaguettes();
SelectionBaguette();

AfficherMenu();
#endregion
