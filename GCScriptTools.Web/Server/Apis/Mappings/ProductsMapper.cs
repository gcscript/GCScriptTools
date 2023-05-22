namespace GCScriptTools.Web.Server.Apis.Mappings;

public static class ProductsMapper
{
    public static WebApplication MapProducts(this WebApplication app )
    {
        app.MapGet("api/Product/GetFromMinimal", () => new Shared.Models.Product() { Id = Guid.NewGuid(), Name = "Minimal Product" });
        
        app.MapGet("api/Product/GetFromMinimal2", () => new Shared.Models.Product() { Id = Guid.NewGuid(), Name = "Minimal Product 2" });

        return app;
    }
}
