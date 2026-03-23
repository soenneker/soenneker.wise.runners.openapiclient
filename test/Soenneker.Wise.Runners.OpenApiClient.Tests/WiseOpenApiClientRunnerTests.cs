using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Wise.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class WiseOpenApiClientRunnerTests : FixturedUnitTest
{
    public WiseOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
