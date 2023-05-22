namespace GCScriptTools.Web.Server.Apis.Mappings;

public static class ProductsMapper
{
    public static WebApplication MapProducts(this WebApplication app )
    {
        app.MapGet("api/Product/GetFromMinimal", () => ProductsApis.Get());

        app.MapGet("api/Product/GetFromMinimal2", () => ProductsApis.Get2());

        return app;
    }
}
