
using System.Reflection.Metadata.Ecma335;

namespace MultipleHtppClient.Infrastructure;

public sealed class ApiKeyAuthHandler : IAuthenticationHandler
{
    public Task AuthenticateAsync(HttpClient client, ApiAuthConfig apiAuthConfig)
    {
        if (apiAuthConfig.Parameters.TryGetValue("key", out var apikey))
        {
            client.DefaultRequestHeaders.Add("api-subscription-key", apikey);
        }
        return Task.CompletedTask;
    }
    public bool CanHandle(AuthenticationType authenticationType) => authenticationType == AuthenticationType.ApiKey;
}
