namespace _3DPrinterCalculator.Extensions;

public static class MapEndpointsExtensions
{
    public static void MapEndpoints(this WebApplication app)
    {
        app.MapGet("/",  () => "Hello World!");
    }
}