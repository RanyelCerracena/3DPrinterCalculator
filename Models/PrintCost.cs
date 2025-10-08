namespace _3DPrinterCalculator.Models;

public class PrintCost
{
    public decimal CostCalculate(decimal materialPrice, decimal materialWeight, decimal usedMaterial,
        decimal printingTime, decimal wattsConsumption, decimal energyCost, int profit)
    {
        var pieceCost = ((materialWeight / 1000m) * materialPrice) * usedMaterial;
        var printerCost = ((wattsConsumption / 1000m) * energyCost) * (printingTime / 60m);

        var totalWithoutProfit = printerCost + pieceCost;
        var totalWithProfit = totalWithoutProfit * (1 + (profit / 100m));
        var totalRounded = Math.Round(totalWithProfit, 2);

        return totalRounded;
    }
}