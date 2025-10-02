using _3DPrinterCalculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace _3DPrinterCalculator.Extensions;

public static class MapEndpointsExtensions
{
    public static void MapEndpoints(this WebApplication app)
    {
        app.MapPost("/calculateCost", ([FromBody] MaterialModel model) =>
        {
            try
            {   
                var costPerGram = model.CalculateCostPerGram();
                return Results.Ok(new { costPerGram });
            }
            catch (Exception e)
            {
                return Results.BadRequest( new {error = e.Message });
            }
        });
    }
}