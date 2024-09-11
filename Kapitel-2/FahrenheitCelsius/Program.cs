// program för att konvertera från fahrenheit till celsius
Console.Clear();
Console.WriteLine("program för att konvertera från fahrenheit till celsius");

//Läser in temperaturen i Fahrenheit
Console.Write("ange temperaturen i Fahrenheit: ");

double tempFahrenheit = double.Parse(Console.ReadLine());

//Konvertera Fa -> ce

double tempCelsius = (tempFahrenheit) -32 * 1.8;


//Skriva ut resultatet med decimaler
Console.WriteLine($"{tempFahrenheit} F blir {tempCelsius} C");
