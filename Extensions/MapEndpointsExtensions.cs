using _3DPrinterCalculator.DTO;
using _3DPrinterCalculator.Models;

namespace _3DPrinterCalculator.Extensions;

public static class MapEndpointsExtensions
{
    public static void MapEndpoints(this WebApplication app)
    {
        app.MapPost("/calculate", (PrintCostRequest request) =>
        {
            if (request.MaterialPrice <= 0 || request.MaterialWeight <= 0)
                return Results.BadRequest("O preço e/ou preço do material deve ser maior que zero");

            var calculator = new PrintCost();

            var total = calculator.CostCalculate(
                request.MaterialPrice,
                request.MaterialWeight,
                request.UsedMaterial,
                request.PrintingTime,
                request.WattsConsumption,
                request.EnergyCost,
                request.Profit
            );

            var totalWp = calculator.CostCalculate(
                request.MaterialPrice,
                request.MaterialWeight,
                request.UsedMaterial,
                request.PrintingTime,
                request.WattsConsumption,
                request.EnergyCost,
                request.Profit
            );
            
            return Results.Ok(new
            {
                totalWithoutProfit = totalWp,
                totalWithProfit = total,
            });
        }); 
    }
}