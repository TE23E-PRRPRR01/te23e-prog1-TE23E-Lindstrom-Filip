// Ett litet spel - gissa ett hemligt heltal
using System.ComponentModel.Design;

Console.Clear();
Console.WriteLine("Ett litet spel - gissa ett hemligt heltal");

// slumpa ett tal
int slumptalet = Random.Shared.Next (1, 101); // 1-100 man har med minsta värde men inte största

Console.WriteLine($"Slumptalet är {slumptalet}");
//Console.WriteLine("Slumptalet är" + "slumptalet");

Console.Write("Gissa ett tal 1-100: ");
// läs in texten, t ex "100"
string gissningText = Console.ReadLine();

// kovertera text till heltal
int gissning = int.Parse(gissningText);

if (gissning >= 70)
{
    Console.WriteLine("Fel, talet är lägre");
}

else if (gissning > slumptalet)
{
    Console.WriteLine("för högt");
}
else
{
    Console.WriteLine("för lågt!");
}


