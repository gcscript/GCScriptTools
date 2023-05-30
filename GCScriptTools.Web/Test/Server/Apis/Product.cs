using FluentAssertions;

namespace GCScriptTools.Web.Tests.Server.Apis;

internal class ProductTests : BaseApiTests
{
    [Test]
    public async Task GetAsync()
    {
        var result = await Client!.GetFromJsonAsync<Shared.Models.Product>("api/Product/GetFromMinimal");
        result.Should().NotBeNull();
        result!.Name.Should().Be("Minimal Product");
    }

    [Test]
    public async Task Get2Async()
    {
        var result = await Client!.GetFromJsonAsync<Shared.Models.Product>("api/Product/GetFromMinimal2");
        result.Should().NotBeNull();
        result!.Name.Should().Be("Minimal Product 2");
    }

}
