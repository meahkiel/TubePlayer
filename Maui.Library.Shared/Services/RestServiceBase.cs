namespace Maui.Library.Shared.Services;

public abstract class RestServiceBase
{
    protected readonly HttpClient _httpClient;
    protected readonly IBarrel _barrel;
    protected readonly IConnectivity _connectivity;

    protected RestServiceBase(
        HttpClient httpClient, 
        IBarrel barrel, 
        IConnectivity connectivity)
    {
        _httpClient = httpClient;
        _barrel = barrel;
        _connectivity = connectivity;
    }

    protected async Task<TResult> GetAsync<TResult>(string url, object valueParameter = null) where TResult : class
    {
        var response = await _httpClient.GetAsync(url);
        if (!response.IsSuccessStatusCode)
            throw new HttpGetErrorException(url);

        var data = await response.Content.ReadFromJsonAsync<TResult>();

        return data;
    }
}
