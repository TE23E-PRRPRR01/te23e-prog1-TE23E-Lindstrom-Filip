using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;

Console.Clear();

List<string> namn = ["Anna", "Björn", "Cecilia"];

Console.WriteLine($"Nuvarande lista: {string.Join(", ", namn)}");

Console.WriteLine($"Ange namn att lägga till:");
string adnamn = Console.ReadLine();
namn.Add(adnamn);

Console.WriteLine($"Listan efter tillagtnamn: {string.Join(", ", namn)}");


while (true)
{
    Console.WriteLine($"Ange namn att ta bort till:");
    string removenamn = Console.ReadLine();

    if (namn.Contains("removenamn"))
    {
        namn.Remove(removenamn);
        break;
    }
    else
    {
        Console.WriteLine("Namnet fanns inte i listan");
    }
    
    Console.WriteLine($"Listan efter bortaget namn: {string.Join(", ", namn)}");

}