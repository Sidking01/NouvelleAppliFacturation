using System;
using static System.Console;
using System.Text.RegularExpressions;

namespace NouvelleAppliFacturation
{
	public class AffichageFacture
	{
        public void AfficherFacture(List<Facture> laFacture)
        {
            foreach(var facture in laFacture)
            {
                Console.WriteLine($"Facture ID: {facture.Id}");
                Console.WriteLine($"Date: {facture.Date}");
                Console.WriteLine($"Client: {facture.Client}");
                Console.WriteLine("\nLignes de facture :");

                foreach (var ligne in facture.Lignes)
                {
                    Console.WriteLine($"  ID: {ligne.Id}, Description: {ligne.Description}, Quantité: {ligne.Quantite}, Prix unitaire: {ligne.PrixUnitaire}, Total: {ligne.Total}");
                }

                Console.WriteLine($"\nTotal de la facture : {facture.Total}");
                WriteLine();
            }
            
        }
    }
}

