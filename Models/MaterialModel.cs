namespace _3DPrinterCalculator.Models
{
    public class MaterialModel 
    {
        public bool IsFilament { get; set;}
        public int MaterialPrice { get; set; }
        public int ResinWeight { get; set; }
        
        
        public decimal ExpendedMaterial { get; set; }
        public string CalculateCostPerGram()
        {
            if (IsFilament)
            {
                var filamentPricePerGram = (decimal)MaterialPrice / 1000m;
                var filamentPrintCost =  filamentPricePerGram * ExpendedMaterial;
                
                return $"{filamentPrintCost:C}";
            }
            else
            {
                var resinPricePerGram = (decimal)MaterialPrice / ResinWeight ;
                var resinPrintCost = resinPricePerGram * ExpendedMaterial;
                
                return $"{resinPrintCost:C}";
            }

        }

    }
}