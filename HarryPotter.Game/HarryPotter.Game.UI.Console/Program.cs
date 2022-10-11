
using HarryPotter.Game.UI.Console.Core.Exceptions;
using MonCore = HarryPotter.Game.UI.Console.Core;
using MonEspace = Toto;

#region Coeur de l'application
MonCore.Menu menu = new MonCore.Menu();
MonEspace.Menu m;

MonCore.Profil profil;
// profil.DateDeNaissance = DateTime.Now;

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

    }
    catch (AgeNonAttenduException ex) when (ex.AgeLimit < 10)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Age trop faible, vous avez saisie " + ex.AgeSaisie);
        Console.ForegroundColor = ConsoleColor.White;

        throw;
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
 
void PreparationJeu()
{  

    MonCore.MenuItem item = new MonCore.MenuItem();

    //menu.Items.Add(new MonCore.MenuItem(libelle: "Nouvelle partie"));
    //menu.Items.Add(new MonCore.MenuItem(2, "Charger une partie"));
    //menu.Items.Add(new MonCore.MenuItem(3, "A propos"));

    menu.Ajouter(0, "Saisie de ton profil");

    menu.Ajouter(new MonCore.MenuItem(libelle: "Nouvelle partie"));
    menu.Ajouter(new MonCore.MenuItem(2, "Charger une partie"));
    menu.Ajouter(new MonCore.MenuItem(3, "A propos"));


    var monItem = new MonCore.MenuItem(4);

    monItem.Libelle = "Statistiques";
    menu.Ajouter(monItem);

    menu.Ajouter(-1, "Quitter");
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
SaisieProfil();
AfficherMenu();
#endregion
