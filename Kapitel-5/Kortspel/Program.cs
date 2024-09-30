// Hur man skapar och använder listor
Console.Clear();
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Slumpa kort ur en kortlek!");

// Ett annat exempel, lista på 3 årtal
List<int> årtal = [1957, 1969, 1989];


// skapa en lista kort

List<string> kortlek = ["🂡", "🂢", "🂣", "🂤", "🂥", "🂦", "🂧	", "🂨",
"🂩", "🂪", "🂬", "🂭", "🂮"];


// för emoji använde 
List<string> kortlek = ["🂡", "🂢", "🂣", "🂤", "🂥", "🂦", "🂧	", "🂨",
"🂩", "🂪", "🂬", "🂭", "🂮"];


int antal = 5;

while (antal > 0)
{
    // slumpa index 0-12
    int index = Random.Shared.Next(0, kortlek.Count);
    Console.WriteLine($"det slumpade index = {index}");

    // plocka ut det sjunde kortet
    string kort = kortlek[index];

    // Ta bort kortet ur kortleken
    kortlek.RemoveAt(index);

    // skriv ut sjunde kortet, index 6
    Console.WriteLine($"Det slumpade kortet är {kort}");


    // räkna ned 
    antal--;
}


