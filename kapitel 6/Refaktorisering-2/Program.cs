/* *************************************************
 * Namn: SummeraTal
 * Beskrivning: Ett program för att summera tal
 * Datum: 2024-09-01
 *********************************************** */

StartProgram();

int poäng = 0; // Poängräkning för utmaningen

while (true)
{
    Console.WriteLine("""
    1. Skriv ut fyrkant
    2. Skriv ut triangel
    3. Skriv ut rektangel
    4. Skriv ut pyramid
    5. Spara figur
    6. Läs in sparad figur
    7. Utmaning: Gissa storleken
    8. Avsluta
    """);

    Console.Write("Välj ett alternativ: ");
    string val = Console.ReadLine();

    if (val == "1")
    {
        Console.Write("Ange storlek: ");

        int storlek = AngeStorlek();

        RitTecken();

        StorlekTecken();
    }

    else if (val == "2")
    {
        Höjd();
        RitTecken();

        for (int i = 0; i < höjd; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(tecken);
            }
            Console.WriteLine();
        }
    }

    else if (val == "3")
    {
        Console.Write("Ange bredd: ");
        string inputBredd = Console.ReadLine();
        int bredd;
        while (!int.TryParse(inputBredd, out bredd))
        {
            Console.Write("Ange ett giltigt heltal: ");
            inputBredd = Console.ReadLine();
        }

       Höjd();
       RitTecken();

        for (int i = 0; i < höjd; i++)
        {
            for (int j = 0; j < bredd; j++)
            {
                Console.Write(tecken);
            }
            Console.WriteLine();
        }
    }

    else if (val == "4")
    {
       Höjd();
       RitTecken();
       HöjdTecken();
    }
    else if (val == "5")
    {
        Console.WriteLine("Ange figur att spara:");
        string figur = Console.ReadLine();
        File.WriteAllText("figur.txt", figur);
        Console.WriteLine("Figuren har sparats!");
    }
    else if (val == "6")
    {
        if (File.Exists("figur.txt"))
        {
            Console.WriteLine("Senast sparade figur:");
            Console.WriteLine(File.ReadAllText("figur.txt"));
        }
        else
        {
            Console.WriteLine("Ingen sparad figur hittades.");
        }
    }
    else if (val == "7")
    {
        Random slump = new Random();
        int korrektSvar = slump.Next(3, 10);

        Console.Write("Gissa storleken på figuren: ");
        string input = Console.ReadLine();
        int gissning;
        while (!int.TryParse(input, out gissning))
        {
            Console.Write("Ange ett giltigt heltal: ");
            input = Console.ReadLine();
        }

        if (gissning == korrektSvar)
        {
            Console.WriteLine("Rätt gissat! Du får 1 poäng.");
            poäng++;
        }
        else
        {
            Console.WriteLine($"Fel! Rätt svar var {korrektSvar}.");
        }

        Console.WriteLine($"Nuvarande poäng: {poäng}");

        for (int i = 0; i < korrektSvar; i++)
        {
            for (int j = 0; j < korrektSvar; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    else if (val == "8")
    {
        kör = false;
    }
    else
    {
        Console.WriteLine("Ogiltigt alternativ, försök igen.");
    }

    Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");
    Console.ReadKey();
    Console.Clear();
}

/* **********************************************
 *  Metoder 
 ********************************************** */

static void StartProgram()
{
    Console.Clear();
    Console.WriteLine("""
    Program för att rita konsolgrafik
    ===================================
    """);
}

static void AngeStorlek()
{
    string input = Console.ReadLine();
    int tal;
    while (!int.TryParse(input, out tal))
    {
        Console.Write("Ange ett giltigt heltal: ");
        input = Console.ReadLine();
    }
    return tal;
}

static void RitTecken()
{
    Console.Write("Ange ett tecken att rita med: ");
    char tecken = Console.ReadKey().KeyChar;
    Console.WriteLine();
}

static void StorlekTecken(int storlek,int tecken)
{
    for (int i = 0; i < storlek; i++)
        {
            for (int j = 0; j < storlek; j++)
            {
                Console.Write(tecken);
            }
            Console.WriteLine();
        }
}

static void Höjd()
{
     Console.Write("Ange höjd: ");
        string input = Console.ReadLine();
        int höjd;
        while (!int.TryParse(input, out höjd))
        {
            Console.Write("Ange ett giltigt heltal: ");
            input = Console.ReadLine();
        }
}

static void bred()
{
    
}


static void HöjdTecken(int höjd, string tecken)
{
     for (int i = 0; i < höjd; i++)
        {
            for (int j = 0; j < höjd - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write(tecken);
            }
            Console.WriteLine();
        }
}