//Slumpa många tal och spara i lista
using System.ComponentModel;

Console.Clear();
Console.WriteLine();

//Globala variabler
//En lista för heltal
List<int> listaslumptal = [];

// be användaren ange antal slumpade tal
Console.WriteLine("hur många slumpade tal vill du ha?");
int antal = int.Parse(Console.ReadLine());

// be användaren ange min tal
Console.WriteLine("Ange lägsta slumptal");
int mintal = int.Parse(Console.ReadLine());

// be användaren ange max tal
Console.WriteLine("ange största slumptal");
int maxtal = int.Parse(Console.ReadLine());



//Loopa fem gånger
for (var i = 0; i < antal; i++)
{
    // SLumpa ett tal 1-100
    int slumptal = 0;
    slumptal = Random.Shared.Next(mintal, maxtal + 1);

    // lägg till slumptalet i listan 
    listaslumptal.Add(slumptal);

    Console.WriteLine($"Slumpat tal {i + 1}: {slumptal}");

}

