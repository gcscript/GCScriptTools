using GCScriptTools.Web.Shared.Models;

namespace GCScriptTools.Web.Server.Apis
{
    public static class ProductsApis
    {
        internal static Product Get() => new Product() { Id = Guid.NewGuid(), Name = "Minimal Product" };

        internal static Product Get2() => new Product() { Id = Guid.NewGuid(), Name = "Minimal Product 2" };

    }
}
