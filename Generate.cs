using System;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NouvelleAppliFacturation
{
	public class Generate
	{
		public Facture CreationAvecSaisie()
		{   
            Facture facture = new Facture();

			WriteLine("Numero facture :");
			int idFacture = Convert.ToInt32(ReadLine()!);
			DateTime DateFacture = DateTime.Today;
			WriteLine("Nom client :");
			string ClientFacture = ReadLine()!;

			facture = new Facture
			{
				Id = idFacture,
				Date = DateFacture,
				Client = ClientFacture
			};

			WriteLine("Nombre de produits :");
			int qnt = Convert.ToInt32(ReadLine()!);

			for(int i = 0; i < qnt; i++)
			{
                WriteLine("Id produit :");
				int idProduit = Convert.ToInt32(ReadLine()!);
                WriteLine("Description :");
                string DescriptionProduit = ReadLine()!;
                WriteLine("Quantite :");
                int quantiteProduit = Convert.ToInt32(ReadLine()!);
                WriteLine("Prix unitaire :");
                double prixProduit = Convert.ToDouble(ReadLine()!);

                facture.Lignes.Add(new LigneFacture
                {
                    Id = idProduit,
                    Description = DescriptionProduit,
                    Quantite = quantiteProduit,
                    PrixUnitaire = prixProduit,
                    Total = prixProduit*quantiteProduit
                });
            }

            facture.Total = (decimal)facture.Lignes.Sum(l => l.Total);

            return facture;
		}

        public Generate()
		{
		}
	}
}

