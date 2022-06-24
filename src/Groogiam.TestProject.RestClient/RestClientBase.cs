using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Groogiam.TestProject.RestClient;

public class RestClientBase
{
    /// <summary>
    /// Api key which will be passed via the Authorization header.
    /// </summary>
    public string ApiKey { get; set; }

    protected Task<HttpRequestMessage> CreateHttpRequestMessageAsync(CancellationToken cancellationToken)
    {
        var request = new HttpRequestMessage();
        request.Headers.Add("Authorization", ApiKey);
        return Task.FromResult(request);
    }
}