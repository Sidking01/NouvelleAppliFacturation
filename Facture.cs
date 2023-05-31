using System;
namespace NouvelleAppliFacturation
{
    public class Facture
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? Client { get; set; }
        public List<LigneFacture> Lignes { get; set; }
        public decimal Total { get; set; }

        public Facture()
        {
            Lignes = new List<LigneFacture>();
        }
    }
}

