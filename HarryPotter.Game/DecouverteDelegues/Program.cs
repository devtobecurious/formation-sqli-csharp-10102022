

using DecouverteDelegues;

void CalculerSomme(int param1, int param2, Afficher affiche)
{
    // Calculer
    int result = param1 + param2;

    // Afficher (ou comment ...)
    affiche(result.ToString());
}

void DisplayEnVert(string mess)
{
    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine(mess);

    Console.ForegroundColor = ConsoleColor.White;
}

void DisplayEnRouge(string mess)
{
    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine(mess);

    Console.ForegroundColor = ConsoleColor.White;
}


// Demander à l'utilisateur 
Console.WriteLine("Quelle est la couleur d'affichage ?");
Console.WriteLine("1. Vert, 2. Rouge, 3. Neutre");
string saisie = Console.ReadLine();

Afficher choixAffichage = null;
if (saisie == "1")
{
    choixAffichage = DisplayEnVert;
} 
else if (saisie == "2")
{
    choixAffichage = DisplayEnRouge;
}
else if (saisie == "3")
{
    choixAffichage = Console.WriteLine;
}


void AfficherAvecDeuxParametres(string mess, string mess2)
{

}

CalculerSomme(1, 2, choixAffichage);


Afficher choixAffichage2 = (string mess) =>
{
    
};
choixAffichage2("coucou");

CalculerSomme(2, 3, choixAffichage2);

CalculerSomme(5, 6, messa => Console.WriteLine(messa) );

// CalculerSomme(1, 2, AfficherAvecDeuxParametres);

