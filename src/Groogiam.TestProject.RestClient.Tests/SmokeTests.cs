using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;

namespace Groogiam.TestProject.RestClient.Tests;

public class SmokeTests
{
    public SmokeTests(ITestOutputHelper output)
    {
        _output = output ?? throw new ArgumentNullException(nameof(output));
    }

    public readonly string ApiKey = "Your Api Key Here";

    private readonly ITestOutputHelper _output;

    [Fact]
    public async Task Should_Get_Agents()
    {
        using var httpClient = new HttpClient();

        var client = new AgentsClient(httpClient)
        {
            ApiKey = ApiKey
        };

        _output.WriteLine(client.BaseUrl);

        var agents = await client.GetAgentsAsync(string.Empty, null, null);

        Assert.NotEmpty(agents);

        _output.WriteLine(JsonConvert.SerializeObject(agents, Formatting.Indented));
    }
}