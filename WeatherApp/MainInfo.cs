namespace WeatherApp;

// Uma classe para guardar as informações de "main"
public class MainInfo
{
    // O nome da propriedade (Temp) é igual à chave no JSON ("temp")
    public double Temp { get; set; } 
}

// Uma classe para as informações dentro da lista "weather"
public class WeatherInfo
{
    // A propriedade pode ser nula, então adicionamos '?'
    public string? Description { get; set; } 
}

// A classe principal que representa a resposta completa
public class WeatherApiResponse
{
    // Todas as propriedades que são objetos ou strings podem ser nulas
    public string? Name { get; set; } 
    public MainInfo? Main { get; set; } 
    public List<WeatherInfo>? Weather { get; set; } 
}