// Program för kryptering med cesar-chiffer
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Ett program för kryptering med cesar-chiffer");

// alfabetet
string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";


// anger en bokstav
Console.Write("ange ett meddelande: ");
string meddelande = Console.ReadLine().ToUpper();


Console.Write("ange krypteringsnyckel (1-9): ");
int nyckel = int.Parse(Console.ReadLine());

foreach (char bokstav in meddelande)
{
    // hitta bokstavns position (index)
    int index = alfabetet.IndexOf(bokstav);
    // Console.WriteLine($" '{bokstav}' så är index = '{index}'");

    //om bokstaven finns i alfabetet
    if (index != -1)
    {
        // Cesar kryptering, addera en nyckel (tex 3)
        int nyIndex = index + nyckel;
        // Console.WriteLine($" {index} + {nyckel} = {nyIndex}");

        // börja om från början
        if (nyIndex >= alfabetet.Length)
        {
            nyIndex = nyIndex - alfabetet.Length;
        }
        //plocka ut bokstaven för nyIndex
        char krypteradBokstav = alfabetet[nyIndex];
        // Console.WriteLine($"{nyIndex} är meddlandet {krypteradBokstav}");

        Console.Write(krypteradBokstav);
    }

    else
    {
        // Console.WriteLine($"Bokstaven oförändrad: {meddelande}");
        Console.Write(bokstav);
    }
}

