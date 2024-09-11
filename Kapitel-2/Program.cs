// program för att konvertera temperaturen i celsius till fahrenheit
Console.Clear();
Console.WriteLine("program för att konvertera temperaturen i celsius till fahrenheit");


// Läser in temp i Celsius

Console.Write("Ange temperatur i Celsius");

int tempCelsius = int.Parse(Console.ReadLine());

// Konvertera till fahrenheit

int tempFahrenheit = tempCelsius * 1.8 + 32;

// skriver ut resultat

Console.WriteLine($"{tempCelsius} Celsius är {tempFahrenheit} fahrnheit");
