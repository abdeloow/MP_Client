using MultipleHtppClient.Infrastructure;

namespace MultipleHtppClient.API;

public class UseHttpService : IUseHttpService
{
    private readonly IHttpClientService _clientService;
    public UseHttpService(IHttpClientService clientService) => _clientService = clientService;
    public async Task<ApiResponse<IEnumerable<Product>>> GetAllProductsAsync()
    {
        ApiRequest<object> request = new ApiRequest<object>
        {
            ApiName = "rest-dev-api",
            Endpoint = "/objects",
            Method = HttpMethod.Get
        };
        return await _clientService.SendAsync<object, IEnumerable<Product>>(request);
    }
}
