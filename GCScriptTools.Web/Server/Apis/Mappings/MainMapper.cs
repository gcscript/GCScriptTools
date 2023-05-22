namespace GCScriptTools.Web.Server.Apis.Mappings;

public static class MainMapper
{
    public static WebApplication MapApis(this WebApplication app)
    {
        // Products
        app.MapProducts();

        // ...

        // For Fluent Sintax builder:
        return app;
    }
}
