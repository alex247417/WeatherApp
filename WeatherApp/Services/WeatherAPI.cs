namespace WeatherApp.Services;

using Microsoft.Extensions.Configuration; 
using System.Net.Http;
using System.Net.Http.Json;

public class WeatherAPI
{
    private readonly IConfiguration _configuration;
    private readonly HttpClient _httpClient;

    // Construtor que recebe a configuração do .NET
    public WeatherAPI(IConfiguration configuration)
    {
        _configuration = configuration;
        _httpClient = new HttpClient();
    }

    public async Task<WeatherApiResponse?> GetWeather(string? city)
    {
        // Lê a chave secreta a partir da configuração
        var apiKey = _configuration["OpenWeather:ApiKey"];

        // Se a chave não estiver no secrets.json, lança um erro claro
        if (string.IsNullOrEmpty(apiKey))
        {
            throw new InvalidOperationException("A chave da API (ApiKey) não foi configurada nos segredos do usuário.");
        }
        
        var requestUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric&lang=pt_br";
        
        var weatherData = await _httpClient.GetFromJsonAsync<WeatherApiResponse>(requestUrl);
        return weatherData;
    }
}