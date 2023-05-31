using System;
namespace NouvelleAppliFacturation
{
    public class LigneFacture
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public int Quantite { get; set; }
        public double PrixUnitaire { get; set; }
        public double Total { get; set; }
    }
}

