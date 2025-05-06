using MultipleHtppClient.Infrastructure;

namespace MultipleHtppClient.API;

public interface IUseHttpService
{
    Task<ApiResponse<IEnumerable<Product>>> GetAllProductsAsync();
}
