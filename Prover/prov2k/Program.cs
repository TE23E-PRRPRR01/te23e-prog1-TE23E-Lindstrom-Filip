Console.Clear();

Console.WriteLine("Filmregister");

List<string> listafilmer = [];

//Be användaren ange antal filmer som ska registreras
Console.Write("Hur många filmer vill du registrera (3-5)");
string antalText = Console.ReadLine();
int antal = 0;
while (true)
{
    bool success = int.TryParse(antalText, out antal);
    if (success)
    {
        break;
    }
    else{
        Console.WriteLine("Mission failed! du mattade inte in ett heltal");
    }
}


//Lägger det i en loop då detta ska visas fler gånger
while (true)
{
    //Visa en meny med val
    Console.Write("""
1. Lägg till filmer
2. Lista alla filmer
3. Sök en film
4. Avsluta
Välj ett alternativ:
""");
Console.WriteLine("");

    string val = Console.ReadLine();


    if (val == "1")
    {

        for (int i = 0; i < antalfilmer;)
        {
            i++;
            Console.Write($"ange film {i}:");
            listafilmer.Add(Console.ReadLine());
        }

    }

    else if (val == "2")
    {
        Console.Clear();

        foreach (var filmnamn in listafilmer)
        {
            Console.WriteLine($"- {filmnamn}");
        }
    }

    else if (val == "3")
    {
        Console.Write("Ange en film att söka efter (första bokstaven): ");
        string bokstav = Console.ReadLine();
        foreach (var filmnamn in listafilmer)
        {
            //Kolla om varje film börjar på bokstaven
            if (filmnamn.StartsWith(bokstav))
            {
                Console.WriteLine(filmnamn);
            }
        }
    } 

    else if (val == "4")
    {
        Console.WriteLine("Tack för idag!");
        break;
    }
    else
    {
        Console.WriteLine("Du har angett något annat än 3-5, Försök igen!");
    }
}

