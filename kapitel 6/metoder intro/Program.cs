using System.Runtime.InteropServices;

Console.Clear();
Console.WriteLine("Hej metoder");

//anropa/använd metoden
SägHej();
SägHej();
SägHej();
SägHej();
SägHej();

/// <summary>
/// Metod som skriver ut en hälsning
/// </summary>

static void SägHej()
{
    Console.WriteLine("Hej på dig");
}


/// <summary>
/// Metod för att visa en meny
/// </summary>
static void VisaMeny()
{
    Console.WriteLine("""
    1.Lägg till uppgift
    2.Ta bort uppgift
    3.skriv ut alla uppgifter
    4. avsluta
    """);

}

VisaMeny();


/// <summary>
/// galen variabel
/// </summary>
static void FittaOchKebab()

{
    Console.WriteLine("""
    Jag vill ha
    Extra SÅS
    """);
}

FittaOchKebab();



/// <summary>
/// skriv ut hälsning
/// </summary>
/// <param name="namn"> Namnet</param>

static void SägHEjNamn(string namn)
{
    Console.WriteLine($"hej på dig {namn}!");
}

SägHEjNamn();

