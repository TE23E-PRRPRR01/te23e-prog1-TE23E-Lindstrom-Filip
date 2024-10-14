//använda listor för skapa/hantera samlingar
using System.ComponentModel;

Console.Clear();
//clr

//Lisat på trevliga frukter, tex "äpple", "apelsin", "annanas"
List<string> frukter = ["äpple", "apelsin", "annanas"];

Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

// ändra i listan:
frukter[0] = "banan";
Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

// gå igenom listan = loopa igenom = från första till sista 

foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}

//skapa en lisat på valfri ska (4st)
//skriv ut varje sak på samma rad

//Lisat på trevliga frukter, tex "äpple", "apelsin", "annanas"
List<string> bilar = ["911", "718", "carrera" , "918"];

Console.WriteLine($"Min billista: {bilar[0]}, {bilar[1]}, {bilar[2]}, {bilar[3]}");

foreach (var bil in bilar)
{
    Console.Write($"{bil}");
}

for (var i = 0; i < bilar.Count; i++)
{
    Console.Write( $"{bilar [1]}" );
}


Console.Clear();


//skapa ett register
//en tom lista
List<string> namnlista = [];

// while loop


while (true)
{
    Console.Write("ange ett namn: ");
    string namn = Console.ReadLine();
    namnlista.Add(namn);

    
    foreach (var namnet in namnlista)
    {
        Console.Write($"{namnet},");
    }
    
}