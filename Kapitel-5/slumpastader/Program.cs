// Hur man skapar och använder listor
Console.Clear();

Console.WriteLine("Slumpa en stad!");

// skapa en lista kort

List<string> städer = ["Stockholm", "Oslo", "Köpenhamn", "Berlin", "Madrid", "Lissabon", "Paris", "Helsingfors",
"Wien", "Budapest",];


int antal = 10;

while (antal > 0)
{
    // slumpa index 0-12
    int index = Random.Shared.Next(0, 10);
    Console.WriteLine($"det slumpade index = {index}");

    // plocka ut det sjunde kortet

    string stad = städer[index];


    // skriv ut sjunde kortet, index 6
    Console.WriteLine($"Den slumpade staden är {stad}");


    // räkna ned 
    antal--;
}