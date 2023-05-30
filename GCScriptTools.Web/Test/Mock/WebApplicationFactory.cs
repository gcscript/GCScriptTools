namespace GCScriptTools.Web.Tests.Mock;

internal class WebApplicationFactory : Microsoft.AspNetCore.Mvc.Testing.WebApplicationFactory<Program>
{
    protected override IHost CreateHost(IHostBuilder builder) => base.CreateHost(builder);
}
