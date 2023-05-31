using NouvelleAppliFacturation;
using static System.Console;


int choix;
Generate generate = new Generate();
AffichageFacture aff = new AffichageFacture();
List<Facture> lesFactures = new List<Facture>();

do
{
    WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
    WriteLine("+        Bienvenu, veuillez choisir l'action à effectuer :      +");
    WriteLine("+                1, Créer une facture                           +");
    WriteLine("+                2, Afficher une facture                        +");
    WriteLine("+                3, Quitter                                     +");
    WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
    choix = Convert.ToInt32(Console.ReadLine());

    switch (choix)
    {
        //cas 1 permet d'ajouter des employers 
        case 1:
            int arret = 0;
            do
            {
                Console.WriteLine("Voulez vous créer une facture ?");
                Console.WriteLine("Tapez 1.pour créer et 0.pour quitter");

                //Controle de saisie
                try
                {
                    arret = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Saisie incorect! veuillez saisir (0) ou (1)");
                }
            } while (arret != 0 && arret != 1);

            while (arret == 1)
            {
                var facture = generate.CreationAvecSaisie();
                lesFactures.Add(facture);
                WriteLine("Facture générer avec succes !");

                WriteLine();
                Console.WriteLine("Voulez vous créer une autre facture ?");
                Console.WriteLine("Tapez 1.pour créer et 0.pour quitter");
                arret = Convert.ToInt32(Console.ReadLine());
            }
                        
            break;
        case 2:
            aff.AfficherFacture(lesFactures);
            break;

    }
} while (choix != 3);