//Ett litet namnregister
Console.Clear();
Console.WriteLine("Ett litet namnregister");



List<string> namnlista = [];

//programloopen
while (true)
{
    // visa en meny 
    Console.WriteLine("""
1.Registrera namn 
2.Skriv ut alla namn 
3.avsluta
ange ditt val:
""");


    string val = Console.ReadLine();
    if (val == "1")
    {

        Console.Write("ange ett namn: ");
        string namn = Console.ReadLine();
        namnlista.Add(namn);

    }

    else if (val == "2")
    {
        foreach (var namnet in namnlista)
        {
            Console.Write($"{namnet},");
        }
    }

    else if (val == "3")
    {
        break;
    }
}


