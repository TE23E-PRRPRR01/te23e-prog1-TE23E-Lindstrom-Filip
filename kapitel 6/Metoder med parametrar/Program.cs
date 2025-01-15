/*****************************************************************
* *********************  M A I N  ********************************
/ ****************************************************************/

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

Console.Clear();

// Skriv ut ett meddelande vertikalt
string meddelande = "måndag";
skibitoilet(meddelande);

// Skriv ut ett meddelande vertikalt nr2
string meddelande2 = "Röv";
skibitoilet(meddelande2);

// Skriv ut ett meddelande vertikalt
string meddelande3 = "Röv";
skibitoilet(meddelande3);

megaskibiditoilet(4);

//upprepishTextJAOW("hej",3);

temperaturomvandling(30);

kastatärning(6);

static void skibitoilet(string meddelande)
{
    for (int i = 0; i < meddelande.Length; i++)
    {
        Console.WriteLine(meddelande[i]);
    }
}


static void megaskibiditoilet(int bred)
{
    for (int i = 0; i < bred; i++)
    {
        for (int p = 0; p < bred; p++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}


static void upprepishTextJAOW(string text, int antal)
{
    for (int i = 0; i < antal; i++)
    {
        for (int p = 0; p < int.Parse(text); p++)
        {
        Console.WriteLine();
        }
        
    }
}

static void temperaturomvandling(int celsius, int fahrenheit)
{
    fahrenheit = celsius * 9/5 + 32;
    Console.WriteLine($"{celsius} grader celsius motsvarar {fahrenheit} grader fahrenheit");
}


static void kastatärning(int antal

for (int i = 0; i < antal; i++)
{
    Console.WriteLine($"tärningen visar {Random.Shared.Next(1, 7)}");
} 

