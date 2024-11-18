using System.Security.Principal;

Console.Clear();

int antal;

Console.WriteLine("vad heter du?");
string namn = Console.ReadLine();

while (true)
{

    Console.WriteLine("Hur många gånger vill du repetera ditt namn?");
    bool lyckadesantal = int.TryParse(Console.ReadLine(), out antal);

    for (int i = 0; i < antal; i++)
    {
        Console.WriteLine($"{i} {namn}");
    }

    if (!lyckadesantal && antal >= 10 && antal <= 1)
    {
        Console.WriteLine("Du måste skriva ett heltal mellan 1-10 ");
    }
    else
    {
        break;
    }

}


