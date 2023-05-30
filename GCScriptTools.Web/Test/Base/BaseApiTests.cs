namespace GCScriptTools.Web.Tests.Server.Apis;

public class BaseApiTests
{
    internal GCScriptTools.Web.Tests.Mock.WebApplicationFactory? Aplication { get; private set; }
    public IServiceScope? Scope { get; private set; }
    public IServiceProvider? Provider { get; private set; }
    public HttpClient? Client { get; private set; }

    [SetUp]
    public void Setup()
    {
        Aplication = new();
        Scope = Aplication!.Services.CreateScope();
        Provider = Scope!.ServiceProvider;
        Client = Aplication!.CreateClient();
    }
}