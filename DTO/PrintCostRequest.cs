namespace _3DPrinterCalculator.DTO;

public class PrintCostRequest
{
    public decimal MaterialPrice { get; set; }
    public decimal MaterialWeight { get; set; }
    
    public decimal UsedMaterial { get; set; }
    public decimal PrintingTime { get; set; }
    public decimal WattsConsumption { get; set; }
    public decimal EnergyCost { get; set; }
    public int Profit { get; set; }
}