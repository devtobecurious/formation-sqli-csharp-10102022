
using DecouverteEvenements.Models;

var chief = new Chief();
var tester = new Tester();

var developer = new Developer();


// Abonnnement / soubscription
developer.TravailFini += chief.VerifierTravail;
developer.TravailFini += tester.CheckerLesBugs;

// Exécution
developer.EcrireCode();

developer.TravailFini -= chief.VerifierTravail;

developer.EcrireCode();