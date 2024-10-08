﻿// Spelet gissa ett slumptal1 1-100 
using System.ComponentModel;

Console.Clear();
Console.WriteLine("Spelet -gissa ett slumptal1 1-100");


//En variabel för att hålla koll på antal gissningar

int antal = 0;

// Be användaren ange slumptalets max min
Console.Write("Ange slumptalets min värde:");
int min = int.Parse(Console.ReadLine());
Console.Write("Ange slumptalets max värde:");
int max = int.Parse(Console.ReadLine());

//Slumpar ett tal 1-100
int slumptal = Random.Shared.Next(min, max + 1);

// upprepning - loop
while (true)
{
    // ställ fråga till användaren
    Console.Write($"Gissa ett tal ({min}-{max}:) ");

    int gissning = int.Parse(Console.ReadLine());

    // Räkna upp antal med 1
    antal++;

    // Kontroll om gissning är rätt?

    if (gissning == slumptal)
    {
        Console.WriteLine("rätt gissat på {antal} gånger!" );
        break;

    }
    else if (gissning > slumptal)
    {
        Console.WriteLine("för högt!");
    }
    else
    {
        Console.WriteLine("För lågt!");
    }

    //Vill användaren gissa igen?
    Console.Write("Vill du gissa en gång till (j/n): ");
    string svar = Console.ReadLine();
    if (svar == "n")
    {
       break;
    }
}

//Spelet slut
Console.WriteLine("Slut!, Tack för att du spelade!");