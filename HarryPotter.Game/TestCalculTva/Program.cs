
using TestCalculTva;

var calculateur = new TestCalculTva.CalculateurTva();

Console.WriteLine("Montant HT ?");
string valeurSaisie = Console.ReadLine();

float getTvaA20pourcent()
{
    return 0.2f;
}

float getTvaA55pourcent()
{
    return 0.055f;
}

// RecuperererTva tva = null;
Func<float> tva = null;

Console.WriteLine("Choisissez la tva à appliquer : 1. 20%, 2. 10%, 3. 5.5%");
string tvaSaisie = Console.ReadLine();

switch (tvaSaisie)
{
    case "1":
        {
            tva = getTvaA20pourcent;
        }break;

    case "2":
        {
            tva = () => 0.1f;
        }
        break;

    case "3":
        {
            tva = getTvaA55pourcent;
        }
        break;
}


float montantTTC = calculateur.CalculTTC(float.Parse(valeurSaisie), tva);

Console.WriteLine("Le montant TTC est de {0}", montantTTC);

