using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<List<Country>> GetCountriesAsync()
    {
        var response = await _httpClient.GetAsync("https://api.sampleapis.com/countries/countries");
        response.EnsureSuccessStatusCode();
        var responseBody = await response.Content.ReadAsStringAsync();
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        return JsonSerializer.Deserialize<List<Country>>(responseBody, options);
    }
}