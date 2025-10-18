namespace _3DPrinterCalculator.Models;

public class PrintCost
{
    public decimal CostCalculate(decimal materialPrice, decimal materialWeight, decimal usedMaterial,
        decimal printingTime, decimal wattsConsumption, decimal energyCost)
    {
        var pieceCost = ((materialWeight / 1000m) * materialPrice) * usedMaterial;
        var printerCost = ((wattsConsumption / 1000m) * energyCost) * (printingTime / 60m);

        var total = printerCost + pieceCost;
        return Math.Round(total, 2);
    }

    public decimal ApplyProfit(decimal baseCost, int profitPercentage)
    {
        var totalWithProfit = baseCost * (1 + (profitPercentage / 100m));
        return Math.Round(totalWithProfit, 2);
    }
}