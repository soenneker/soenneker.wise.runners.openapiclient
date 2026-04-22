using Soenneker.Tests.HostedUnit;

namespace Soenneker.Wise.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class WiseOpenApiClientRunnerTests : HostedUnitTest
{
    public WiseOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
